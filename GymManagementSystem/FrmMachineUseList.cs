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
    public partial class FrmMachineUseList : Form
    {
        public FrmMachineUseList()
        {
            InitializeComponent();
            dgvMachineUseList.DataSource = BLMachineUse.GetData();
        }
        public static int Customerid, MachineId,MachineUseId;

        private void btnAddMachineUse_Click(object sender, EventArgs e)
        {
            FrmMachineUse obj=new FrmMachineUse();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtCustomerName_TextChanged_1(object sender, EventArgs e)
        {
            dgvMachineUseList.DataSource = BLMachineUse.Searching("CustomerName", txtCustomerName.Text);
        }

        private void txtCustomerName_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text== "Search CustomerName")
            {
                txtCustomerName.Text = "";
                txtCustomerName.ForeColor= Color.Black;
            }
        }

        private void btnmain_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        public static string Status, time;
        private void dgvMachineUseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MachineUseId = Convert.ToInt32(dgvMachineUseList.Rows[e.RowIndex].Cells["MachineUseId"].Value);
                if (e.ColumnIndex == 0)
                {
                    Customerid = Convert.ToInt32(dgvMachineUseList.Rows[e.RowIndex].Cells["CustomerId"].Value);
                    MachineId = Convert.ToInt32(dgvMachineUseList.Rows[e.RowIndex].Cells["MachineId"].Value);
                    Status = Convert.ToString(dgvMachineUseList.Rows[e.RowIndex].Cells["Status"].Value);
                    time = Convert.ToString(dgvMachineUseList.Rows[e.RowIndex].Cells["Time"].Value);
                    FrmMachineUse obj = new FrmMachineUse();
                    this.Hide();
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int check = BLMachineUse.Delete(MachineUseId);
                        if (check > 0)
                        {
                            MessageBox.Show("Record Deleted");
                            dgvMachineUseList.DataSource = BLMachineUse.GetData();
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
