using GymManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FrmPaymentList : Form
    {
        public FrmPaymentList()
        {
            InitializeComponent();
            if (FrmLogin.Role == "Operator")
            {
                dgvPaymentList.Columns[0].Visible = false;
                dgvPaymentList.Columns[1].Visible = false;
            }
            dgvPaymentList.DataSource = BLPayment.GetData();
        }
        public static int PaymentID, CustomerID;
        public static string Amount, Date;


        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            FrmPayment obj = new FrmPayment();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnAddPayment_MouseEnter(object sender, EventArgs e)
        {
            btnAddPayment.BackColor = Color.DarkRed;
        }

        private void btnAddPayment_MouseLeave(object sender, EventArgs e)
        {
            btnAddPayment.BackColor = Color.DarkRed;
        }

        private void dtPaidCustomer_ValueChanged_1(object sender, EventArgs e)
        {
            dgvPaymentList.DataSource = BLPayment.GetData(dtPaidCustomer.Value.ToString("Y"));
        }
        int checkCustomer = 0;
        private void dtDefaulterCustomer_ValueChanged(object sender, EventArgs e)
        {
            checkCustomer = 1;
            //select *from TblCustomer where CustomerId<>1 and CustomerId<>2 and CustomerId<>5 and CustomerID<>6 and
            string Query = "select *from TblCustomer Where ";
            DataTable dt = BLPayment.GetData(dtDefaulterCustomer.Value.ToString("Y"));
            int length = dt.Rows.Count;
            if (length > 1)
            {
                int i;
                for (i = 0; i < length - 1; i++)
                {
                    Query += "CustomerId<>" + dt.Rows[i]["CustomerId"] + " and ";
                }
                if (length == i + 1)
                {
                    Query += "CustomerId<>" + dt.Rows[i]["CustomerId"];
                }
                SqlDataAdapter adapter = new SqlDataAdapter(Query, "server=DESKTOP-N2V11J1\\SQLEXPRESS;database=GymManagementSystem;integrated security=true");
                dt = new DataTable();
                adapter.Fill(dt);
                dgvPaymentList.DataSource = dt;
            }
            else if (length == 1)
            {
                Query += "CustomerId<>" + dt.Rows[0]["CustomerId"];
                SqlDataAdapter adapter = new SqlDataAdapter(Query, "server=DESKTOP-N2V11J1\\SQLEXPRESS;database=GymManagementSystem;integrated security=true");
                dt = new DataTable();
                adapter.Fill(dt);
                dgvPaymentList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Any payment has not been paid for this month");
            }
            
        }

        private void txtCustomerName_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text== "Search CustomerName")
            {
                txtCustomerName.Text = "";
                txtCustomerName.ForeColor = Color.Black;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            FrmMain obj=new FrmMain();
            this.Hide();
            obj.ShowDialog();
        }

        private void dgvPaymentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (checkCustomer == 1)
                {
                    PaymentID = 0;
                    if (e.ColumnIndex == 0)
                    {
                        CustomerID = Convert.ToInt32(dgvPaymentList.Rows[e.RowIndex].Cells["CustomerId"].Value);
                        FrmPayment obj = new FrmPayment();
                        this.Hide();
                        obj.ShowDialog();
                    }
                   
                }
                else
                {
                    PaymentID = Convert.ToInt32(dgvPaymentList.Rows[e.RowIndex].Cells["PaymentId"].Value);
                    if (e.ColumnIndex == 0)
                    {
                        Amount = "" + dgvPaymentList.Rows[e.RowIndex].Cells["Amount"].Value;
                        Date = "" + dgvPaymentList.Rows[e.RowIndex].Cells["Date"].Value;
                        CustomerID = Convert.ToInt32(dgvPaymentList.Rows[e.RowIndex].Cells["CustomerId"].Value);
                        FrmPayment obj = new FrmPayment();
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        int check = BLPayment.Delete(PaymentID);
                        if (check > 0)
                        {
                            MessageBox.Show("Record Deleted");
                            dgvPaymentList.DataSource = BLPayment.GetData();
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void txtPaymentId_TextChanged(object sender, EventArgs e)
        {
            dgvPaymentList.DataSource = BLPayment.Searching("CustomerName", txtCustomerName.Text);
        }


    }
}
