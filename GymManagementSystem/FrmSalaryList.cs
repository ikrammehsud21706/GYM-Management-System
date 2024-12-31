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
    public partial class FrmSalaryList : Form
    {
        public FrmSalaryList()
        {
            InitializeComponent();
            dgvSalaryList.DataSource = BLSalary.GetData();
        }
        public static int ID, TrainerId; public static string Amount, Date;

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            FrmSalary obj = new FrmSalary();
            this.Hide();
            obj.ShowDialog();
        }

        private void dtPaidTrainer_ValueChanged(object sender, EventArgs e)
        {
            dgvSalaryList.DataSource = BLSalary.GetData(dtPaidTrainer.Value.ToString("Y"));
        }

        private void dtUnPaidTrainer_ValueChanged(object sender, EventArgs e)
        {

            string Query = "select * from tblTrainer where ";
            DataTable dt = BLSalary.GetData(dtUnPaidTrainer.Value.ToString("Y"));
            int length = dt.Rows.Count;
            if (length > 1)
            {
                int i;
                for (i = 0; i < length - 1; i++)
                {
                    Query += "TrainerId<>" + dt.Rows[i]["TrainerId"] + " and ";
                }
                if (length == i + 1)
                {
                    Query += "TrainerId<>" + dt.Rows[i]["TrainerId"];
                }
                SqlDataAdapter ad = new SqlDataAdapter(Query, "server=DESKTOP-N2V11J1\\SQLEXPRESS;database=GymManagementSystem;integrated security=true");
                dt = new DataTable();
                ad.Fill(dt);
                dgvSalaryList.DataSource = dt;
            }
            else if (length == 1)
            {
                Query += "TrainerId<>" + dt.Rows[0]["TrainerId"];
                SqlDataAdapter ad = new SqlDataAdapter(Query, "server=DESKTOP-N2V11J1\\SQLEXPRESS;database=GymManagementSystem;integrated security=true");
                dt = new DataTable();
                ad.Fill(dt);
                dgvSalaryList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Any salary has not been issued for this month");
            }



        }

        private void FrmSalaryList_Load(object sender, EventArgs e)
        {

        }

        private void txtTrainerName_Click(object sender, EventArgs e)
        {
            if (txtTrainerName.Text == "Search TrainerName")
            {
                txtTrainerName.Text = "";
                txtTrainerName.ForeColor = Color.Black;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            FrmMain obj = new FrmMain();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtSalaryId_TextChanged(object sender, EventArgs e)
        {
            dgvSalaryList.DataSource = BLSalary.Searching("TrainerName", txtTrainerName.Text);
        }

        private void dgvSalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvSalaryList.Rows[e.RowIndex].Cells["SalaryId"].Value);
                if (e.ColumnIndex == 0)
                {
                    Amount = "" + dgvSalaryList.Rows[e.RowIndex].Cells["Amount"].Value;
                    Date = "" + dgvSalaryList.Rows[e.RowIndex].Cells["Date"].Value;
                    TrainerId = Convert.ToInt32(dgvSalaryList.Rows[e.RowIndex].Cells["TrainerId"].Value);
                    FrmSalary obj = new FrmSalary();
                    this.Hide();
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    int check = BLSalary.Delete(ID);
                    if (check > 0)
                    {
                        MessageBox.Show("Record Deleted");
                        dgvSalaryList.DataSource = BLSalary.GetData();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
