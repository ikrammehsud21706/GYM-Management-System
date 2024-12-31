using GymManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagementSystem
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
            txtCustomerName.Text = FrmCustomerList.customername;
            txtContact.Text = FrmCustomerList.contact;
            txtCnic.Text = FrmCustomerList.cnic;
            txtAddress.Text = FrmCustomerList.address;
            ddlStatus.Text = FrmCustomerList.status;
            ddlCustomerType.SelectedValue = FrmCustomerList.type;
            txtAge.Text = "" + FrmCustomerList.age;
            txtWeight.Text = "" + FrmCustomerList.weight;
            if (FrmCustomerList.gender=="Male")
            {
                rdoMale.Checked = true;
            }
            else if (FrmCustomerList.gender=="Female")
            {
                rdoFemale.Checked = true;
            }
            else if(FrmCustomerList.gender=="Other")
            {
                rdoOther.Checked = true;
            }
            LoadTrainer();
            ddlTrainerName.SelectedValue = FrmCustomerList.trainerid;
            FrmCustomerList.customername = "";
            FrmCustomerList.contact = "";
            FrmCustomerList.cnic = "";
            FrmCustomerList.address = "";
            FrmCustomerList.status = "";
            FrmCustomerList.type = "";
            FrmCustomerList.age = 0;
            FrmCustomerList.weight = 0;
            FrmCustomerList.gender = "";
            FrmCustomerList.trainerid = 0;
        }
        public void LoadTrainer()
        {
            ddlTrainerName.DataSource = BLTrainer.GetData();
            ddlTrainerName.DisplayMember = "TrainerName";
            ddlTrainerName.ValueMember = "TrainerId";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                lblCustomerName.Text = "Required";
            }
            //else if (txtContact.Text == "")
            //{
            //    lblContact.Text = "Required";
            //}
            //else if (txtCnic.Text == "")
            //{
            //    lblCnic.Text = "Required";
            //}
            //else if (txtAddress.Text == "")
            //{
            //    lblAddress.Text = "Required";
            //}
            //else if (ddlStatus.Text == "")
            //{
            //    lblStatus.Text = "Required";
            //}
            //else if (ddlCustomerType.Text == "")
            //{
            //    lblType.Text = "Required";
            //}
            //else if (txtAge.Text == "")
            //{
            //    lblAge.Text = "Required";
            //}
            //else if (txtWeight.Text == "")
            //{
            //    lblWeight.Text = "Required";
            //}
            else if (rdoMale.Checked == false & rdoFemale.Checked == false & rdoOther.Checked == false)
            {
                lblGender.Text = "Gender Required";
            }

            else
            {
                if (txtContact.TextLength < 11)
                {
                    lblContact.Text = "Insufficient Contact Number";
                }
                else if (txtCnic.TextLength < 13)
                {
                    lblCnic.Text = "Insufficient CNIC Number";
                }
                else
                {
                    if (FrmCustomerList.ID > 0)
                    {
                        DataTable dt = BLCustomer.CheckCustomerInUpdate("Contact", txtContact.Text, FrmCustomerList.ID);
                        DataTable dtt = BLCustomer.CheckCustomerInUpdate("CNIC", txtCnic.Text, FrmCustomerList.ID);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtContact.Text + " is already Exist");
                        }
                        else if (dtt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtCnic.Text + " is already Exist");
                        }
                        else
                        {
                            string Gender;
                            BLCustomer obj = new BLCustomer();
                            obj.customername = txtCustomerName.Text;
                            obj.contact = txtContact.Text;
                            obj.cnic = txtCnic.Text;
                            obj.address = txtAddress.Text;
                            obj.status = ddlStatus.Text;
                            obj.type = ddlCustomerType.Text;
                            obj.age = Convert.ToInt32(txtAge.Text);
                            obj.weight = Convert.ToInt32(txtWeight.Text);
                            if (rdoMale.Checked==true)
                            {
                                Gender = "Male";
                            }
                            else if (rdoFemale.Checked==true)
                            {
                                Gender = "Female";
                            }
                            else
                            {
                                Gender = "Other";
                            }
                            obj.gender= Gender;
                            obj.customerid = FrmCustomerList.ID;
                            obj.trainerid = Convert.ToInt32(ddlTrainerName.SelectedValue);
                            if (BLCustomer.Update(obj) == 1)
                            {
                                MessageBox.Show("Updated successfully");
                                BLLog log = new BLLog();
                                log.UserId = FrmLogin.UserId;
                                log.Log = "This User:" + FrmLogin.UserName + " is updated This Customer:'" + txtCustomerName.Text + "' SuccessFully";
                                log.dateTime = DateTime.Now;
                                BLLog.Save(log);
                                FrmMachineUse frmMachineUse = new FrmMachineUse();
                                frmMachineUse.ShowDialog();
                            }
                            FrmCustomerList.ID = 0;
                            txtCustomerName.Text = "";
                            txtContact.Text = "";
                            txtCnic.Text = "";
                            txtAddress.Text = "";
                            ddlStatus.Text = "";
                            ddlCustomerType.Items.Clear();
                            txtAge.Text = "";
                            txtWeight.Text = "";
                        }
                    }
                    else
                    {
                        DataTable dt = BLCustomer.CheckCustomer("Contact", txtContact.Text);
                        DataTable dtt = BLCustomer.CheckCustomer("CNIC", txtCnic.Text);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtContact.Text + " is already Exist");
                        }
                        else if (dtt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtCnic.Text + " is already Exist");
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                string Gender;
                                BLCustomer obj = new BLCustomer();
                                obj.customername = txtCustomerName.Text;
                                obj.contact = txtContact.Text;
                                obj.cnic = txtCnic.Text;
                                obj.address = txtAddress.Text;
                                obj.status = ddlStatus.Text;
                                obj.type = ddlCustomerType.Text;
                                obj.age = Convert.ToInt32(txtAge.Text);
                                obj.weight = Convert.ToInt32(txtWeight.Text);
                                if (rdoMale.Checked == true)
                                {
                                    Gender = "Male";
                                }
                                else if (rdoFemale.Checked == true)
                                {
                                    Gender = "Female";
                                }
                                else
                                {
                                    Gender = "Other";
                                }
                                obj.gender = Gender;
                                obj.trainerid = Convert.ToInt32(ddlTrainerName.SelectedValue);
                                if (BLCustomer.Save(obj) == 1)
                                {
                                    MessageBox.Show("Inserted successfully");
                                    BLLog log = new BLLog();
                                    log.UserId = FrmLogin.UserId;
                                    log.Log = "This User:" + FrmLogin.UserName + " is created This Customer:'" + txtCustomerName.Text + "' SuccessFully";
                                    log.dateTime = DateTime.Now;
                                    BLLog.Save(log);
                                    FrmMachineUse frmMachineUse = new FrmMachineUse();
                                    frmMachineUse.ShowDialog();
                                }
                                FrmCustomerList.ID = 0;
                                txtCustomerName.Text = "";
                                txtContact.Text = "";
                                txtCnic.Text = "";
                                txtAddress.Text = "";
                                ddlStatus.Text = "";
                                ddlCustomerType.Text = "";
                                txtAge.Text = "";
                                txtWeight.Text = "";
                                rdoMale.Checked = rdoFemale.Checked = rdoOther.Checked = false;
                                ddlTrainerName.SelectedIndex = 0;
                                ddlCustomerType.Items.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Record is  not inserted");
                            }
                        }
                    }
                }
            }
        }
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "")
            {
                lblCustomerName.Text = "";
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.TextLength > 10)
            {
                lblContact.Text = "Invalid Contact";
            }
            if (txtContact.Text != "")
            {
                lblContact.Text = "";
            }

        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            if (txtCnic.Text != "")
            {
                lblCnic.Text = "";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                lblAddress.Text = "";
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            if (ddlStatus.Text != "")
            {
                lblStatus.Text = "";
            }
        }

        private void ddlCustomerType_TextChanged(object sender, EventArgs e)
        {
            if (ddlCustomerType.Text != "")
            {
                lblType.Text = "";
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (txtAge.Text != "")
            {
                lblAge.Text = "";
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtWeight.Text != "")
            {
                lblWeight.Text = "";
            }
        }

        private void btnCostumerList_Click(object sender, EventArgs e)
        {
            FrmCustomerList obj = new FrmCustomerList();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            if ((txtContact.TextLength > 10) & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            if ((txtCnic.TextLength > 12) & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMale.Checked==true)
            {
                lblGender.Text = "";
            }
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFemale.Checked==true)
            {
                lblGender.Text = "";
            }
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOther.Checked==true)
            {
                lblGender.Text = "";
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblmain_Click(object sender, EventArgs e)
        {
            FrmMain frm= new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
