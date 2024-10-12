namespace ESSU_Student_Information_System
{
    partial class Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_student_details_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.lbl_student_id = new System.Windows.Forms.Label();
            this.btn_temp = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_birthday = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mobile_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.ComboBox();
            this.txt_course = new System.Windows.Forms.ComboBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_middle_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_section = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_student_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.img_image = new System.Windows.Forms.PictureBox();
            this.error_student_number = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_course = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_year = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_section = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_first_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_birthday = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_mobile_number = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_last_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_address = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_student_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_section)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_first_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_birthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mobile_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_last_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_address)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_student_details_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 40);
            this.panel1.TabIndex = 0;
            // 
            // lbl_student_details_title
            // 
            this.lbl_student_details_title.AutoSize = true;
            this.lbl_student_details_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student_details_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_student_details_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_student_details_title.Location = new System.Drawing.Point(16, 7);
            this.lbl_student_details_title.Name = "lbl_student_details_title";
            this.lbl_student_details_title.Size = new System.Drawing.Size(145, 25);
            this.lbl_student_details_title.TabIndex = 1;
            this.lbl_student_details_title.Text = "New Student";
            this.lbl_student_details_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_submit);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 50);
            this.panel2.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(629, 7);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(150, 35);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "&Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(473, 7);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 35);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.White;
            this.pnl_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_body.Controls.Add(this.lbl_student_id);
            this.pnl_body.Controls.Add(this.btn_temp);
            this.pnl_body.Controls.Add(this.txt_address);
            this.pnl_body.Controls.Add(this.label12);
            this.pnl_body.Controls.Add(this.txt_birthday);
            this.pnl_body.Controls.Add(this.txt_email);
            this.pnl_body.Controls.Add(this.label8);
            this.pnl_body.Controls.Add(this.txt_mobile_number);
            this.pnl_body.Controls.Add(this.label9);
            this.pnl_body.Controls.Add(this.label10);
            this.pnl_body.Controls.Add(this.label7);
            this.pnl_body.Controls.Add(this.txt_year);
            this.pnl_body.Controls.Add(this.txt_course);
            this.pnl_body.Controls.Add(this.txt_last_name);
            this.pnl_body.Controls.Add(this.label4);
            this.pnl_body.Controls.Add(this.txt_middle_name);
            this.pnl_body.Controls.Add(this.label5);
            this.pnl_body.Controls.Add(this.txt_first_name);
            this.pnl_body.Controls.Add(this.label6);
            this.pnl_body.Controls.Add(this.txt_section);
            this.pnl_body.Controls.Add(this.label3);
            this.pnl_body.Controls.Add(this.label2);
            this.pnl_body.Controls.Add(this.txt_student_number);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.btn_upload);
            this.pnl_body.Controls.Add(this.img_image);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 40);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(798, 458);
            this.pnl_body.TabIndex = 2;
            // 
            // lbl_student_id
            // 
            this.lbl_student_id.AutoSize = true;
            this.lbl_student_id.Location = new System.Drawing.Point(18, 133);
            this.lbl_student_id.Name = "lbl_student_id";
            this.lbl_student_id.Size = new System.Drawing.Size(58, 13);
            this.lbl_student_id.TabIndex = 33;
            this.lbl_student_id.Text = "Student ID";
            this.lbl_student_id.Visible = false;
            // 
            // btn_temp
            // 
            this.btn_temp.Location = new System.Drawing.Point(817, 46);
            this.btn_temp.Name = "btn_temp";
            this.btn_temp.Size = new System.Drawing.Size(75, 23);
            this.btn_temp.TabIndex = 32;
            this.btn_temp.Text = "button1";
            this.btn_temp.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(21, 373);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(758, 70);
            this.txt_address.TabIndex = 11;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_address_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Address";
            // 
            // txt_birthday
            // 
            this.txt_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_birthday.Location = new System.Drawing.Point(21, 311);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(240, 26);
            this.txt_birthday.TabIndex = 8;
            this.txt_birthday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_birthday_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(539, 311);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 26);
            this.txt_email.TabIndex = 10;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(535, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Email";
            // 
            // txt_mobile_number
            // 
            this.txt_mobile_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile_number.Location = new System.Drawing.Point(280, 311);
            this.txt_mobile_number.Name = "txt_mobile_number";
            this.txt_mobile_number.Size = new System.Drawing.Size(240, 26);
            this.txt_mobile_number.TabIndex = 9;
            this.txt_mobile_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile_number_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mobile Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(665, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Section";
            // 
            // txt_year
            // 
            this.txt_year.BackColor = System.Drawing.Color.White;
            this.txt_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_year.FormattingEnabled = true;
            this.txt_year.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.txt_year.Location = new System.Drawing.Point(539, 187);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(110, 28);
            this.txt_year.TabIndex = 3;
            this.txt_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_year_KeyPress);
            // 
            // txt_course
            // 
            this.txt_course.BackColor = System.Drawing.Color.White;
            this.txt_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course.FormattingEnabled = true;
            this.txt_course.Items.AddRange(new object[] {
            "BSIT",
            "BSA",
            "BSC",
            "BSBA",
            "BSED",
            "BEED"});
            this.txt_course.Location = new System.Drawing.Point(280, 187);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(240, 28);
            this.txt_course.TabIndex = 2;
            this.txt_course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_course_KeyPress);
            // 
            // txt_last_name
            // 
            this.txt_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_name.Location = new System.Drawing.Point(539, 249);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(240, 26);
            this.txt_last_name.TabIndex = 7;
            this.txt_last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_last_name_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Name";
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_middle_name.Location = new System.Drawing.Point(280, 249);
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.Size = new System.Drawing.Size(240, 26);
            this.txt_middle_name.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Middle Name (Optional)";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first_name.Location = new System.Drawing.Point(21, 249);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(240, 26);
            this.txt_first_name.TabIndex = 5;
            this.txt_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_first_name_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "First Name";
            // 
            // txt_section
            // 
            this.txt_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_section.Location = new System.Drawing.Point(669, 189);
            this.txt_section.Name = "txt_section";
            this.txt_section.Size = new System.Drawing.Size(110, 26);
            this.txt_section.TabIndex = 4;
            this.txt_section.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_section_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course";
            // 
            // txt_student_number
            // 
            this.txt_student_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_number.Location = new System.Drawing.Point(21, 189);
            this.txt_student_number.Name = "txt_student_number";
            this.txt_student_number.Size = new System.Drawing.Size(240, 26);
            this.txt_student_number.TabIndex = 1;
            this.txt_student_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_student_number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Number";
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upload.FlatAppearance.BorderSize = 0;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.Color.White;
            this.btn_upload.Location = new System.Drawing.Point(348, 111);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(100, 35);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "&Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // img_image
            // 
            this.img_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_image.Image = ((System.Drawing.Image)(resources.GetObject("img_image.Image")));
            this.img_image.Location = new System.Drawing.Point(348, 5);
            this.img_image.Name = "img_image";
            this.img_image.Size = new System.Drawing.Size(100, 100);
            this.img_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_image.TabIndex = 0;
            this.img_image.TabStop = false;
            // 
            // error_student_number
            // 
            this.error_student_number.ContainerControl = this;
            // 
            // error_course
            // 
            this.error_course.ContainerControl = this;
            // 
            // error_year
            // 
            this.error_year.ContainerControl = this;
            // 
            // error_section
            // 
            this.error_section.ContainerControl = this;
            // 
            // error_first_name
            // 
            this.error_first_name.ContainerControl = this;
            // 
            // error_birthday
            // 
            this.error_birthday.ContainerControl = this;
            // 
            // error_mobile_number
            // 
            this.error_mobile_number.ContainerControl = this;
            // 
            // error_email
            // 
            this.error_email.ContainerControl = this;
            // 
            // error_last_name
            // 
            this.error_last_name.ContainerControl = this;
            // 
            // error_address
            // 
            this.error_address.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Student_Details";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_student_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_section)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_first_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_birthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mobile_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_last_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_address)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Label lbl_student_details_title;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.PictureBox img_image;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_student_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_section;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_course;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_middle_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mobile_number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txt_birthday;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_temp;
        private System.Windows.Forms.ErrorProvider error_student_number;
        private System.Windows.Forms.ErrorProvider error_course;
        private System.Windows.Forms.ErrorProvider error_year;
        private System.Windows.Forms.ErrorProvider error_section;
        private System.Windows.Forms.ErrorProvider error_first_name;
        private System.Windows.Forms.ErrorProvider error_birthday;
        private System.Windows.Forms.ErrorProvider error_mobile_number;
        private System.Windows.Forms.ErrorProvider error_email;
        private System.Windows.Forms.ErrorProvider error_last_name;
        private System.Windows.Forms.ErrorProvider error_address;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_student_id;
    }
}