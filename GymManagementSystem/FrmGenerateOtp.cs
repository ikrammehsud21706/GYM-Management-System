//using GymManagementSystem.Custom_classes;
using GymManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmGenerateOtp : Form
    {
        public FrmGenerateOtp()
        {
            InitializeComponent();
        }
        public static string Email;
        private void btnSentOTP_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your Email");
            }
            else
            {

                try
                {
                    if (BLUser.ChangePassword(txtEmail.Text).Rows.Count > 0)
                    {
                        Email = txtEmail.Text;
                        string Otp = ClsEmailOtp.GenerateOtp();
                        int check = ClsEmailOtp.EmailSender(txtEmail.Text, "emailsender019@gmail.com", "Forget Password", "dont share your <h1>OTP</h1> Code:" + Otp + " with anyone");
                        if (check == 1)
                        {
                            if (BLUser.GenerateOTP(txtEmail.Text, Otp) > 0)
                            {
                                FrmForgetPassword frmForgetPassword = new FrmForgetPassword();
                                this.Hide();
                                frmForgetPassword.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("OTP failed to be sent");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check Your Internet Connection");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email");
                    }
                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);

                }

            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.BackColor= Color.White;
        }

        
    }
}
