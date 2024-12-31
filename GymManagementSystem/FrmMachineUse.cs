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
    public partial class FrmMachineUse : Form
    {
        public FrmMachineUse()
        {
            InitializeComponent();

            //ddlCustomername.DataSource = BLCustomer.GetData();
            //ddlCustomername.DisplayMember = "CustomerName";
            //ddlCustomername.ValueMember = "CustomerID";
            ddlMachineName.DataSource = BLMachine.GetData();
            ddlMachineName.DisplayMember = "MachineName";
            ddlMachineName.ValueMember = "Machineid";
            if (FrmMachineUseList.MachineUseId > 0)
            {
                DataTable dt = BLCustomer.GetSpecificCustomerRecord(FrmMachineUseList.Customerid);
                txtCustomerName.Text = "" + dt.Rows[0]["CustomerName"];
                CustomerId =Convert.ToInt32(dt.Rows[0]["CustomerId"]);
                ddlMachineName.SelectedValue = FrmMachineUseList.MachineId;
            }
            else
            {
                //DataTable dt = BLCustomer.GetCustomerMaxId();
                //CustomerId =Convert.ToInt32( dt.Rows[0]["MaxCustomerId"]);
                //dt = BLCustomer.GetSpecificCustomerRecord(CustomerId);
                //txtCustomerName.Text = "" + dt.Rows[0]["CustomerName"];
                GetLatestEnteredCustomer();
            }


            ddlStatus.Text = FrmMachineUseList.Status;
            ddlTime.Text = FrmMachineUseList.time;
        }
        int CustomerId;
        public void GetLatestEnteredCustomer()
        {
            DataTable dt = BLCustomer.GetCustomerMaxId();
            CustomerId = Convert.ToInt32(dt.Rows[0]["MaxCustomerId"]);
            dt = BLCustomer.GetSpecificCustomerRecord(CustomerId);
            txtCustomerName.Text = "" + dt.Rows[0]["CustomerName"];
        }
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                lblCustomerName.Text = "Required";
            }
            else if (ddlMachineName.Text == "")
            {
                lblMachineName.Text = "Required";
            }
            else if (ddlStatus.Text == "")
            {
                lblStatus.Text = "Required";
            }
            else if (ddlTime.Text == "")
            {
                lblTime.Text = "Required";
            }
            else
            {
                if (FrmMachineUseList.MachineUseId > 0)
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable dt = BLMachineUse.GetData(CustomerId, Convert.ToInt32(ddlMachineName.SelectedValue), FrmMachineUseList.MachineUseId);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Already Used This Machine,Select Another Machine");
                        }
                        else
                        {
                            dt = BLMachineUse.CheckMachineStatus(Convert.ToInt32(ddlMachineName.SelectedValue), ddlTime.Text);
                            if (Convert.ToInt32(dt.Rows[0]["UsedMachine"]) >= 5)
                            {
                                MessageBox.Show("You Can't Use Machine at this Time", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                BLMachineUse obj = new BLMachineUse();
                                obj.CustomerId = Convert.ToInt32(CustomerId);
                                obj.MachineId = Convert.ToInt32(ddlMachineName.SelectedValue);
                                obj.Status = ddlStatus.Text;
                                obj.time = ddlTime.Text;
                                obj.MachineUseId = FrmMachineUseList.MachineUseId;
                                if (BLMachineUse.Update(obj) == 1)
                                {
                                    MessageBox.Show("Updated");
                                    BLLog log = new BLLog();
                                    log.UserId = FrmLogin.UserId;
                                    log.Log = "This User '" + FrmLogin.UserName + "' added '";
                                    log.dateTime = DateTime.Now;
                                    BLLog.Save(log);
                                }
                            }
                        }

                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable dt = BLMachineUse.GetData(Convert.ToInt32(CustomerId), Convert.ToInt32(ddlMachineName.SelectedValue));
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Already Used This Machine,Select Another Machine");
                        }
                        else
                        {
                            dt = BLMachineUse.CheckMachineStatus(Convert.ToInt32(ddlMachineName.SelectedValue), ddlTime.Text);
                            if (Convert.ToInt32(dt.Rows[0]["UsedMachine"]) >= 5)
                            {
                                MessageBox.Show("You Can't Use Machine at this Time", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {

                                BLMachineUse obj = new BLMachineUse();
                                obj.CustomerId = Convert.ToInt32(CustomerId);
                                obj.MachineId = Convert.ToInt32(ddlMachineName.SelectedValue);
                                obj.Status = ddlStatus.Text;
                                obj.time = ddlTime.Text;
                                if (BLMachineUse.Save(obj) == 1)
                                {
                                    MessageBox.Show("Inserted");
                                    BLLog log = new BLLog();
                                    log.UserId = FrmLogin.UserId;
                                    log.Log = "This User '" + FrmLogin.UserName + "' added '";
                                    log.dateTime = DateTime.Now;
                                    BLLog.Save(log);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void ddlMachineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlMachineName.Text != "")
            {
                lblMachineName.Text = "";
            }
        }

        private void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStatus.Text != "")
            {
                lblStatus.Text = "";
            }
        }

        private void btnMachineUseList_Click(object sender, EventArgs e)
        {
            FrmMachineUseList obj = new FrmMachineUseList();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer obj = new FrmCustomer();
            this.Hide();
            obj.ShowDialog();
        }

        private void lblmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain frm= new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
