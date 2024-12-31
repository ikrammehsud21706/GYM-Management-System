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
    public partial class FrmMachine : Form
    {
        public FrmMachine()
        {
            InitializeComponent();
            txtMachineName.Text = FrmMachineList.machineName;
            ddlStatus.Text = FrmMachineList.machineStatus;
            FrmMachineList.machineName = "";
            FrmMachineList.machineStatus = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtMachineName.Text == "")
            {
                lblMachineName.Text = "Required";
            }
            else if (ddlStatus.Text == "")
            {
                lblStatus.Text = "Required";
            }
            else
            {
                if (FrmMachineList.iD > 0)
                {
                    BLMachine obj = new BLMachine();
                    obj.machinename = txtMachineName.Text;
                    obj.status = ddlStatus.Text;
                    obj.machineid = FrmMachineList.iD;
                    if (BLMachine.Update(obj) > 0)
                    {
                        MessageBox.Show("Updated");
                        BLLog log = new BLLog();
                        log.UserId = FrmLogin.UserId;
                        log.Log = "This User '" + FrmLogin.UserName + "' has Updated the Machine '" + txtMachineName.Text + "'";
                        log.dateTime = DateTime.Now;
                        BLLog.Save(log);
                    }
                    ddlStatus.Text = "";
                    txtMachineName.Text = "";
                    FrmMachineList.iD = 0;
                }
                else
                {
                    BLMachine obj = new BLMachine();
                    obj.machinename = txtMachineName.Text;
                    obj.status = ddlStatus.Text;
                    if (BLMachine.Save(obj)==1)
                    {

                        MessageBox.Show("submitted");
                        BLLog log = new BLLog();
                        log.UserId = FrmLogin.UserId;
                        log.Log = "This User '" + FrmLogin.UserName + "' has inserted the Machine '" + txtMachineName.Text + "'";
                        log.dateTime = DateTime.Now;
                        BLLog.Save(log);
                    }
                    ddlStatus.Text = "";
                    txtMachineName.Text = "";
                    FrmMachineList.iD = 0;
                }
            }
        }

        private void btnMachineList_Click(object sender, EventArgs e)
        {
            FrmMachineList obj = new FrmMachineList();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtMachineName_TextChanged(object sender, EventArgs e)
        {
            lblMachineName.Text = "";
        }

        private void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void lblmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain frm= new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
