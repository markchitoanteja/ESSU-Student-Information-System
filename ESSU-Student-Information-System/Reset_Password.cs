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
    public partial class Reset_Password : Form
    {
        private TextBox login_txt_password;
        private int reset_timer;
        private bool is_loading = false;

        public Reset_Password(TextBox login_txt_password)
        {
            InitializeComponent();

            this.login_txt_password = login_txt_password;
        }

        private bool Password_Verify(string password, string hashed_password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashed_password);
        }

        private string Generate_Password(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            char[] passwordChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                passwordChars[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(passwordChars);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (!is_loading)
            {
                Close();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (!is_loading)
            {
                reset_timer = 500;

                btn_temp.Focus();

                if (string.IsNullOrEmpty(txt_developer_password.Text))
                {
                    error_developer_password.SetError(txt_developer_password, "Developer's Password is required.");
                }

                else
                {
                    is_loading = true;

                    btn_submit.Text = "Please Wait..";

                    timer1.Start();
                }
            }
        }

        private void txt_developer_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_developer_password.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reset_timer += 500;

            if (reset_timer == 1500)
            {
                if (Password_Verify(txt_developer_password.Text, Session.developer_password))
                {
                    Hide();

                    string temporary_password = Generate_Password(8);

                    MessageBox.Show("Please use this temporary password: " + temporary_password, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Session.temporary_password = temporary_password;

                    login_txt_password.Text = temporary_password;

                    Close();
                }

                else
                {
                    is_loading = false;

                    timer1.Stop();

                    btn_submit.Text = "&Submit";

                    MessageBox.Show("Invalid Password!", "Oops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
