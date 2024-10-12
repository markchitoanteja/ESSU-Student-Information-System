using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Login : Form
    {
        bool is_password_shown = false;
        bool is_loading= false;
        int delay = 500;
        
        public Login()
        {
            InitializeComponent();
        }

        private bool Verify_Login(string username, string password)
        {
            bool response = false;

            Login_Model login_model = new Login_Model();

            string admin_id = login_model.Mod_Login_Admin(username, password);

            if (!string.IsNullOrEmpty(admin_id))
            {
                Session.admin_id = admin_id;

                response = true;
            }

            return response;
        }

        private void img_show_hide_password_Click(object sender, EventArgs e)
        {
            if (!is_password_shown)
            {
                txt_password.UseSystemPasswordChar = false;
                img_show_hide_password.Image = Image.FromFile("images/hide-password.png");

                is_password_shown = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                img_show_hide_password.Image = Image.FromFile("images/show-password.png");

                is_password_shown = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            txt_temp.Focus();

            if (!is_loading)
            {
                delay = 500;

                int errors = 0;

                if (string.IsNullOrEmpty(txt_username.Text))
                {
                    err_username.SetError(txt_username, "Username is required!");

                    errors++;
                }

                if (string.IsNullOrEmpty(txt_password.Text))
                {
                    err_password.SetError(txt_password, "Password is required!");

                    errors++;
                }

                if (errors == 0)
                {
                    is_loading = true;

                    btn_login.Text = "Please Wait...";

                    delayer.Start();
                }
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            err_username.Dispose();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            err_password.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Session.remember_me_data.Count > 0)
            {
                txt_username.Text = Session.remember_me_data["username"];
                txt_password.Text = Session.remember_me_data["password"];

                chk_remember_me.Checked = true;
            }
        }

        private void delayer_Tick(object sender, EventArgs e)
        {
            delay += 500;

            if (delay == 1000)
            {
                if (Verify_Login(txt_username.Text, txt_password.Text))
                {
                    Hide();

                    Logger logger = new Logger();

                    logger.Log("Admin has successfully logged in to the system.");

                    MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (chk_remember_me.Checked)
                    {
                        Session.remember_me_data["username"] = txt_username.Text;
                        Session.remember_me_data["password"] = txt_password.Text;
                    }

                    else
                    {
                        Session.remember_me_data.Clear();
                    }

                    Main main = new Main();

                    main.Show();
                }

                else
                {
                    is_loading = false;

                    btn_login.Text = "Login";

                    MessageBox.Show("Invalid Username or Password!", "Oops..", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_username.Focus();
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset_Password reset_password = new Reset_Password(txt_password);

            reset_password.ShowDialog();
        }
    }
}
