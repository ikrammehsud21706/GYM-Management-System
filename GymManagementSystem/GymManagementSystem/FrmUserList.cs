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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GymManagementSystem
{
    public partial class FrmUserList : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-C7PDPF8\\SQLEXPRESS;database=DbGymManagementSystem;integrated security=true");

        public FrmUserList()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("select *from TblUser", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUserList.DataSource = dt;
        }
        public static string username, firstname, lastname, email, contact, cnic, role, password, address, status;

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static int id;
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmUserRegistration obj = new FrmUserRegistration();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter(" select* from tbluser where username like '%" + txtUserName.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUserList.DataSource = dt;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbluser where Email like'%" + txtEmail.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUserList.DataSource = dt;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbluser where contact like '%" + txtContact.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUserList.DataSource = dt;
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbluser where cnic like '%" + txtCnic.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUserList.DataSource = dt;
        }
        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    int id = Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["UserId"].Value);
                    DialogResult d = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (d == DialogResult.Yes)
                    {
                        //  string Query = "delete from TblUser where UserId=" + id;
                        SqlCommand cmd = new SqlCommand("delete from TblUser where UserId=" + id, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        SqlDataAdapter da = new SqlDataAdapter("select *from TblUser", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUserList.DataSource = dt;
                    }
                }
                else if (e.ColumnIndex == 0)
                {
                    // int id;
                    // string username,firstname,lastname,email,contact,cnic,role,password,address,status;
                    // id = Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["UserId"].Value);
                    // username =""+ dgvUserList.Rows[e.RowIndex].Cells["UserName"].Value;
                    // firstname = "" + dgvUserList.Rows[e.RowIndex].Cells["FirstName"].Value;
                    // lastname = "" + dgvUserList.Rows[e.RowIndex].Cells["LastName"].Value;
                    // email = "" + dgvUserList.Rows[e.RowIndex].Cells["Email"].Value;
                    // contact = "" + dgvUserList.Rows[e.RowIndex].Cells["Contact"].Value;
                    // cnic = "" + dgvUserList.Rows[e.RowIndex].Cells["Cnic"].Value;
                    // role = "" + dgvUserList.Rows[e.RowIndex].Cells["role"].Value;
                    // password = "" + dgvUserList.Rows[e.RowIndex].Cells["Password"].Value;
                    // address = "" + dgvUserList.Rows[e.RowIndex].Cells["Address"].Value;
                    // status = "" + dgvUserList.Rows[e.RowIndex].Cells["Status"].Value;
                    //FrmUserRegistration obj=new FrmUserRegistration();
                    //obj.assignvalues(username, firstname, lastname, email, contact, cnic, role, password, address, status);
                    //this.Hide();
                    //obj.ShowDialog();


                    FrmUserList.id = Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["UserId"].Value);
                    FrmUserList. username = "" + dgvUserList.Rows[e.RowIndex].Cells["UserName"].Value;
                    FrmUserList.firstname = "" + dgvUserList.Rows[e.RowIndex].Cells["FirstName"].Value;
                    FrmUserList.lastname = "" + dgvUserList.Rows[e.RowIndex].Cells["LastName"].Value;
                    FrmUserList.email = "" + dgvUserList.Rows[e.RowIndex].Cells["Email"].Value;
                    FrmUserList.contact = "" + dgvUserList.Rows[e.RowIndex].Cells["Contact"].Value;
                    FrmUserList.cnic = "" + dgvUserList.Rows[e.RowIndex].Cells["Cnic"].Value;
                    FrmUserList.role = "" + dgvUserList.Rows[e.RowIndex].Cells["Role"].Value;
                    FrmUserList.password = "" + dgvUserList.Rows[e.RowIndex].Cells["Password"].Value;
                    FrmUserList.address = "" + dgvUserList.Rows[e.RowIndex].Cells["Address"].Value;
                    FrmUserList. status = "" + dgvUserList.Rows[e.RowIndex].Cells["Status"].Value;
                    FrmUserRegistration obj = new FrmUserRegistration();
                    this.Hide();
                    obj.ShowDialog();
                }
            }

            catch(Exception obj) 
            {
                MessageBox.Show(obj.Message);
            }
        }
        
    }
}
