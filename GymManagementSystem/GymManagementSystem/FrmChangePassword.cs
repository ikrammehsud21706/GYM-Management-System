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

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text=="")
            {
                MessageBox.Show("Enter your Email");
            }
            else if (txtPassword.Text=="")
            {
                MessageBox.Show("Enter your password");
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Create new password");
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please confirm your password");
            }
            else if (chkConfirmation.Checked == false)
            {
                MessageBox.Show("Passowrd rememered?");
            }
            else
            {
                if(txtNewPassword.Text!=txtConfirmPassword.Text) 
                {
                    MessageBox.Show("Re-confirm your password");
                }
                else
                {
                    SqlConnection con = new SqlConnection("server=DESKTOP-C7PDPF8\\SQLEXPRESS;database=DbGymManagementSystem;integrated security=true");
                    string query = "select * from tbluser where Email='" + txtEmail.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt=new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count>0)
                    {
                        query = "select * from tbluser where Email='" + txtEmail.Text + "' and Password='" + txtPassword.Text + "'";
                        adapter= new SqlDataAdapter(query, con);
                        dt=new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count>0)
                        {
                            query = "update tbluser set Password='" + txtNewPassword.Text + "' where Email='"+txtEmail.Text+"'";
                            SqlCommand cmd=new SqlCommand(query, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password changed successfully");
                            con.Close();
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
    }
}
