using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Eventing.Reader;
using GymManagementSystem.BL;
using GymManagementSystem;

namespace GymManagementSystem
{
    public partial class FrmUserRegistration : Form
    {
        public FrmUserRegistration()
        {
            InitializeComponent();
            txtUserName.Text = FrmUserList.username;
            txtFirstName.Text = FrmUserList.firstname;
            txtLastName.Text = FrmUserList.lastname;
            txtEmail.Text = FrmUserList.email;
            txtContact.Text = FrmUserList.contact;
            txtCnic.Text = FrmUserList.cnic;
            ddlRole.Text = FrmUserList.role;
            txtPassword.Text = FrmUserList.password;
            txtAddress.Text = FrmUserList.address;
            if (FrmUserList.status == "0")
            {
                ddlStatus.Text = "Active";
            }
            else if (FrmUserList.status == "1")
            {
                ddlStatus.Text = "InActive";
            }
            else
            {
                ddlStatus.Text = "OnLeave";
            }

            FrmUserList.username = "";
            FrmUserList.firstname = "";
            FrmUserList.lastname = "";
            FrmUserList.email = "";
            FrmUserList.contact = "";
            FrmUserList.cnic = "";
            FrmUserList.role = "";
            FrmUserList.password = "";
            FrmUserList.address = "";
            FrmUserList.status = "";
        }
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != 32 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtFirstName.TextLength > 29 & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') & e.KeyChar != 32 & e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtLastName.TextLength > 29 & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtContact.TextLength > 10 & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtCnic.TextLength > 12 & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar < 'a' || e.KeyChar > 'z') & (e.KeyChar != '_') & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char ch = txtUserName.Text[0];
                if ((ch < 'a' || ch > 'z') & (ch != '_'))
                {
                    lblUserName.Text = "Invalid User Name";
                }
            }
            catch
            {
                lblUserName.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                lblUserName.Text = "REQUIRED";
            }
            else if (lblUserName.Text == "Invalid User Name")
            {
                lblUserName.Text = "Enter Correct Username";
            }
            else if (txtFirstName.Text == "")
            {
                lblFirstName.Text = "REQUIRED";
            }
            else if (txtLastName.Text == "")
            {
                lblLastName.Text = "REQUIRED";
            }
            else if (txtEmail.Text == "")
            {
                lblEmail.Text = "REQUIRED";
            }
            else if (txtContact.Text == "")
            {
                lblContact.Text = "REQUIRED";
            }
            else if (txtCnic.Text == "")
            {
                lblCnic.Text = "REQUIRED";
            }
            else if (ddlRole.Text == "")
            {
                lblRole.Text = "REQUIRED";
            }
            else if (txtAddress.Text == "")
            {
                lblAddress.Text = "REQUIRED";
            }
            else if (txtPassword.Text == "")
            {
                lblPassword.Text = "REQUIRED";
            }
            else if (ddlStatus.Text == "")
            {
                lblStatus.Text = "REQUIRED";
            }
            else if (txtContact.TextLength < 11)
            {
                lblContact.Text = "Incorrect/invalid";
            }
            else if (txtCnic.TextLength < 13)
            {
                lblCnic.Text = "Incorrect/invalid";
            }
            else
            {
                string[] index = txtEmail.Text.Split('@');
                if (txtEmail.Text.Contains("@gmail.com") == false)
                {
                    lblEmail.Text = "use example@gmail.com";
                }
                else if (index[0] == "")
                {
                    lblEmail.Text = "Enter example before @";
                }
                else if (index[1].Length > 9)
                {
                    lblEmail.Text = ".com is valid only";
                }
                else
                {
                    int status;
                    if (ddlStatus.Text == "Active")
                    {
                        status = 1;
                    }
                    else if (ddlStatus.Text == "Inactive")
                    {
                        status = 0;
                    }
                    else
                    {
                        status = 2;
                    }
                    if (FrmUserList.id > 0)
                    {
                        DataTable dt = BLUser.CheckUserInUpdate("UserName", txtUserName.Text, FrmUserList.id);
                        DataTable dtt = BLUser.CheckUserInUpdate("Email", txtEmail.Text, FrmUserList.id);
                        DataTable dttt = BLUser.CheckUserInUpdate("Contact", txtContact.Text, FrmUserList.id);
                        DataTable dtttt = BLUser.CheckUserInUpdate("Cnic", txtCnic.Text, FrmUserList.id);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Username is already Exist");
                        }
                        else if (dtt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Email is already Exist");
                        }
                        else if (dttt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Contact is already Exist");
                        }
                        else if (dtttt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Cnic number is already Exist");
                        }
                        else
                        {
                            BLUser obj = new BLUser();
                            obj.UserName = txtUserName.Text;
                            obj.FIrstName = txtFirstName.Text;
                            obj.LastName = txtLastName.Text;
                            obj.Email = txtEmail.Text;
                            obj.Contact = txtContact.Text;
                            obj.Cnic = txtCnic.Text;
                            obj.Role = ddlRole.Text;
                            obj.Password = txtPassword.Text;
                            obj.Address = txtAddress.Text;
                            obj.Status = status;
                            obj.UserID = FrmUserList.id;
                            if (BLUser.Update(obj) == 1)
                            {
                                MessageBox.Show("Updated successfully");
                                BLLog log = new BLLog();
                                log.UserId = FrmLogin.UserId;
                                log.Log = "This User '" + FrmLogin.UserName + "' has updated the record of '" + txtUserName.Text + "' successfully";
                                log.dateTime = DateTime.Now;
                                BLLog.Save(log);
                            }
                            FrmUserList.id = 0;
                            txtUserName.Text = "";
                            txtFirstName.Text = "";
                            txtLastName.Text = "";
                            txtEmail.Text = "";
                            txtCnic.Text = "";
                            txtContact.Text = "";
                            txtAddress.Text = "";
                            ddlRole.Text = "";
                            ddlStatus.Text = "";
                            txtPassword.Text = "";
                        }
                    }
                    else
                    {
                        DataTable dt = BLUser.CheckUser("UserName", txtUserName.Text);
                        DataTable dtt = BLUser.CheckUser("Email", txtEmail.Text);
                        DataTable dttt = BLUser.CheckUser("Contact", txtContact.Text);
                        DataTable dtttt = BLUser.CheckUser("Cnic", txtCnic.Text); new DataTable();
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtUserName.Text + " User is already exit");
                        }
                        else if (dtt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtEmail.Text + " Email is already exit");
                        }
                        else if (dttt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtContact.Text + " Contact is already exit");
                        }
                        else if (dtttt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtCnic.Text + " CNIC is already exit");
                        }

                        else if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (ddlStatus.Text == "Active")
                            {
                                status = 1;
                            }
                            else if (ddlStatus.Text == "OnLeave")
                            {
                                status = 2;
                            }
                            else
                            {
                                status = 0;
                            }
                            BLUser obj = new BLUser();
                            obj.UserName = txtUserName.Text;
                            obj.FIrstName = txtFirstName.Text;
                            obj.LastName = txtLastName.Text;
                            obj.Email = txtEmail.Text;
                            obj.Contact = txtContact.Text;
                            obj.Cnic = txtCnic.Text;
                            obj.Role = ddlRole.Text;
                            obj.Password = txtPassword.Text;
                            obj.Address = txtAddress.Text;
                            obj.Status = status;
                            if (BLUser.Save(obj) == 1)
                            {
                                MessageBox.Show("Inserted successfully");
                                BLLog log = new BLLog();
                                log.UserId = FrmLogin.UserId;
                                log.Log = "This User '" + FrmLogin.UserName + "' has Inserted the record of '" + txtUserName.Text + "' successfully";
                                log.dateTime = DateTime.Now;
                                BLLog.Save(log);
                            }
                            FrmUserList.id = 0;
                            txtUserName.Text = "";
                            txtFirstName.Text = "";
                            txtLastName.Text = "";
                            txtEmail.Text = "";
                            txtCnic.Text = "";
                            txtContact.Text = "";
                            txtAddress.Text = "";
                            ddlRole.Text = "";
                            ddlStatus.Text = "";
                            txtPassword.Text = "";
                            ddlStatus.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Oops! Insert failed");
                        }
                    }
                }
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (lblUserName.Text == "REQUIRED")
            {
                lblUserName.Text = "";
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "")
            {
                lblFirstName.Text = "";
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text != "")
            {
                lblLastName.Text = "";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (lblEmail.Text == "REQUIRED" || lblEmail.Text == "use example@gmail.com" || lblEmail.Text == "Enter example before @" || lblEmail.Text == ".com is valid only")
            {
                lblEmail.Text = "";
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text != "" || lblContact.Text == "Incorrect/invalid")
            {
                lblContact.Text = "";
            }
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            if (txtCnic.Text != "" || lblCnic.Text == "Incorrect/invalid")
            {
                lblCnic.Text = "";
            }
        }

        private void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRole.Text != "")
            {
                lblRole.Text = "";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                lblAddress.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lblPassword.Text = "";
            }
        }

        private void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStatus.Text != "")
            {
                lblStatus.Text = "";
            }
        }


        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((txtEmail.Text.Contains("@gmail.com") == true) & (e.KeyChar == '@' || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            FrmUserList obj = new FrmUserList();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

