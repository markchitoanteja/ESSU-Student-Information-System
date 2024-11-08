using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Student_Records : UserControl
    {
        private string student_id;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private Bitmap listViewImage;
        private bool isUpdating = false;

        public Student_Records()
        {
            InitializeComponent();

            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printDocument.DefaultPageSettings.Landscape = true;

            printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            txt_course.SelectedItem = "All Courses";
        }

        private void ShowPrintPreview()
        {
            CaptureListViewImage();

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                PrintListView();
            }

        }

        private void CaptureListViewImage()
        {
            listViewImage = new Bitmap(lvl_student_list.Width, lvl_student_list.Height);

            lvl_student_list.DrawToBitmap(listViewImage, new Rectangle(0, 0, lvl_student_list.Width, lvl_student_list.Height));
        }

        private void PrintListView()
        {
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string course = " (All Courses)";

            if (!string.IsNullOrEmpty(txt_course.Text))
            {
                course = " (" + txt_course.Text + ")";
            }

            string headerText = "Student Records" + course;

            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Brush headerBrush = Brushes.Black;

            float headerX = e.MarginBounds.Left;
            float headerY = e.MarginBounds.Top - headerFont.GetHeight(e.Graphics) - 10;

            e.Graphics.DrawString(headerText, headerFont, headerBrush, headerX, headerY);

            Rectangle printArea = e.MarginBounds;
            printArea.Y += (int)headerFont.GetHeight(e.Graphics) + 20;

            if (listViewImage != null)
            {
                e.Graphics.DrawImage(listViewImage, printArea);
            }
        }

        public void Display_Data()
        {
            btn_update_student.Enabled = false;
            btn_set_as_inactive.Enabled = false;
            btn_delete.Enabled = false;

            btn_print_record.Enabled = true;

            Database_Model database_model = new Database_Model();

            var students = database_model.Get_Many("students", "status", "Deleted", "id", "DESC", "!=");

            lvl_student_list.Items.Clear();

            foreach (var student in students)
            {
                string firstName = student["first_name"].ToString();
                string middleName = student.ContainsKey("middle_name") && !string.IsNullOrEmpty(student["middle_name"].ToString()) ? student["middle_name"].ToString()[0] + "." : string.Empty;
                string lastName = student["last_name"].ToString();

                string fullName = string.IsNullOrEmpty(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

                ListViewItem item = new ListViewItem(student["id"].ToString());

                item.SubItems.Add(student["student_number"].ToString());
                item.SubItems.Add(fullName);
                item.SubItems.Add(student["course"].ToString() + " " + student["year"].ToString()[0] + "-" + student["section"].ToString());
                item.SubItems.Add(Convert.ToDateTime(student["birthday"]).ToString("MMMM dd, yyyy"));
                item.SubItems.Add(student["status"].ToString());

                lvl_student_list.Items.Add(item);
            }
        }

        private void Student_Records_SizeChanged(object sender, EventArgs e)
        {
            if (lvl_student_list.Columns.Count == 6)
            {
                lvl_student_list.Columns[0].Width = 0;

                int totalWidth = lvl_student_list.ClientSize.Width;
                int secondColumnWidth = (int)(totalWidth * 0.20);
                int thirdColumnWidth = (int)(totalWidth * 0.25);
                int fourthColumnWidth = (int)(totalWidth * 0.20);
                int fifthColumnWidth = (int)(totalWidth * 0.25);
                int sixthColumnWidth = (int)(totalWidth * 0.10);

                lvl_student_list.Columns[1].Width = secondColumnWidth;
                lvl_student_list.Columns[2].Width = thirdColumnWidth;
                lvl_student_list.Columns[3].Width = fourthColumnWidth;
                lvl_student_list.Columns[4].Width = fifthColumnWidth;
                lvl_student_list.Columns[5].Width = sixthColumnWidth;
            }
        }

        private void lvl_student_list_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvl_student_list.HitTest(e.Location).Item == null)
            {
                lvl_student_list.SelectedItems.Clear();

                student_id = null;

                btn_update_student.Enabled = false;
                btn_set_as_inactive.Enabled = false;
                btn_delete.Enabled = false;

                btn_print_record.Enabled = true;
            }
        }

        private void lvl_student_list_Click(object sender, EventArgs e)
        {
            student_id = lvl_student_list.SelectedItems[0].Text;

            string status = lvl_student_list.SelectedItems[0].SubItems[5].Text;

            if (status == "Active")
            {
                btn_update_student.Enabled = true;
                btn_set_as_inactive.Enabled = true;
                btn_delete.Enabled = true;

                btn_print_record.Enabled = false;
            }

            else
            {
                btn_update_student.Enabled = false;
                btn_set_as_inactive.Enabled = false;
                btn_delete.Enabled = false;

                btn_print_record.Enabled = true;

                DialogResult dialog_result = MessageBox.Show("Set this student to active again?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog_result == DialogResult.Yes)
                {
                    Database_Model database_model = new Database_Model();

                    DateTime currentDateTime = DateTime.Now;

                    Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "status", "Active" },
                    { "updated_at", currentDateTime }
                };

                    database_model.Update("students", data, "id", student_id);

                    Display_Data();

                    lvl_student_list.SelectedItems.Clear();

                    student_id = null;

                    MessageBox.Show("A student has been set to active.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    lvl_student_list.SelectedItems.Clear();

                    student_id = null;
                }
            }
        }

        private void lvl_student_list_DoubleClick(object sender, EventArgs e)
        {
            student_id = lvl_student_list.SelectedItems[0].Text;

            string status = lvl_student_list.SelectedItems[0].SubItems[5].Text;

            if (status == "Active")
            {
                btn_update_student.Enabled = true;
                btn_set_as_inactive.Enabled = true;
                btn_delete.Enabled = true;

                btn_print_record.Enabled = false;
            }

            btn_update_student.PerformClick();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
            {
                return;
            }

            if (string.IsNullOrEmpty(txt_search.Text))
            {
                Display_Data();
            }

            else
            {
                isUpdating = true;
                txt_course.SelectedItem = "All Courses";
                isUpdating = false;

                Database_Model database_model = new Database_Model();

                var students = database_model.Search("students", "student_number", txt_search.Text, "status", "Deleted", "first_name", "ASC", "!=");

                lvl_student_list.Items.Clear();

                foreach (var student in students)
                {
                    string firstName = student["first_name"].ToString();
                    string middleName = student.ContainsKey("middle_name") && !string.IsNullOrEmpty(student["middle_name"].ToString()) ? student["middle_name"].ToString()[0] + "." : string.Empty;
                    string lastName = student["last_name"].ToString();

                    string fullName = string.IsNullOrEmpty(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

                    ListViewItem item = new ListViewItem(student["id"].ToString());

                    item.SubItems.Add(student["student_number"].ToString());
                    item.SubItems.Add(fullName);
                    item.SubItems.Add(student["course"].ToString() + " " + student["year"].ToString()[0] + "-" + student["section"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(student["birthday"]).ToString("MMMM dd, yyyy"));
                    item.SubItems.Add(student["status"].ToString());

                    lvl_student_list.Items.Add(item);
                }
            }
        }

        private void txt_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating)
            {
                return;
            }
               
            if (txt_course.Text == "All Courses")
            {
                Display_Data();
            }

            else
            {
                isUpdating = true;
                txt_search.Clear();
                isUpdating = false;

                Database_Model database_model = new Database_Model();

                var students = database_model.Search("students", "course", txt_course.Text, "status", "Deleted", "first_name", "ASC", "!=");

                lvl_student_list.Items.Clear();

                foreach (var student in students)
                {
                    string firstName = student["first_name"].ToString();
                    string middleName = student.ContainsKey("middle_name") && !string.IsNullOrEmpty(student["middle_name"].ToString()) ? student["middle_name"].ToString()[0] + "." : string.Empty;
                    string lastName = student["last_name"].ToString();

                    string fullName = string.IsNullOrEmpty(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

                    ListViewItem item = new ListViewItem(student["id"].ToString());

                    item.SubItems.Add(student["student_number"].ToString());
                    item.SubItems.Add(fullName);
                    item.SubItems.Add(student["course"].ToString() + " " + student["year"].ToString()[0] + "-" + student["section"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(student["birthday"]).ToString("MMMM dd, yyyy"));
                    item.SubItems.Add(student["status"].ToString());

                    lvl_student_list.Items.Add(item);
                }
            }
        }

        private void btn_new_student_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            Student_Details new_student = new Student_Details(this);

            new_student.ShowDialog();
        }

        private void btn_print_record_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            ShowPrintPreview();
        }

        private void btn_set_as_inactive_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            DialogResult dialog_result = MessageBox.Show("Set this student to inactive?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog_result == DialogResult.Yes)
            {
                Database_Model database_model = new Database_Model();

                DateTime currentDateTime = DateTime.Now;

                Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "status", "Inactive" },
                    { "updated_at", currentDateTime }
                };

                database_model.Update("students", data, "id", student_id);

                Display_Data();

                lvl_student_list.SelectedItems.Clear();

                student_id = null;

                btn_update_student.Enabled = false;
                btn_set_as_inactive.Enabled = false;
                btn_delete.Enabled = false;

                btn_print_record.Enabled = true;

                Logger logger = new Logger();

                logger.Log("A student has been set to inactive.");

                MessageBox.Show("A student has been set to inactive.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            Student_Details student_details = new Student_Details(this);

            student_details.Display_Student_Details(student_id);

            student_details.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            DialogResult dialog_result = MessageBox.Show("Do you want to DROP this student?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog_result == DialogResult.Yes)
            {
                Database_Model database_model = new Database_Model();

                DateTime currentDateTime = DateTime.Now;

                Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "status", "Deleted" },
                    { "updated_at", currentDateTime }
                };

                database_model.Update("students", data, "id", student_id);

                Display_Data();

                lvl_student_list.SelectedItems.Clear();

                student_id = null;

                btn_update_student.Enabled = false;
                btn_set_as_inactive.Enabled = false;

                btn_print_record.Enabled = true;

                Logger logger = new Logger();

                logger.Log("A student has been moved to dropped students.");

                MessageBox.Show("A student has been moved to dropped students.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}