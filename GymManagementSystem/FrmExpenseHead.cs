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
    public partial class FrmExpenseHead : Form
    {
        public FrmExpenseHead()
        {
            InitializeComponent();
            ddlExpenseHead.SelectedValue = FrmExpenseHeadList.ExpenseHead;
            ddlStatus.Text = FrmExpenseHeadList.Status;
            FrmExpenseHeadList.ExpenseHead = "";
            FrmExpenseHeadList.Status = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ddlExpenseHead.Text == "")
            {
                lblExpenseHead.Text = "Required";
            }
            else if (ddlStatus.Text == "")
            {
                lblStatus.Text = "Required";
            }
            else
            {
                BLExpenseHead obj = new BLExpenseHead();
                obj.ExpenseHead = ddlExpenseHead.Text;
                obj.Status = ddlStatus.Text;
                if (FrmExpenseHeadList.ID > 0)
                {
                    obj.ExpenseHeadId = FrmExpenseHeadList.ID;
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (BLExpenseHead.Update(obj) == 1)
                        {
                            MessageBox.Show("Updated");
                            BLLog log = new BLLog();
                            log.UserId = FrmLogin.UserId;
                            log.Log = "This User '" + FrmLogin.UserName + "' has Updated the Expensehead '" + ddlExpenseHead.Text + "'";
                            log.dateTime = DateTime.Now;
                            BLLog.Save(log);
                            FrmExpense objj = new FrmExpense();
                            this.Hide();
                            objj.ShowDialog();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (BLExpenseHead.Save(obj) == 1)
                        {
                            BLLog log = new BLLog();
                            log.UserId = FrmLogin.UserId;
                            log.Log = "This User '" + FrmLogin.UserName + "' has inserted the Expensehead '" + ddlExpenseHead.Text + "'";
                            log.dateTime = DateTime.Now;
                            BLLog.Save(log);
                            FrmExpense objj=new FrmExpense();
                            this.Hide();
                            objj.ShowDialog();
                        }
                    }
                }
                FrmExpenseHeadList.ExpenseHead = "";
                FrmExpenseHeadList.ID = 0;
                FrmExpenseHeadList.Status = "";
            }
        }

        private void txtExpenseHead_TextChanged(object sender, EventArgs e)
        {
            if (ddlExpenseHead.Text != "")
            {
                lblExpenseHead.Text = "";
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            if (ddlStatus.Text != "")
            {
                lblStatus.Text = "";
            }
        }

        private void btnExpenseHeadList_Click(object sender, EventArgs e)
        {
            FrmExpenseHeadList obj = new FrmExpenseHeadList();
            this.Hide();
            obj.ShowDialog();
        }

        private void lblmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
