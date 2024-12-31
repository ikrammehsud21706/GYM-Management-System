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
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            if (txtOTP.Text == "")
            {
                MessageBox.Show("Enter OTP that has been sent to your Email");
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Create new password");
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please confirm your password");
            }
            else
            {
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Please re-confirm your password");
                }
                else
                {
                    if (BLUser.ForgetPassword(FrmGenerateOtp.Email, txtOTP.Text).Rows.Count > 0)
                    {
                        BLUser.UpdatePassword(txtNewPassword.Text, FrmGenerateOtp.Email);
                        MessageBox.Show("Password changed");
                    }
                }
            }
        }

        private void txtOTP_Click(object sender, EventArgs e)
        {
            txtOTP.Text = "";
             
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            txtNewPassword.Text = "";
            txtNewPassword.BackColor = Color.White;
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
            txtConfirmPassword.BackColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOTP_Click_1(object sender, EventArgs e)
        {
            txtOTP.Text = "";
        }

        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.Text = "";
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
        }
    }
}
