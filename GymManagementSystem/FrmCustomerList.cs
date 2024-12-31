using GymManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
            if (FrmLogin.Role == "Operator")
            {
                dgvCustomerList.Columns[0].Visible = false;
                dgvCustomerList.Columns[1].Visible = false;
            }
            dgvCustomerList.DataSource = BLCustomer.GetData();
        }
        public static int ID,age,weight,trainerid;

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource=BLCustomer.Searching("CNIC",txtCnic.Text);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer obj=new FrmCustomer();
            this.Hide();
            obj.ShowDialog();
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
            FrmMain obj=new FrmMain();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource=BLCustomer.Searching("Contact",txtContact.Text);
        }

        public static string customername, contact, cnic, address, status, type, gender;
        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["CustomerID"].Value);
                if (e.ColumnIndex == 0)
                {
                    customername = "" + dgvCustomerList.Rows[e.RowIndex].Cells["CustomerName"].Value;
                    contact = "" + dgvCustomerList.Rows[e.RowIndex].Cells["Contact"].Value;
                    cnic = "" + dgvCustomerList.Rows[e.RowIndex].Cells["CNIC"].Value;
                    address = "" + dgvCustomerList.Rows[e.RowIndex].Cells["Address"].Value;
                    status = "" + dgvCustomerList.Rows[e.RowIndex].Cells["Status"].Value;
                    type = "" + dgvCustomerList.Rows[e.RowIndex].Cells["Type"].Value;
                    age = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["Age"].Value);
                    weight = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["Weight"].Value);
                    gender = "" + dgvCustomerList.Rows[e.RowIndex].Cells["Gender"].Value;
                    trainerid = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["TrainerID"].Value);
                    FrmCustomer customer = new FrmCustomer();
                    this.Hide();
                    customer.ShowDialog();

                }
                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int check = BLCustomer.Delete(ID);
                        if (check > 0)
                        {
                            MessageBox.Show("Record Deleted");
                            dgvCustomerList.DataSource = BLCustomer.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Recored deletion Failed");
                        }
                    }
                }
            }
            catch 
            {

            }
           
        }
    }
}
