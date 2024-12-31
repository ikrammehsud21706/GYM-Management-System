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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserNameContactEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHideShow = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llblChangePassword = new System.Windows.Forms.LinkLabel();
            this.llblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserNameContactEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnHideShow);
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.llblChangePassword);
            this.panel1.Controls.Add(this.llblForgetPassword);
            this.panel1.Location = new System.Drawing.Point(216, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 625);
            this.panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(36, 285);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(354, 40);
            this.txtPassword.TabIndex = 35;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtUserNameContactEmail
            // 
            this.txtUserNameContactEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserNameContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameContactEmail.ForeColor = System.Drawing.Color.Black;
            this.txtUserNameContactEmail.Location = new System.Drawing.Point(36, 223);
            this.txtUserNameContactEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserNameContactEmail.Multiline = true;
            this.txtUserNameContactEmail.Name = "txtUserNameContactEmail";
            this.txtUserNameContactEmail.Size = new System.Drawing.Size(354, 40);
            this.txtUserNameContactEmail.TabIndex = 34;
            this.txtUserNameContactEmail.Text = "Enter UserName/Contact/Email";
            this.txtUserNameContactEmail.Click += new System.EventHandler(this.txtUserNameContactEmail_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 34);
            this.label1.TabIndex = 44;
            this.label1.Text = "_________________________________________________________________________________" +
    "_____________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GymManagementSystem.Properties.Resources.avatar1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(108, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 122);
            this.panel2.TabIndex = 43;
            // 
            // btnHideShow
            // 
            this.btnHideShow.BackColor = System.Drawing.Color.Transparent;
            this.btnHideShow.BackgroundImage = global::GymManagementSystem.Properties.Resources.icons8_cbs_512px2;
            this.btnHideShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideShow.ForeColor = System.Drawing.Color.Black;
            this.btnHideShow.Location = new System.Drawing.Point(417, 277);
            this.btnHideShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(42, 42);
            this.btnHideShow.TabIndex = 42;
            this.btnHideShow.UseVisualStyleBackColor = false;
            this.btnHideShow.MouseEnter += new System.EventHandler(this.btnHideShow_MouseEnter);
            this.btnHideShow.MouseLeave += new System.EventHandler(this.btnHideShow_MouseLeave);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(144, 519);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(148, 25);
            this.lbluser.TabIndex = 41;
            this.lbluser.TabStop = true;
            this.lbluser.Text = "Create Account";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbluser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBacktomain_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Lavender;
            this.btnLogin.Location = new System.Drawing.Point(108, 363);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(236, 55);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llblChangePassword
            // 
            this.llblChangePassword.AutoSize = true;
            this.llblChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.llblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblChangePassword.ForeColor = System.Drawing.Color.Black;
            this.llblChangePassword.Location = new System.Drawing.Point(134, 478);
            this.llblChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblChangePassword.Name = "llblChangePassword";
            this.llblChangePassword.Size = new System.Drawing.Size(173, 25);
            this.llblChangePassword.TabIndex = 37;
            this.llblChangePassword.TabStop = true;
            this.llblChangePassword.Text = "Change Password";
            this.llblChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblChangePassword_LinkClicked);
            // 
            // llblForgetPassword
            // 
            this.llblForgetPassword.AutoSize = true;
            this.llblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.llblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgetPassword.ForeColor = System.Drawing.Color.Black;
            this.llblForgetPassword.Location = new System.Drawing.Point(134, 442);
            this.llblForgetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblForgetPassword.Name = "llblForgetPassword";
            this.llblForgetPassword.Size = new System.Drawing.Size(170, 25);
            this.llblForgetPassword.TabIndex = 36;
            this.llblForgetPassword.TabStop = true;
            this.llblForgetPassword.Text = "Forget Password?";
            this.llblForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblForgetPassword_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 732);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHideShow;
        private System.Windows.Forms.LinkLabel lbluser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserNameContactEmail;
        private System.Windows.Forms.LinkLabel llblChangePassword;
        private System.Windows.Forms.LinkLabel llblForgetPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}