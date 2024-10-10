using System;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Student_Records : UserControl
    {
        public Student_Records()
        {
            InitializeComponent();
        }

        public void Display_Data()
        {
            Database_Model database_model = new Database_Model();

            var students = database_model.Get_All("students", "id", "DESC");

            lvl_student_list.Items.Clear();

            foreach (var student in students)
            {
                string firstName = student["first_name"].ToString();
                string middleName = student.ContainsKey("middle_name") && !string.IsNullOrEmpty(student["middle_name"].ToString()) ? student["middle_name"].ToString()[0] + "." : string.Empty;
                string lastName = student["last_name"].ToString();

                string fullName = string.IsNullOrEmpty(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

                ListViewItem item = new ListViewItem(student["id"].ToString());

                item.SubItems.Add(fullName);
                item.SubItems.Add(student["course"].ToString() + " " + student["year"].ToString()[0] + "-" + student["section"].ToString());
                item.SubItems.Add(Convert.ToDateTime(student["birthday"]).ToString("MMMM dd, yyyy"));
                item.SubItems.Add(student["email"].ToString());
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
                int secondColumnWidth = (int)(totalWidth * 0.25);
                int thirdColumnWidth = (int)(totalWidth * 0.25);
                int fourthColumnWidth = (int)(totalWidth * 0.20);
                int fifthColumnWidth = (int)(totalWidth * 0.20);
                int sixthColumnWidth = (int)(totalWidth * 0.10);

                lvl_student_list.Columns[1].Width = secondColumnWidth;
                lvl_student_list.Columns[2].Width = thirdColumnWidth;
                lvl_student_list.Columns[3].Width = fourthColumnWidth;
                lvl_student_list.Columns[4].Width = fifthColumnWidth;
                lvl_student_list.Columns[5].Width = sixthColumnWidth;
            }
        }

        private void btn_new_student_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            New_Student new_student = new New_Student(this);

            new_student.ShowDialog();
        }
    }
}
