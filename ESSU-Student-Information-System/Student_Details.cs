using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Student_Details : Form
    {
        private Student_Records _student_records;

        private int loading_counter;
        private bool is_loading = false;
        private string image_path;
        private bool is_update_student = false;
        private bool is_new_image = false;
        
        public Student_Details(Student_Records student_records)
        {
            InitializeComponent();

            _student_records = student_records;
        }

        public void Display_Student_Details(string student_id)
        {
            is_update_student = true;

            lbl_student_details_title.Text = "Update Student";

            Database_Model database_model = new Database_Model();

            var student_data = database_model.Get_One("students", "id", student_id);

            string imageFolderPath = Path.Combine(Application.StartupPath, "images", "uploads");

            image_path = Path.Combine(imageFolderPath, student_data["image"].ToString());

            lbl_student_id.Text = student_data["id"].ToString();
            img_image.Image = Image.FromFile(image_path);
            txt_student_number.Text = student_data["student_number"].ToString();
            txt_course.Text = student_data["course"].ToString();
            txt_year.Text = student_data["year"].ToString();
            txt_section.Text = student_data["section"].ToString();
            txt_first_name.Text = student_data["first_name"].ToString();
            txt_middle_name.Text = student_data["middle_name"].ToString();
            txt_last_name.Text = student_data["last_name"].ToString();
            txt_birthday.Value = Convert.ToDateTime(student_data["birthday"].ToString());
            txt_mobile_number.Text = student_data["mobile_number"].ToString();
            txt_email.Text = student_data["email"].ToString();
            txt_address.Text = student_data["address"].ToString();
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
                if (is_update_student)
                {
                    is_new_image = true;
                }

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

                Main_Model main_model = new Main_Model();

                if (!is_update_student)
                {
                    string image = Upload_Image(image_path);

                    if (main_model.Mod_Insert_Student(txt_student_number.Text, txt_course.Text, txt_year.Text, txt_section.Text, txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_birthday.Text, txt_mobile_number.Text, txt_email.Text, txt_address.Text, image))
                    {
                        _student_records.Display_Data();

                        Logger logger = new Logger();

                        logger.Log("A new student is added to the database.");

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

                else
                {
                    string image;

                    if (is_new_image)
                    {
                        image = Upload_Image(image_path);
                    }

                    else
                    {
                        image = Path.GetFileName(image_path);
                    }

                    if (main_model.Mod_Update_Student(lbl_student_id.Text, txt_student_number.Text, txt_course.Text, txt_year.Text, txt_section.Text, txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_birthday.Text, txt_mobile_number.Text, txt_email.Text, txt_address.Text, image))
                    {
                        _student_records.Display_Data();

                        Logger logger = new Logger();

                        logger.Log("A student has been updated.");

                        Hide();

                        MessageBox.Show("A student has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
}
