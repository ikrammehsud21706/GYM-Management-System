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
            txtEmail.Text = FrmUserList. email;
            txtContact.Text = FrmUserList. contact;
            txtCnic.Text = FrmUserList.cnic;
            ddlRole.Text = FrmUserList.role;
            txtPassword.Text = FrmUserList.password;
            txtAddress.Text = FrmUserList. address;
            if (FrmUserList.status == "0")
            {
                ddlStatus.Text = "Inactive";
            }
            else if (FrmUserList.status == "1")
            {
                ddlStatus.Text = "Active";
            }
            else if(FrmUserList.status=="2") 
            {
                ddlStatus.Text = "OnLeave";
            }
          
        }
        private void FrmUserRegistration_Load(object sender, EventArgs e)
        {

        }
        
        //public void assignvalues(string username, string firstname, string lastname, string email, string contact, string cnic, string role, string password, string address, string status)
        //{
        //    txtUserName.Text = username;
        //    txtFirstName.Text = firstname;
        //    txtLastName.Text = lastname;
        //    txtEmail.Text = email;
        //    txtContact.Text = contact;
        //    txtCnic.Text = cnic;
        //    ddlRole.Text =role;
        //    txtPassword.Text = password;
        //    txtAddress.Text = address;
        //    if (status=="0")
        //    {
        //        ddlStatus.Text = "Inactive";
        //    }
        //    else if (status=="1")
        //    {
        //        ddlStatus.Text = "Active";
        //    }
        //    else
        //    {
        //        ddlStatus.Text = "OnLeave";
        //    }
        //}
         
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



            //if (e.KeyChar==8)
            //{
            //    e.Handled = false;

            //}
            //else if (e.KeyChar>=48&&e.KeyChar<=57)
            //{
            //    e.Handled = false;
            //}

            //else if ((e.KeyChar>57&&e.KeyChar<=96)&(e.KeyChar==95))
            //{
            //    e.Handled = false;
            //}
            //else if (e.KeyChar>=97&&e.KeyChar<123)
            //{
            //    e.Handled = false;
            //}
            //else 
            //{
            //    e.Handled = true;
            //}
        }
        //int obj
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
            //char[] value = new char[char.MaxValue];
            //value = txtUserName.Text.ToCharArray();
            //if (txtUserName.Text=="")
            //{
            //    lblUserName.Text = "";
            //}
            //else if (value[0] >= '0' && value[0] <= '9')
            //{
            //    lblUserName.Text = "Incorrect Username!";
            //}
        }
        SqlConnection con = new SqlConnection("server=DESKTOP-C7PDPF8\\SQLEXPRESS;database=DbGymManagementSystem;integrated security=true");
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
            else if (txtContact.TextLength<11)
            {
                lblContact.Text ="Incorrect/invalid";
            }
            else if (txtCnic.TextLength<13)
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
                        string Query1 = "select *from tblUser where UserName='"+txtUserName.Text+"' and UserId<> " + FrmUserList.id;
                        SqlDataAdapter da = new SqlDataAdapter(Query1, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        string Query2 = "select *from tblUser where Email='" + txtEmail.Text + "' and UserId<> " + FrmUserList.id;
                        SqlDataAdapter daa = new SqlDataAdapter(Query2, con);
                        DataTable dtt = new DataTable();
                        daa.Fill(dtt);
                        string Query3 = "select *from tblUser where Contact='" + txtContact.Text + "' and UserId<> " + FrmUserList.id;
                        SqlDataAdapter daaa = new SqlDataAdapter(Query3, con);
                        DataTable dttt = new DataTable();
                        daaa.Fill(dttt);
                        string Query4 = "select *from tblUser where Cnic='" + txtCnic.Text + "' and UserId<> " + FrmUserList.id;
                        SqlDataAdapter daaaa = new SqlDataAdapter(Query4, con);
                        DataTable dtttt = new DataTable();
                        daaaa.Fill(dtttt);
                        if (dt.Rows.Count>0)
                        {
                            MessageBox.Show("This Username is already Exist");
                        }
                        else if (dtt.Rows.Count>0)
                        {
                            MessageBox.Show("This Email is already Exist");
                        }
                        else if (dttt.Rows.Count>0)
                        {
                            MessageBox.Show("This Contact is already Exist");
                        }
                        else if (dtttt.Rows.Count>0)
                        {
                            MessageBox.Show("This Cnic number is already Exist");
                        }
                        else
                        {
                            string Query = "update tbluser set UserName='" + txtUserName.Text + "', FirsName='" + txtFirstName.Text + "', LastName='" + txtLastName.Text + "', Email='" + txtEmail.Text + "', Contact='" + txtContact.Text + "', Cnic='" + txtCnic.Text + "', Role='" + ddlRole.Text + "', Password='" + txtPassword.Text + "', Address='" + txtAddress.Text + "', Status='" + status + "' where UserId="+ FrmUserList.id;
                            SqlCommand cmd = new SqlCommand(Query, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated Successfully");
                            con.Close();
                        }

                    }
                    else
                    {
                        string Query1 = "select *from tblUser where UserName='" + txtUserName.Text + "'";
                        SqlDataAdapter da = new SqlDataAdapter(Query1, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        string Query2 = "select *from tblUser where Email='" + txtEmail.Text + "'";
                        SqlDataAdapter daa = new SqlDataAdapter(Query2, con);
                        DataTable dtt = new DataTable();
                        daa.Fill(dtt);
                        string Query3 = "select *from tblUser where Contact='" + txtContact.Text + "'";
                        SqlDataAdapter daaa = new SqlDataAdapter(Query3, con);
                        DataTable dttt = new DataTable();
                        daaa.Fill(dttt);
                        string Query4 = "select *from tblUser where Cnic='" + txtCnic.Text + "'";
                        SqlDataAdapter daaaa = new SqlDataAdapter(Query4, con);
                        DataTable dtttt = new DataTable();
                        daaaa.Fill(dtttt);

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
                        else
                        {
                            string Query = "INSERT INTO TBLUSER VAlUES('" + txtUserName.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "','" + txtCnic.Text + "','" + ddlRole.Text + "','" + txtPassword.Text + "','" + txtAddress.Text + "','" + status + "','')";
                            SqlCommand cmd = new SqlCommand(Query, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("INSERTED");
                            con.Close();
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
            if (txtContact.Text != ""||lblContact.Text=="Incorrect/invalid")
            {
                lblContact.Text = "";
            }
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            if (txtCnic.Text != ""||lblCnic.Text=="Incorrect/invalid")
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

        //private void label10_MouseEnter(object sender, EventArgs e)
        //{

        //}

        private void lblHideIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblHideIcon_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void lblHideIcon_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            FrmUserList obj = new FrmUserList();
            this.Hide();
            obj.ShowDialog();
        }
    }
}

    