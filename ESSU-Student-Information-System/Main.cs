using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Main : Form
    {
        private string active_page = "Dashboard";
        private bool is_hide_sidebar = false;
   
        public Main()
        {
            InitializeComponent();
        }

        public void Set_Admin_Details()
        {
            Main_Model main_model = new Main_Model();

            var admin_data = main_model.Mod_Get_Admin_data(Session.admin_id);

            lbl_admin_name.Text = admin_data["name"].ToString();
            img_admin_image.Image = Image.FromFile("images/uploads/" + admin_data["image"].ToString());
        }

        private void Set_Active(Control sidebar_button)
        {
            btn_dashboard.BackColor = Color.Transparent;
            btn_student_records.BackColor = Color.Transparent;
            btn_account_settings.BackColor = Color.Transparent;

            sidebar_button.BackColor = Color.FromArgb(13, 110, 253);

            if (sidebar_button.Name == "btn_dashboard")
            {
                user_control_dashboard.BringToFront();
            }

            if (sidebar_button.Name == "btn_student_records")
            {
                user_control_student_records.BringToFront();
            }

            if (sidebar_button.Name == "btn_account_settings")
            {
                user_control_account_settings.BringToFront();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Set_Admin_Details();
            
            Session.is_application_exiting = false;
        }

        private void btn_toggle_sidebar_Click(object sender, EventArgs e)
        {
            if (!is_hide_sidebar)
            {
                pnl_sidebar.Width = 65;

                is_hide_sidebar = true;
            }
            else
            {
                pnl_sidebar.Width = 255;

                is_hide_sidebar = false;
            }
        }

        private void dashboard_img_MouseEnter(object sender, EventArgs e)
        {
            if (active_page != "Dashboard")
            {
                btn_dashboard.BackColor = Color.FromArgb(69, 77, 85);
            }
        }

        private void dashboard_img_MouseLeave(object sender, EventArgs e)
        {
            if (active_page != "Dashboard")
            {
                btn_dashboard.BackColor = Color.Transparent;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (active_page != "Student Records")
            {
                btn_student_records.BackColor = Color.FromArgb(69, 77, 85);
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (active_page != "Student Records")
            {
                btn_student_records.BackColor = Color.Transparent;
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (active_page != "Account Settings")
            {
                btn_account_settings.BackColor = Color.FromArgb(69, 77, 85);
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (active_page != "Account Settings")
            {
                btn_account_settings.BackColor = Color.Transparent;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(69, 77, 85);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.Transparent;
        }

        private void dashboard_img_Click(object sender, EventArgs e)
        {
            active_page = "Dashboard";

            Set_Active(btn_dashboard);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Set_Active(btn_student_records);

            active_page = "Student Records";

            user_control_student_records.Display_Data();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main_Model main_Model = new Main_Model();

            var admin_data = main_Model.Mod_Get_Admin_data(Session.admin_id);

            user_control_account_settings.txt_name.Text = admin_data["name"].ToString();
            user_control_account_settings.txt_username.Text = admin_data["username"].ToString();
            user_control_account_settings.lbl_old_password.Text = admin_data["password"].ToString();
            user_control_account_settings.img_image.Image = Image.FromFile("images/uploads/" + admin_data["image"].ToString());
            user_control_account_settings.lbl_image.Text = admin_data["image"].ToString();
            user_control_account_settings.txt_password.Clear();
            user_control_account_settings.txt_confirm_password.Clear();

            user_control_account_settings.error_name.Dispose();
            user_control_account_settings.error_username.Dispose();
            user_control_account_settings.error_password.Dispose();
            user_control_account_settings.error_confirm_password.Dispose();

            Set_Active(btn_account_settings);

            active_page = "Account Settings";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Session.is_application_exiting = true;

            DialogResult result = MessageBox.Show("Do you really want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Hide();

                MessageBox.Show("You have successfully logged out.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();

                Login login = new Login();

                login.Show();
            }
            else
            {
                Session.is_application_exiting = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Session.is_application_exiting)
            {
                Session.is_application_exiting = true;

                DialogResult result = MessageBox.Show("Do you really want to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    Session.is_application_exiting = false;

                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
