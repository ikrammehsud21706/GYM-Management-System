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
    public partial class FrmExpense : Form
    {
        public FrmExpense()
        {
            InitializeComponent();
            try
            {
                ddlExpenseHead.DataSource = BLExpenseHead.GetData();
                ddlExpenseHead.DisplayMember = "ExpenseHead";
                ddlExpenseHead.ValueMember = "ExpenseHeadId";
                if (FrmExpenseList.ExpenseID > 0)
                {
                    ddlExpenseHead.SelectedValue = FrmExpenseList.ExpenseHeadId;
                }
                else
                {
                    
                    DataTable dt = BLExpenseHead.GetLatestExpenseHead();
                    ExpenseHeadMaxID = Convert.ToInt32(dt.Rows[0]["ExpenseHeadMaxId"]);
                    ddlExpenseHead.SelectedValue = ExpenseHeadMaxID;
                }
                txtAmount.Text = FrmExpenseList.Amount;
                txtExpense.Text = FrmExpenseList.Expense;
                ddlStatus.Text = FrmExpenseList.Status;
                dtExpense.Text = FrmExpenseList.Date;
            }
            catch 
            {

            }
        }

        int ExpenseHeadMaxID;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ddlExpenseHead.Text == "")
            {
                lblExpenseHead.Text = "Required";
            }
            else if (txtExpense.Text == "")
            {
                lblExpense.Text = "Required";
            }
            else if (txtAmount.Text == "")
            {
                lblAmount.Text = "Required";
            }
            else if (ddlStatus.Text == "")
            {
                lblStatus.Text = "Required";
            }
            else if (dtExpense.Text == "")
            {
                lblDate.Text = "Required";
            }
            else
            {
                if (FrmExpenseList.ExpenseID > 0)
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLExpense obj = new BLExpense();
                        obj.ExpenseHeadid = Convert.ToInt32(ddlExpenseHead.SelectedValue);
                        obj.Expense = txtExpense.Text;
                        obj.Amount = txtAmount.Text;
                        obj.Status = ddlStatus.Text;
                        obj.Date = dtExpense.Value.ToString("Y");
                        obj.ExpenseId = FrmExpenseList.ExpenseID;
                        if (BLExpense.Update(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            BLLog log = new BLLog();
                            log.UserId = FrmLogin.UserId;
                            log.Log = "This User:'" + FrmLogin.UserName + "' Updated an Expense of amount:'" + txtExpense.Text + "'";
                            log.dateTime = DateTime.Now;
                            BLLog.Save(log);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLExpense obj = new BLExpense();
                        obj.ExpenseHeadid = Convert.ToInt32(ddlExpenseHead.SelectedValue);
                        obj.Expense = txtExpense.Text;
                        obj.Amount = txtAmount.Text;
                        obj.Status = ddlStatus.Text;
                        obj.Date = dtExpense.Value.ToString("Y");
                        if (BLExpense.Save(obj) == 1)
                        {
                            MessageBox.Show("Inserted");
                            BLLog log = new BLLog();
                            log.UserId = FrmLogin.UserId;
                            log.Log = "This User:'" + FrmLogin.UserName + "' inserted an Expense of amount:'" + txtExpense.Text + "'";
                            log.dateTime = DateTime.Now;
                            BLLog.Save(log);
                        }
                    }
                }
            }
        }

        private void ddlExpenseHead_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ddlExpenseHead.Text=="Salary")
            {
                txtAmount.Enabled = false;
                DataTable dt = BLSalary.GetData(DateTime.Now.ToString("Y"));
                if (dt.Rows.Count>0)
                {
                    int TotalSalary = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TotalSalary +=Convert.ToInt32( dt.Rows[i]["Amount"]);
                    }
                    txtAmount.Text = TotalSalary.ToString();    
                }
            }
        }

        private void btnExpenseList_Click(object sender, EventArgs e)
        {
            FrmExpenseList obj=new FrmExpenseList();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnexpensehead_Click(object sender, EventArgs e)
        {
            FrmExpenseHead frm=new FrmExpenseHead();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
