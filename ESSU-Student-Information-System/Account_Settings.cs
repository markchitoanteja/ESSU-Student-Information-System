using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Account_Settings : UserControl
    {
        private int loading_timer;
        private bool is_new_image;
        
        public Account_Settings()
        {
            InitializeComponent();
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

        private void Account_Settings_SizeChanged(object sender, EventArgs e)
        {
            Center_Control(pnl_profile_card, "horizontal");
            Center_Control(loading, "both");
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            bool is_error = false;

            if (string.IsNullOrEmpty(txt_name.Text))
            {
                error_name.SetError(txt_name, "Name is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_username.Text))
            {
                error_username.SetError(txt_username, "Username is required!");

                is_error = true;
            }

            if (!string.IsNullOrEmpty(txt_password.Text) || !string.IsNullOrEmpty(txt_confirm_password.Text))
            {
                if (txt_password.Text != txt_confirm_password.Text)
                {
                    error_password.SetError(txt_password, "Passwords do not matched!");
                    error_confirm_password.SetError(txt_confirm_password, "Passwords do not matched!");

                    is_error = true;
                }
            }

            if (!is_error)
            {
                loading_timer = 500;

                pnl_profile_card.Visible = false;
                loading.Visible = true;

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading_timer += 500;

            if (loading_timer == 1500)
            {
                string password;
                string image;

                if (string.IsNullOrEmpty(txt_password.Text))
                {
                    password = lbl_old_password.Text;
                }

                else
                {
                    password = BCrypt.Net.BCrypt.HashPassword(txt_password.Text);
                }

                if (is_new_image)
                {
                    string imageFolderPath = Path.Combine(Application.StartupPath, "images", "uploads");
                    string fileExtension = Path.GetExtension(lbl_image.Text);

                    image = Guid.NewGuid().ToString() + fileExtension;

                    string newFilePath = Path.Combine(imageFolderPath, image);

                    File.Copy(lbl_image.Text, newFilePath);
                }

                else
                {
                    image = lbl_image.Text;
                }

                Main_Model main_model = new Main_Model();

                main_model.Mod_Update_Admin(Session.admin_id, txt_name.Text, txt_username.Text, password, image);

                txt_password.Clear();
                txt_confirm_password.Clear();

                loading.Visible = false;
                pnl_profile_card.Visible = true;

                var main = FindForm() as Main;

                main.Set_Admin_Details();

                MessageBox.Show("Admin data is successfully updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            is_new_image = false;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_image.Image = Image.FromFile(openFileDialog.FileName);

                lbl_image.Text = openFileDialog.FileName;

                is_new_image = true;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_name.Dispose();
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_username.Dispose();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_password.Dispose();
            error_confirm_password.Dispose();
        }
    }
}
