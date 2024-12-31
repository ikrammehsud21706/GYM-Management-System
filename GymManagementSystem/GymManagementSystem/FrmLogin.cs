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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void txtUserNameEmailContact_Click(object sender, EventArgs e)
        {
            if (txtUserNameEmailContact.Text=="Enter UserName/Email/Contact")
            {
            txtUserNameEmailContact.Text = "";
            }
            txtUserNameEmailContact.ForeColor = Color.Black;
            txtUserNameEmailContact.BackColor = Color.White;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
          
            txtPassword.ForeColor = Color.Black;
            txtPassword.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
            }
            txtPassword.PasswordChar= '*';
            txtPassword.ForeColor = Color.Black;
            txtPassword.BackColor = Color.White;
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNameEmailContact.Text == "UserName/Email/Contact" || txtUserNameEmailContact.Text == "")
            {
                MessageBox.Show("Enter Username,Email or Contact");
            }
            else if (txtPassword.PasswordChar == '*' || txtPassword.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=DESKTOP-C7PDPF8\\SQLEXPRESS;database=DbGymManagementSystem;integrated security=true");
                string query = "select * from tbluser where UserName='" + txtUserNameEmailContact.Text + "' or Email='" + txtUserNameEmailContact.Text + "' or Contact='" + txtUserNameEmailContact.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    query = "select * from tbluser where (UserName='" + txtUserNameEmailContact.Text + "' or Email='" + txtUserNameEmailContact.Text + "' or Contact='" + txtUserNameEmailContact.Text + "') and Password='" + txtPassword.Text + "'";
                    adapter = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        FrmMain obj = new FrmMain();
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct Password");
                    }
                    // MessageBox.Show("Login Successfully");
                }
                else
                {
                    MessageBox.Show("Enter Correct UserName or Email or Contact");
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void lblHideShow_Click(object sender, EventArgs e)
        {
            if (lblHideShow.Text == "Show")
            {
                txtPassword.PasswordChar = '\0';
                lblHideShow.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                lblHideShow.Text = "Show";
            }

        }
    }
}
