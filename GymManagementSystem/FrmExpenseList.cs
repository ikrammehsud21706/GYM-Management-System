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
    public partial class FrmExpenseList : Form
    {
        public FrmExpenseList()
        {
            InitializeComponent();
            dgvExpenseList.DataSource = BLExpense.GetData();
        }
        public static string  Expense, Amount, Status, Date;
        public string PExpense, PAmount, PStatus, PDate;

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            FrmExpenseHead obj = new FrmExpenseHead();
            this.Hide();
            obj.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Gym Management System", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.IndianRed, new Point(200, 10));
            e.Graphics.DrawString("___________________________________________________________________________________________________________________________________________________________________", new Font("Century Gothic", 32, FontStyle.Bold), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("Expense=    " + PExpense, new Font("Century Gothic", 11, FontStyle.Regular), Brushes.Black, new Point(230, 90));
            e.Graphics.DrawString("Date=    " + DateTime.Now, new Font("Century Gothic", 11, FontStyle.Regular), Brushes.Black, new Point(230, 120));
            e.Graphics.DrawString("___________________________________________________________________________________________________________________________________________________________________", new Font("Century Gothic", 32, FontStyle.Bold), Brushes.Black, new Point(0, 150));
            e.Graphics.DrawString("Amount=    " + PAmount, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(230, 200));


        }

        private void txtTrainerName_Click(object sender, EventArgs e)
        {
            if (txtTrainerName.Text == "Search TarinerName")
            {
                txtTrainerName.Text = "";
                txtTrainerName.ForeColor = Color.Black;
            }
        }

        public static int ExpenseID;
        public static int ExpenseHeadId;
        private void dgvExpenseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    ExpenseID = Convert.ToInt32(dgvExpenseList.Rows[e.RowIndex].Cells["ExpenseId"].Value);
                    ExpenseHeadId = Convert.ToInt32(dgvExpenseList.Rows[e.RowIndex].Cells["ExpenseHeadId"].Value);
                    Expense = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Expense"].Value);
                    Amount = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Amount"].Value);
                    Status = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Status"].Value);
                    Date = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Date"].Value);
                    FrmExpense expense = new FrmExpense();
                    this.Hide();
                    expense.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    ExpenseID = Convert.ToInt32(dgvExpenseList.Rows[e.RowIndex].Cells["ExpenseId"].Value);
                    int check = BLExpense.Delete(ExpenseID);
                    if (check > 0)
                    {
                        dgvExpenseList.DataSource = BLExpense.GetData();
                    }
                }
                else if (e.ColumnIndex == 2)
                {

                    PExpense = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Expense"].Value);
                    PAmount = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Amount"].Value);
                    PStatus = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Status"].Value);
                    PDate = Convert.ToString(dgvExpenseList.Rows[e.RowIndex].Cells["Date"].Value);
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                    printDocument1.Print();
                }
            }
            catch
            {


            }
        }
    }
}
