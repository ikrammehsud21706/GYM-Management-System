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
    public partial class FrmUserRegistration : Form
    {
        public FrmUserRegistration()
        {
            InitializeComponent();
        }

        private void FrmUserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<'A'||e.KeyChar>'z')&& e.KeyChar!=32 && e.KeyChar!=8)
            {
                e.Handled = true;
            }
            if (txtFirstName.TextLength>29& e.KeyChar!=8)
            {
                e.Handled = true;

            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if  ((e.KeyChar<'A'||e.KeyChar>'z')&e.KeyChar!=32&e.KeyChar!=8)
            {
                e.Handled = true;
            }
            if (txtLastName.TextLength>29&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<'0'||e.KeyChar>'9')&e.KeyChar!=8)
            {
                e.Handled = true;
            }
            if (txtContact.TextLength>10&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<'0'||e.KeyChar>'9')& e.KeyChar!=8)
            {
                e.Handled = true;
            }
            if (txtCnic.TextLength>12&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<'0'||e.KeyChar>'9')&(e.KeyChar<'a'||e.KeyChar>'z')&(e.KeyChar!='_')&(e.KeyChar!=8))
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="")
            {
                lblUserName.Text = "REQUIRED";
            }
            else if (lblUserName.Text== "Invalid User Name")
            {
                lblUserName.Text = "Enter Correct Username";
            }
            else if (txtFirstName.Text=="")
            {
                lblFirstName.Text = "REQUIRED";
            }
            else if (txtLastName.Text=="")
            {
                lblLastName.Text = "REQUIRED";
            }
            else if (txtEmail.Text=="")
            {
                lblEmail.Text = "REQUIRED";
            }
            else if (txtContact.Text=="")
            {
                lblContact.Text = "REQUIRED";
            }
            else if (txtCnic.Text=="")
            {
                lblCnic.Text = "REQUIRED";
            }
            else if (ddlRole.Text=="")
            {
                lblRole.Text = "REQUIRED";
            }
            else if (txtAddress.Text=="")
            {
                lblAddress.Text = "REQUIRED";
            }
            else if (txtPassword.Text=="")
            {
                lblPassword.Text = "REQUIRED";
            }
            else if (ddlStatus.Text=="")
            {
                lblStatus.Text = "REQUIRED";
            }
            else
            {
                if (txtEmail.Text.Contains("@gmail.com")==false)
                {
                    //use example@gmail.com
                    lblEmail.Text = "use example khaksar55@gmail.com";
                }
                else
                {
                    SqlConnection con = new SqlConnection("server=DESKTOP-C7PDPF8\\SQLEXPRESS;database=DbGymManagementSystem;integrated security=true");
                    string Query = "INSERT INTO TBLUSER VAlUES('" + txtUserName.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtCnic.Text + "','" + txtContact.Text + "','" + ddlRole.Text + "','" + txtPassword.Text + "','" + txtAddress.Text + "','" + ddlStatus.Text + "')";
                    SqlCommand cmd=new SqlCommand(Query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("INSERTED");
                    con.Close();
                    
                }
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (lblUserName.Text=="REQUIRED")
            {
                lblUserName.Text = "";
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text!="")
            {
                lblFirstName.Text = "";
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text!="")
            {
                lblLastName.Text = "";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (lblEmail.Text == "REQUIRED" || lblEmail.Text == "use example khaksar55@gmail.com")
            {
                lblEmail.Text = "";
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text!="")
            {
                lblContact.Text = "";
            }
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            if (txtCnic.Text!="")
            {
                lblCnic.Text = "";
            }
        }

        private void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlRole.Text!="")
            {
                lblRole.Text = "";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text!="")
            {
                lblAddress.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text!="")
            {
                lblPassword.Text = "";
            }
        }

        private void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStatus.Text!="")
            {
                lblStatus.Text = "";
            }
        }
    }
}
