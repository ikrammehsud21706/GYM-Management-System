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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GymManagementSystem
{
    public partial class FrmUserList : Form
    {
       
        public FrmUserList()
        {
            InitializeComponent();
            if (FrmLogin.Role == "Operator")
            {
                dgvUserList.Columns[0].Visible = false;
                dgvUserList.Columns[1].Visible = false;
            }
            dgvUserList.DataSource=BLUser.GetData();
        }
        public static string username, firstname, lastname, email, contact, cnic, role, password, address, status;

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="Search Username")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Search Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtContact_Click(object sender, EventArgs e)
        {
            if (txtContact.Text == "Search Contact")
            {
                txtContact.Text = "";
                txtContact.ForeColor = Color.Black;
            }
        }

        private void txtCnic_Click(object sender, EventArgs e)
        {
            if (txtCnic.Text == "Search CNIC")
            {
                txtCnic.Text = "";
                txtCnic.ForeColor = Color.Black;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            FrmMain obj = new FrmMain();
            this.Hide();
            obj.ShowDialog();
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
           dgvUserList.DataSource= BLUser.Searching("UserName",txtUserName.Text);
           //dgvUserList.DataSource= BLUser.SearchingUserName(txtUserName.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
             dgvUserList.DataSource = BLUser.Searching("Email",txtEmail.Text);
            //dgvUserList.DataSource = BLUser.SearchingEmail(txtEmail.Text);
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            dgvUserList.DataSource = BLUser.Searching("Contact",txtContact.Text);
            //dgvUserList.DataSource = BLUser.SearchingContact(txtContact.Text);
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            dgvUserList.DataSource = BLUser.Searching("Cnic",txtCnic.Text);
            //dgvUserList.DataSource = BLUser.SearchingCnic(txtCnic.Text);

        }
       public static string LogUsername; public static int LogUserid;
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
                        int check=BLUser.Delete(id);
                  
                        if (check>0)
                        {
                            MessageBox.Show("Record Deleted");
                            LogUsername =""+ dgvUserList.Rows[e.RowIndex].Cells["UserName"].Value;
                            LogUserid =Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["UserId"].Value);
                            BLLog log=new BLLog();
                            log.UserId = LogUserid;
                            log.Log="This Admin '"+FrmLogin.UserName +"' has deleted the record of '"+LogUsername+"' successfully";
                            log.dateTime=DateTime.Now;
                            BLLog.Save(log);
                            dgvUserList.DataSource = BLUser.GetData();
                        }
                    }
                }
                else if (e.ColumnIndex == 0)
                {
                    FrmUserList.id = Convert.ToInt32(dgvUserList.Rows[e.RowIndex].Cells["UserId"].Value);
                    FrmUserList.username = "" + dgvUserList.Rows[e.RowIndex].Cells["UserName"].Value;
                    FrmUserList.firstname = "" + dgvUserList.Rows[e.RowIndex].Cells["FirstName"].Value;
                    FrmUserList.lastname = "" + dgvUserList.Rows[e.RowIndex].Cells["LastName"].Value;
                    FrmUserList.email = "" + dgvUserList.Rows[e.RowIndex].Cells["Email"].Value;
                    FrmUserList.contact = "" + dgvUserList.Rows[e.RowIndex].Cells["Contact"].Value;
                    FrmUserList.cnic = "" + dgvUserList.Rows[e.RowIndex].Cells["Cnic"].Value;
                    FrmUserList.role = "" + dgvUserList.Rows[e.RowIndex].Cells["Role"].Value;
                    FrmUserList.password = "" + dgvUserList.Rows[e.RowIndex].Cells["Password"].Value;
                    FrmUserList.address = "" + dgvUserList.Rows[e.RowIndex].Cells["Address"].Value;
                    FrmUserList.status = "" + dgvUserList.Rows[e.RowIndex].Cells["Status"].Value;
                    FrmUserRegistration obj = new FrmUserRegistration();
                    this.Hide();
                    obj.ShowDialog();
                }
            }

            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

    }
}
