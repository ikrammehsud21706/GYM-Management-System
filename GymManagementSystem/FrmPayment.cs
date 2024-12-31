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

namespace GymManagementSystem
{
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
            if ((FrmPaymentList.PaymentID > 0)|(FrmPaymentList.CustomerID> 0))
            {
                LoadCustomer();
                ddlCustomerName.SelectedValue = FrmPaymentList.CustomerID;
            }
            else
            {
                LoadCustomer();
            }
            txtAmount.Text = FrmPaymentList.Amount;
            dateTimePicker1.Text = FrmPaymentList.Date;
            FrmPaymentList.Amount = "";
            FrmPaymentList.CustomerID = 0;
        }
        public void LoadCustomer()
        {
            ddlCustomerName.DataSource = BLCustomer.GetData();
            ddlCustomerName.DisplayMember = "CustomerName";
            ddlCustomerName.ValueMember = "CustomerId";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "a")
            {
                lblAmount.Text = "Required";
            }
            //else if (dateTimePicker1.Value + "" == "")
            //{
            //    lblDate.Text = "Required";
            //}
            //else if (ddlCustomerName.Text == "")
            //{
            //    lblCustomerId.Text = "Required";
            //}
            else
            {
                if (FrmPaymentList.PaymentID > 0)
                {
                    BLPayment obj = new BLPayment();
                    obj.Amount = txtAmount.Text;
                    obj.Date = dateTimePicker1.Value.ToString("Y");
                    obj.CustomerId = Convert.ToInt32(ddlCustomerName.SelectedValue);
                    obj.PaymentId = FrmPaymentList.PaymentID;
                    if (BLPayment.Update(obj) == 1)
                    {
                        MessageBox.Show("Updated successfully");
                        BLLog log = new BLLog();
                        log.UserId = FrmLogin.UserId;
                        log.Log = "This User:" + FrmLogin.UserName + " Updated payment of Customer:'" + ddlCustomerName.Text + "' SuccessFully";
                        log.dateTime = DateTime.Now;
                        BLLog.Save(log);
                    }
                    txtAmount.Text = "";
                    dateTimePicker1.Text = "";
                    ddlCustomerName.Text = "";
                    FrmPaymentList.PaymentID = 0;
                }
                else
                {
                    DataTable dt = BLPayment.CheckPayment(Convert.ToInt32(ddlCustomerName.SelectedValue), dateTimePicker1.Value.ToString("t"));
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("This Customer have paid his fee");
                    }
                    else
                    {
                        BLPayment obj = new BLPayment();
                        obj.Amount = txtAmount.Text;
                        obj.Date = dateTimePicker1.Value.ToString("Y");
                        obj.CustomerId = Convert.ToInt32(ddlCustomerName.SelectedValue);
                        if (BLPayment.Save(obj) == 1)
                        {
                            MessageBox.Show("Inserted successfully");
                            BLLog log = new BLLog();
                            log.UserId = FrmLogin.UserId;
                            log.Log = "This User:" + FrmLogin.UserName + " Inserted payment of Customer:'" + ddlCustomerName.Text + "' SuccessFully";
                            log.dateTime = DateTime.Now;
                            BLLog.Save(log);
                        }
                        txtAmount.Text = "";
                      //  ddlCustomerName.SelectedIndex = 0;
                        FrmPaymentList.PaymentID = 0;
                    }
                }
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                lblAmount.Text = "";
            }
        }
        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            FrmPaymentList obj = new FrmPaymentList();
            this.Hide();
            obj.ShowDialog();
        }

        private void ddlCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int fee = 1500;
            int CustomerId = Convert.ToInt32(ddlCustomerName.SelectedValue);
            DataTable dt = BLCustomer.GetData(CustomerId);
            int TrainerId = Convert.ToInt32(dt.Rows[0]["TrainerId"]);
            dt = BLTrainer.GetData(TrainerId);
            if (dt.Rows[0]["Type"] + "" == "Personal Trainer")
            {
                fee += 2000;
            }
            dt = BLMachineUse.GetData(CustomerId);
            if (dt.Rows.Count > 0)
            {
                fee += dt.Rows.Count * 2000;
            }
            txtAmount.Text = "" + fee;
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkRed;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkRed;
        }

        private void btnPaymentList_MouseEnter(object sender, EventArgs e)
        {
            btnPaymentList.BackColor = Color.DarkRed;
        }

        private void btnPaymentList_MouseLeave(object sender, EventArgs e)
        {
            btnPaymentList.BackColor = Color.DarkRed;
        }

        private void ddlCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCustomerName.Text != "")
            {
                lblCustomerId.Text = "";
            }
        }

        private void lblmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        //private void ddlCustomerName_Click(object sender, EventArgs e)
        //{
        //    LoadCustomer();
        //}
    }
}

