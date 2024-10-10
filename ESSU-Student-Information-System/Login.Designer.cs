namespace ESSU_Student_Information_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.chk_remember_me = new System.Windows.Forms.CheckBox();
            this.img_show_hide_password = new System.Windows.Forms.PictureBox();
            this.err_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.delayer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_show_hide_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_password)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.err_username.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.err_password.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error1"));
            this.err_username.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.err_password.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment1"))));
            this.err_username.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.err_password.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding1"))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.err_username.SetError(this.label1, resources.GetString("label1.Error"));
            this.err_password.SetError(this.label1, resources.GetString("label1.Error1"));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.err_username.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.err_password.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.err_username.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.err_password.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.err_password.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.err_username.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.err_username.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.err_password.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.err_password.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.err_username.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.err_username.SetError(this.label2, resources.GetString("label2.Error"));
            this.err_password.SetError(this.label2, resources.GetString("label2.Error1"));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.err_username.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.err_password.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.err_username.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.err_password.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.err_username.SetError(this.label3, resources.GetString("label3.Error"));
            this.err_password.SetError(this.label3, resources.GetString("label3.Error1"));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.err_username.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.err_password.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.err_username.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.err_password.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.label3.Name = "label3";
            // 
            // txt_username
            // 
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.err_username.SetError(this.txt_username, resources.GetString("txt_username.Error"));
            this.err_password.SetError(this.txt_username, resources.GetString("txt_username.Error1"));
            this.err_password.SetIconAlignment(this.txt_username, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_username.IconAlignment"))));
            this.err_username.SetIconAlignment(this.txt_username, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_username.IconAlignment1"))));
            this.err_password.SetIconPadding(this.txt_username, ((int)(resources.GetObject("txt_username.IconPadding"))));
            this.err_username.SetIconPadding(this.txt_username, ((int)(resources.GetObject("txt_username.IconPadding1"))));
            this.txt_username.Name = "txt_username";
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.err_username.SetError(this.txt_password, resources.GetString("txt_password.Error"));
            this.err_password.SetError(this.txt_password, resources.GetString("txt_password.Error1"));
            this.err_password.SetIconAlignment(this.txt_password, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_password.IconAlignment"))));
            this.err_username.SetIconAlignment(this.txt_password, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_password.IconAlignment1"))));
            this.err_password.SetIconPadding(this.txt_password, ((int)(resources.GetObject("txt_password.IconPadding"))));
            this.err_username.SetIconPadding(this.txt_password, ((int)(resources.GetObject("txt_password.IconPadding1"))));
            this.txt_password.Name = "txt_password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.err_username.SetError(this.label4, resources.GetString("label4.Error"));
            this.err_password.SetError(this.label4, resources.GetString("label4.Error1"));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.err_username.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.err_password.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.err_username.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.err_password.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.label4.Name = "label4";
            // 
            // btn_login
            // 
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err_username.SetError(this.btn_login, resources.GetString("btn_login.Error"));
            this.err_password.SetError(this.btn_login, resources.GetString("btn_login.Error1"));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.err_username.SetIconAlignment(this.btn_login, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btn_login.IconAlignment"))));
            this.err_password.SetIconAlignment(this.btn_login, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btn_login.IconAlignment1"))));
            this.err_username.SetIconPadding(this.btn_login, ((int)(resources.GetObject("btn_login.IconPadding"))));
            this.err_password.SetIconPadding(this.btn_login, ((int)(resources.GetObject("btn_login.IconPadding1"))));
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chk_remember_me
            // 
            resources.ApplyResources(this.chk_remember_me, "chk_remember_me");
            this.chk_remember_me.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err_username.SetError(this.chk_remember_me, resources.GetString("chk_remember_me.Error"));
            this.err_password.SetError(this.chk_remember_me, resources.GetString("chk_remember_me.Error1"));
            this.chk_remember_me.ForeColor = System.Drawing.Color.White;
            this.err_username.SetIconAlignment(this.chk_remember_me, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chk_remember_me.IconAlignment"))));
            this.err_password.SetIconAlignment(this.chk_remember_me, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chk_remember_me.IconAlignment1"))));
            this.err_username.SetIconPadding(this.chk_remember_me, ((int)(resources.GetObject("chk_remember_me.IconPadding"))));
            this.err_password.SetIconPadding(this.chk_remember_me, ((int)(resources.GetObject("chk_remember_me.IconPadding1"))));
            this.chk_remember_me.Name = "chk_remember_me";
            this.chk_remember_me.UseVisualStyleBackColor = true;
            // 
            // img_show_hide_password
            // 
            resources.ApplyResources(this.img_show_hide_password, "img_show_hide_password");
            this.img_show_hide_password.BackColor = System.Drawing.Color.White;
            this.img_show_hide_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err_username.SetError(this.img_show_hide_password, resources.GetString("img_show_hide_password.Error"));
            this.err_password.SetError(this.img_show_hide_password, resources.GetString("img_show_hide_password.Error1"));
            this.err_username.SetIconAlignment(this.img_show_hide_password, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("img_show_hide_password.IconAlignment"))));
            this.err_password.SetIconAlignment(this.img_show_hide_password, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("img_show_hide_password.IconAlignment1"))));
            this.err_username.SetIconPadding(this.img_show_hide_password, ((int)(resources.GetObject("img_show_hide_password.IconPadding"))));
            this.err_password.SetIconPadding(this.img_show_hide_password, ((int)(resources.GetObject("img_show_hide_password.IconPadding1"))));
            this.img_show_hide_password.Name = "img_show_hide_password";
            this.img_show_hide_password.TabStop = false;
            this.img_show_hide_password.Click += new System.EventHandler(this.img_show_hide_password_Click);
            // 
            // err_username
            // 
            this.err_username.ContainerControl = this;
            resources.ApplyResources(this.err_username, "err_username");
            // 
            // err_password
            // 
            this.err_password.ContainerControl = this;
            resources.ApplyResources(this.err_password, "err_password");
            // 
            // txt_temp
            // 
            resources.ApplyResources(this.txt_temp, "txt_temp");
            this.err_username.SetError(this.txt_temp, resources.GetString("txt_temp.Error"));
            this.err_password.SetError(this.txt_temp, resources.GetString("txt_temp.Error1"));
            this.err_password.SetIconAlignment(this.txt_temp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_temp.IconAlignment"))));
            this.err_username.SetIconAlignment(this.txt_temp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_temp.IconAlignment1"))));
            this.err_password.SetIconPadding(this.txt_temp, ((int)(resources.GetObject("txt_temp.IconPadding"))));
            this.err_username.SetIconPadding(this.txt_temp, ((int)(resources.GetObject("txt_temp.IconPadding1"))));
            this.txt_temp.Name = "txt_temp";
            // 
            // delayer
            // 
            this.delayer.Interval = 1000;
            this.delayer.Tick += new System.EventHandler(this.delayer_Tick);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.err_username.SetError(this.label5, resources.GetString("label5.Error"));
            this.err_password.SetError(this.label5, resources.GetString("label5.Error1"));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.err_username.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.err_password.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.err_username.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.err_password.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.label5.Name = "label5";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.err_username.SetError(this.linkLabel1, resources.GetString("linkLabel1.Error"));
            this.err_password.SetError(this.linkLabel1, resources.GetString("linkLabel1.Error1"));
            this.err_password.SetIconAlignment(this.linkLabel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("linkLabel1.IconAlignment"))));
            this.err_username.SetIconAlignment(this.linkLabel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("linkLabel1.IconAlignment1"))));
            this.err_username.SetIconPadding(this.linkLabel1, ((int)(resources.GetObject("linkLabel1.IconPadding"))));
            this.err_password.SetIconPadding(this.linkLabel1, ((int)(resources.GetObject("linkLabel1.IconPadding1"))));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.img_show_hide_password);
            this.Controls.Add(this.chk_remember_me);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_show_hide_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chk_remember_me;
        private System.Windows.Forms.PictureBox img_show_hide_password;
        private System.Windows.Forms.ErrorProvider err_username;
        private System.Windows.Forms.ErrorProvider err_password;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.Timer delayer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_password;
    }
}

