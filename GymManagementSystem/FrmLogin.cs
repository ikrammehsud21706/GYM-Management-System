using GymManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static string Role;

        public static string UserName;
        public static int UserId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNameContactEmail.Text == "Enter UserName/Email/Contact" || txtUserNameContactEmail.Text == "")
            {
                MessageBox.Show("Enter Username,Email or Contact");
            }
            else if (txtPassword.Text.Contains('*') == true || txtPassword.Text == "Enter Password" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                if (BLUser.Login(txtUserNameContactEmail.Text).Rows.Count > 0)
                {
                    if (BLUser.Login(txtUserNameContactEmail.Text, txtPassword.Text).Rows.Count > 0)
                    {
                        Role = "" + BLUser.Login(txtUserNameContactEmail.Text, txtPassword.Text).Rows[0]["Role"];
                        UserName = "" + BLUser.Login(txtUserNameContactEmail.Text, txtPassword.Text).Rows[0]["UserName"];
                        UserId = Convert.ToInt32(BLUser.Login(txtUserNameContactEmail.Text, txtPassword.Text).Rows[0]["UserId"]);
                        BLLog log = new BLLog();
                        log.UserId = UserId;
                        log.Log = "This User:" + UserName + " Login SuccessFully";
                        log.dateTime = DateTime.Now;
                        BLLog.Save(log);
                        FrmMain obj = new FrmMain();
                        this.Hide();
                        obj.ShowDialog();
                        //FrmExpenseHead obj = new FrmExpenseHead();
                        //this.Hide();
                        //obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct Password");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct UserName or Email or Contact");
                }
            }
        }

        private void btnHideShow_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnHideShow_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtUserNameContactEmail_Click(object sender, EventArgs e)
        {
            txtUserNameContactEmail.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void llblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGenerateOtp obj = new FrmGenerateOtp();
            this.Hide();
            obj.ShowDialog();
        }

        private void llblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChangePassword obj = new FrmChangePassword();
            this.Hide();
            obj.ShowDialog();
        }

        private void lblBacktomain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUserRegistration obj = new FrmUserRegistration();
            this.Hide();
            obj.ShowDialog();
        }

       
    }
}
