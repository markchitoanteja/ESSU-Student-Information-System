using System;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void Display_Data()
        {
            Database_Model database_model = new Database_Model();

            lbl_registered_students.Text = database_model.Count_All("students").ToString();
            lbl_active_students.Text = database_model.Count_Items("students", "status", "Active").ToString();
            lbl_non_active_students.Text = database_model.Count_Items("students", "status", "Inactive").ToString();

            var logs = database_model.Get_All("logs", "id", "DESC");

            lv_recent_activities.Items.Clear();

            foreach (var log in logs)
            {
                ListViewItem item = new ListViewItem(log["id"].ToString());

                item.SubItems.Add(Convert.ToDateTime(log["created_at"]).ToString("MMMM dd, yyyy hh:mm tt"));
                item.SubItems.Add(log["activity"].ToString());

                lv_recent_activities.Items.Add(item);
            }
        }

        private void Center_Control(Control my_control, String dimension)
        {
            if (dimension == "horizontal")
            {
                my_control.Left = (my_control.Parent.ClientSize.Width - my_control.Width) / 2;
            }

            if (dimension == "vertical")
            {
                my_control.Top = (my_control.Parent.ClientSize.Height - my_control.Height) / 2;
            }

            if (dimension == "both")
            {
                my_control.Left = (my_control.Parent.ClientSize.Width - my_control.Width) / 2;
                my_control.Top = (my_control.Parent.ClientSize.Height - my_control.Height) / 2;
            }
        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            Center_Control(pnl_active_students, "horizontal");

            if (lv_recent_activities.Columns.Count == 3)
            {
                lv_recent_activities.Columns[0].Width = 0;

                int totalWidth = lv_recent_activities.ClientSize.Width;
                int secondColumnWidth = (int)(totalWidth * 0.30);
                int thirdColumnWidth = (int)(totalWidth * 0.70);

                lv_recent_activities.Columns[1].Width = secondColumnWidth;
                lv_recent_activities.Columns[2].Width = thirdColumnWidth;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Main main = FindForm() as Main;

            main.More_Info();
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            DialogResult dialog_result = MessageBox.Show("Do you want to clear all the recent activities?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog_result == DialogResult.Yes)
            {
                Database_Model database_model = new Database_Model();

                database_model.Delete("logs");

                Display_Data();

                MessageBox.Show("Recent Activities has been cleared.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
