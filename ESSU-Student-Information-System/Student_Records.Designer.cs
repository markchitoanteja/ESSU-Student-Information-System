﻿namespace ESSU_Student_Information_System
{
    partial class Student_Records
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Records));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_new_student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_update_student = new System.Windows.Forms.Button();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lvl_student_list = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course_year_section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_temp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_temp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_new_student);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(738, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 50);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(169, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 50);
            this.panel3.TabIndex = 12;
            // 
            // btn_new_student
            // 
            this.btn_new_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btn_new_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_student.FlatAppearance.BorderSize = 0;
            this.btn_new_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_student.ForeColor = System.Drawing.Color.White;
            this.btn_new_student.Location = new System.Drawing.Point(18, 8);
            this.btn_new_student.Name = "btn_new_student";
            this.btn_new_student.Size = new System.Drawing.Size(150, 35);
            this.btn_new_student.TabIndex = 3;
            this.btn_new_student.Text = "&New Student";
            this.btn_new_student.UseVisualStyleBackColor = false;
            this.btn_new_student.Click += new System.EventHandler(this.btn_new_student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Records";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 398);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(907, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 398);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(20, 428);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(887, 20);
            this.panel5.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.AutoScroll = true;
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btn_update_student);
            this.panel10.Controls.Add(this.btn_delete_student);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.lvl_student_list);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(20, 50);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(887, 378);
            this.panel10.TabIndex = 13;
            // 
            // btn_update_student
            // 
            this.btn_update_student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btn_update_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_student.FlatAppearance.BorderSize = 0;
            this.btn_update_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_student.ForeColor = System.Drawing.Color.White;
            this.btn_update_student.Location = new System.Drawing.Point(574, 336);
            this.btn_update_student.Name = "btn_update_student";
            this.btn_update_student.Size = new System.Drawing.Size(150, 35);
            this.btn_update_student.TabIndex = 5;
            this.btn_update_student.Text = "&Update Student";
            this.btn_update_student.UseVisualStyleBackColor = false;
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_delete_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_student.FlatAppearance.BorderSize = 0;
            this.btn_delete_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_student.ForeColor = System.Drawing.Color.White;
            this.btn_delete_student.Location = new System.Drawing.Point(730, 336);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(150, 35);
            this.btn_delete_student.TabIndex = 4;
            this.btn_delete_student.Text = "&Delete Student";
            this.btn_delete_student.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(885, 40);
            this.panel11.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "    Students List";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvl_student_list
            // 
            this.lvl_student_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvl_student_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.student_name,
            this.course_year_section,
            this.birthday,
            this.email,
            this.status});
            this.lvl_student_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_student_list.FullRowSelect = true;
            this.lvl_student_list.GridLines = true;
            this.lvl_student_list.HideSelection = false;
            this.lvl_student_list.Location = new System.Drawing.Point(5, 46);
            this.lvl_student_list.Name = "lvl_student_list";
            this.lvl_student_list.Size = new System.Drawing.Size(875, 284);
            this.lvl_student_list.TabIndex = 2;
            this.lvl_student_list.UseCompatibleStateImageBehavior = false;
            this.lvl_student_list.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // student_name
            // 
            this.student_name.Text = "Student Name";
            this.student_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.student_name.Width = 264;
            // 
            // course_year_section
            // 
            this.course_year_section.Text = "Course, Year and Section";
            this.course_year_section.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course_year_section.Width = 200;
            // 
            // birthday
            // 
            this.birthday.Text = "Birthday";
            this.birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthday.Width = 160;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 160;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_temp
            // 
            this.btn_temp.Location = new System.Drawing.Point(-86, 33);
            this.btn_temp.Name = "btn_temp";
            this.btn_temp.Size = new System.Drawing.Size(75, 23);
            this.btn_temp.TabIndex = 5;
            this.btn_temp.Text = "button1";
            this.btn_temp.UseVisualStyleBackColor = true;
            // 
            // Student_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "Student_Records";
            this.Size = new System.Drawing.Size(927, 448);
            this.SizeChanged += new System.EventHandler(this.Student_Records_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_new_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListView lvl_student_list;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader student_name;
        private System.Windows.Forms.ColumnHeader course_year_section;
        private System.Windows.Forms.ColumnHeader birthday;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_update_student;
        private System.Windows.Forms.Button btn_delete_student;
        private System.Windows.Forms.Button btn_temp;
    }
}