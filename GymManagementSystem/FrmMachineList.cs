using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GymManagementSystem.BL;

namespace GymManagementSystem
{
    public partial class FrmMachineList : Form
    {
        public FrmMachineList()
        {
            InitializeComponent();
            if (FrmLogin.Role=="Operator")
            {
                DgvMachineList.Columns[0].Visible = false;
                DgvMachineList.Columns[1].Visible = false;
            }
            DgvMachineList.DataSource = BLMachine.GetData();
        }
        public static int iD;
        public static string machineName, machineStatus;
        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            FrmMachine obj=new FrmMachine();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtMachineId_TextChanged(object sender, EventArgs e)
        {
            DgvMachineList.DataSource=BLMachine.Searching("MachineName",txtMachineName.Text);
        }

        private void txtMachineName_Click(object sender, EventArgs e)
        {
            if (txtMachineName.Text== "Search MachineName")
            {
                txtMachineName.Text = "";
                txtMachineName.ForeColor = Color.Black;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            FrmMain obj = new FrmMain();
            this.Hide();
            obj.ShowDialog();
        }

        private void DgvMachineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    iD = Convert.ToInt32(DgvMachineList.Rows[e.RowIndex].Cells["MachineId"].Value);
                    machineName = "" + DgvMachineList.Rows[e.RowIndex].Cells["MachineName"].Value;
                    machineStatus = "" + DgvMachineList.Rows[e.RowIndex].Cells["Status"].Value;
                    FrmMachine obj = new FrmMachine();
                    this.Hide();
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        iD = Convert.ToInt32(DgvMachineList.Rows[e.RowIndex].Cells["MachineId"].Value);
                        int check = BLMachine.Delete(iD);
                        if (check > 0)
                        {
                            MessageBox.Show("Record Deleted");
                            DgvMachineList.DataSource = BLMachine.GetData();
                            BLLog log = new BLLog();
                            log.UserId = FrmLogin.UserId;
                            log.Log = "This User '" + FrmLogin.UserName + "' has deleted the Machine '" + machineName + "'";
                            log.dateTime = DateTime.Now;
                            BLLog.Save(log);
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
