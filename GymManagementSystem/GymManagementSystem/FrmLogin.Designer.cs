namespace GymManagementSystem
{
    partial class FrmLogin
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
            this.lblUserName_Email = new System.Windows.Forms.Label();
            this.llblChangePassword = new System.Windows.Forms.LinkLabel();
            this.llblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserNameEmailContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHideShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName_Email
            // 
            this.lblUserName_Email.AutoSize = true;
            this.lblUserName_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName_Email.ForeColor = System.Drawing.Color.Red;
            this.lblUserName_Email.Location = new System.Drawing.Point(250, 116);
            this.lblUserName_Email.Name = "lblUserName_Email";
            this.lblUserName_Email.Size = new System.Drawing.Size(0, 16);
            this.lblUserName_Email.TabIndex = 6;
            // 
            // llblChangePassword
            // 
            this.llblChangePassword.AutoSize = true;
            this.llblChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.llblChangePassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.llblChangePassword.Location = new System.Drawing.Point(12, 433);
            this.llblChangePassword.Name = "llblChangePassword";
            this.llblChangePassword.Size = new System.Drawing.Size(93, 13);
            this.llblChangePassword.TabIndex = 19;
            this.llblChangePassword.TabStop = true;
            this.llblChangePassword.Text = "Change Password";
            // 
            // llblForgetPassword
            // 
            this.llblForgetPassword.AutoSize = true;
            this.llblForgetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.llblForgetPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.llblForgetPassword.Location = new System.Drawing.Point(245, 433);
            this.llblForgetPassword.Name = "llblForgetPassword";
            this.llblForgetPassword.Size = new System.Drawing.Size(92, 13);
            this.llblForgetPassword.TabIndex = 18;
            this.llblForgetPassword.TabStop = true;
            this.llblForgetPassword.Text = "Forget Password?";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(378, 248);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 16);
            this.lblPassword.TabIndex = 17;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogin.Location = new System.Drawing.Point(193, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 33);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(47, 221);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(296, 32);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUserNameEmailContact
            // 
            this.txtUserNameEmailContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.txtUserNameEmailContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameEmailContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameEmailContact.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserNameEmailContact.Location = new System.Drawing.Point(45, 132);
            this.txtUserNameEmailContact.Multiline = true;
            this.txtUserNameEmailContact.Name = "txtUserNameEmailContact";
            this.txtUserNameEmailContact.Size = new System.Drawing.Size(296, 33);
            this.txtUserNameEmailContact.TabIndex = 6;
            this.txtUserNameEmailContact.Text = "Enter UserName/Email/Contact";
            this.txtUserNameEmailContact.Click += new System.EventHandler(this.txtUserNameEmailContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(232, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Image = global::GymManagementSystem.Properties.Resources.icons8_close_window_80px;
            this.btnClose.Location = new System.Drawing.Point(562, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 26);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(43, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 21);
            this.label2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(343, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(343, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 31);
            this.label4.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.label5.Location = new System.Drawing.Point(47, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 10);
            this.label5.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.label6.Location = new System.Drawing.Point(75, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 62);
            this.label6.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GymManagementSystem.Properties.Resources.Login_form2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblHideShow
            // 
            this.lblHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideShow.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHideShow.Location = new System.Drawing.Point(362, 230);
            this.lblHideShow.Name = "lblHideShow";
            this.lblHideShow.Size = new System.Drawing.Size(53, 18);
            this.lblHideShow.TabIndex = 26;
            this.lblHideShow.Text = "Show";
            this.lblHideShow.Click += new System.EventHandler(this.lblHideShow_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(610, 476);
            this.Controls.Add(this.lblHideShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llblChangePassword);
            this.Controls.Add(this.llblForgetPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserNameEmailContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUserName_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login form";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName_Email;
        private System.Windows.Forms.LinkLabel llblChangePassword;
        private System.Windows.Forms.LinkLabel llblForgetPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserNameEmailContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHideShow;
    }
}