using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Deleted_Students : UserControl
    {
        public Deleted_Students()
        {
            InitializeComponent();
        }

        public void Display_Data()
        {
            Database_Model database_model = new Database_Model();

            var students = database_model.Get_Many("students", "status", "Deleted", "id", "DESC");

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

        private void Deleted_Students_SizeChanged(object sender, EventArgs e)
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                Display_Data();
            }

            else
            {
                Database_Model database_model = new Database_Model();

                var students = database_model.Search("students", "student_number", txt_search.Text, "status", "Deleted", "first_name", "ASC", "=");

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
    }
}
