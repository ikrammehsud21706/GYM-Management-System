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
    public partial class FrmExpenseHeadList : Form
    {
        public FrmExpenseHeadList()
        {
            InitializeComponent();
            if (FrmLogin.Role == "Operator")
            {
                dgvExpenseHeadList.Columns[0].Visible = false;
                dgvExpenseHeadList.Columns[1].Visible = false;
            }
            dgvExpenseHeadList.DataSource = BLExpenseHead.GetData();
        }
        public static int ID;
        public static string ExpenseHead, Status;

        private void btnAddExpenseHead_Click(object sender, EventArgs e)
        {
            FrmExpenseHead obj = new FrmExpenseHead();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtExpenseHead_Click(object sender, EventArgs e)
        {
            if (txtExpenseHead.Text=="Search ExpenseHead")
            {
                txtExpenseHead.Text = "";
                txtExpenseHead.ForeColor = Color.Red;
            }
        }

        private void txtExpenseHead_TextChanged(object sender, EventArgs e)
        {
            dgvExpenseHeadList.DataSource = BLExpenseHead.Searching("ExpenseHead", txtExpenseHead.Text);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            FrmMain frm=new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void dgvExpenseHeadList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvExpenseHeadList.Rows[e.RowIndex].Cells["ExpenseHeadId"].Value);
                if (e.ColumnIndex == 0)
                {
                    ExpenseHead = "" + dgvExpenseHeadList.Rows[e.RowIndex].Cells["ExpenseHead"].Value;
                    Status = "" + dgvExpenseHeadList.Rows[e.RowIndex].Cells["Status"].Value;
                    FrmExpenseHead obj = new FrmExpenseHead();
                    this.Close();
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int check = BLExpenseHead.Delete(ID);
                        if (check > 0)
                        {
                            dgvExpenseHeadList.DataSource = BLExpenseHead.GetData();
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
