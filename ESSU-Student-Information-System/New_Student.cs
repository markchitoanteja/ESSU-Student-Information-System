using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class New_Student : Form
    {
        private Student_Records _student_records;

        private int loading_counter;
        private bool is_loading = false;
        private string image_path;
        
        public New_Student(Student_Records student_records)
        {
            InitializeComponent();

            _student_records = student_records;
        }

        private string Upload_Image(string image_path)
        {
            string imageFolderPath = Path.Combine(Application.StartupPath, "images", "uploads");
            string fileExtension = Path.GetExtension(image_path);

            string image = Guid.NewGuid().ToString() + fileExtension;

            string newFilePath = Path.Combine(imageFolderPath, image);

            File.Copy(image_path, newFilePath);

            return image;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (!is_loading)
            {
                Close();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            bool is_error = false;

            if (string.IsNullOrEmpty(txt_student_number.Text))
            {
                error_student_number.SetError(txt_student_number, "Student Number is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_course.Text))
            {
                error_course.SetError(txt_course, "Course is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_year.Text))
            {
                error_year.SetError(txt_year, "Year is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_section.Text))
            {
                error_section.SetError(txt_section, "Section is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_first_name.Text))
            {
                error_first_name.SetError(txt_first_name, "First Name is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_last_name.Text))
            {
                error_last_name.SetError(txt_last_name, "Last Name is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_birthday.Text))
            {
                error_birthday.SetError(txt_birthday, "Birthday is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_mobile_number.Text))
            {
                error_mobile_number.SetError(txt_mobile_number, "Mobile Number is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_email.Text))
            {
                error_email.SetError(txt_email, "Email is required!");

                is_error = true;
            }

            if (string.IsNullOrEmpty(txt_address.Text))
            {
                error_address.SetError(txt_address, "Address is required!");

                is_error = true;
            }

            if (!is_error)
            {
                if (image_path == null)
                {
                    MessageBox.Show("Image is required!", "Oops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Validator validator = new Validator();

                    if (!validator.IsValidStudentNumber(txt_student_number.Text))
                    {
                        error_student_number.SetError(txt_student_number, "Student Number is not in valid format!");

                        txt_student_number.Focus();

                        is_error = true;
                    }

                    if (!validator.IsValidBirthday(txt_birthday.Value))
                    {
                        error_birthday.SetError(txt_birthday, "Birthday is not valid!");

                        txt_birthday.Focus();

                        is_error = true;
                    }

                    if (!validator.IsValidMobileNumber(txt_mobile_number.Text))
                    {
                        error_mobile_number.SetError(txt_mobile_number, "Mobile Number is not valid!");

                        txt_mobile_number.Focus();

                        is_error = true;
                    }

                    if (!validator.IsValidEmail(txt_email.Text))
                    {
                        error_email.SetError(txt_email, "Email is not valid!");

                        txt_email.Focus();

                        is_error = true;
                    }

                    if (!is_error)
                    {
                        loading_counter = 500;

                        if (!is_loading)
                        {
                            btn_submit.Text = "Please Wait..";

                            timer1.Start();
                        }
                    }
                }
            }

        }

        private void txt_student_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_student_number.Dispose();
        }

        private void txt_course_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_course.Dispose();
        }

        private void txt_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_year.Dispose();
        }

        private void txt_section_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_section.Dispose();
        }

        private void txt_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_first_name.Dispose();
        }

        private void txt_last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_last_name.Dispose();
        }

        private void txt_birthday_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_birthday.Dispose();
        }

        private void txt_mobile_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_mobile_number.Dispose();

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_email.Dispose();
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_address.Dispose();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            btn_temp.Focus();

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_image.Image = Image.FromFile(openFileDialog.FileName);

                image_path = openFileDialog.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading_counter += 500;

            if (loading_counter == 1500)
            {
                is_loading = false;

                timer1.Stop();

                string image = Upload_Image(image_path);

                Main_Model main_model = new Main_Model();

                if (main_model.Mod_Insert_Student(txt_student_number.Text, txt_course.Text, txt_year.Text, txt_section.Text, txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_birthday.Text, txt_mobile_number.Text, txt_email.Text, txt_address.Text, image))
                {
                    _student_records.Display_Data();

                    Hide();

                    MessageBox.Show("A new student is added to the database.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }

                else
                {
                    btn_submit.Text = "&Submit";

                    error_student_number.SetError(txt_student_number, "Student Number is already in use!");
                    
                    txt_student_number.Focus();
                }
            }
        }
    }
}
