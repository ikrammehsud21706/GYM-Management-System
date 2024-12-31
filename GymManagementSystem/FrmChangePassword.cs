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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }


        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == "Email")
            {
                MessageBox.Show("Enter your Email");
            }
            else if (txtPassword.Text == "" || txtPassword.Text == "Password")
            {
                MessageBox.Show("Enter your password");
            }
            else if (txtNewPassword.Text == "" || txtNewPassword.Text == "New Password")
            {
                MessageBox.Show("Create new password");
            }
            else if (txtConfirmPassword.Text == "" || txtConfirmPassword.Text == "Confirm Password")
            {
                MessageBox.Show("Please confirm your password");
            }
            else
            {
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Re-confirm your password");
                }
                else
                {
                    if (BLUser.ChangePassword(txtEmail.Text).Rows.Count > 0)
                    {

                        if (BLUser.ChangePassword(txtEmail.Text, txtPassword.Text).Rows.Count > 0)
                        {
                            BLUser.UpdatePassword(txtNewPassword.Text, txtEmail.Text);
                            MessageBox.Show("Password changed successfully");
                        }
                        else
                        {
                            MessageBox.Show("Please Enter correct password ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter correct Email ");
                    }
                }
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.BackColor = Color.White;
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
    }
}