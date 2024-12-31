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
    public partial class FrmTrainer : Form
    {
        public FrmTrainer()
        {
            InitializeComponent();
            txtTrainerName.Text = FrmTrainerList.trainername;
            txtContact.Text = FrmTrainerList.contact;
            txtCnic.Text = FrmTrainerList.cnic;
            txtAddress.Text = FrmTrainerList.address;
            ddlStatus.Text = FrmTrainerList.status;
            ddlTrainerType.Text = FrmTrainerList.type;
            if (FrmTrainerList.gender == "Male")
            {
                rdoMale.Checked = true;
            }
            else if (FrmTrainerList.gender == "Female")
            {
                rdoFemale.Checked = true;
            }
            else
            {
                rdoOther.Checked = true;
            }
            FrmTrainerList.trainername = "";
            FrmTrainerList.contact = "";
            FrmTrainerList.cnic = "";
            FrmTrainerList.address = "";
            FrmTrainerList.status = "";
            FrmTrainerList.gender = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTrainerName.Text == "")
            {
                lblTrainerName.Text = "Required";
            }
            else if (txtContact.Text == "")
            {
                lblContact.Text = "Required";
            }
            else if (txtCnic.Text == "")
            {
                lblCnic.Text = "Required";
            }
            else if (txtAddress.Text == "")
            {
                lblAddress.Text = "Required";
            }
            else if (ddlStatus.Text == "")
            {
                lblStatus.Text = "Required";
            }
            else if (ddlTrainerType.Text == "")
            {
                lblType.Text = "Required";
            }
            else if (rdoMale.Checked == false & rdoFemale.Checked == false & rdoOther.Checked == false)
            {
                lblGender.Text = "Required";
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
                    if (FrmTrainerList.ID > 0)
                    {
                        DataTable dt = BLTrainer.CheckTrainerInUpdate("Contact", txtContact.Text, FrmTrainerList.ID);
                        DataTable dtt = BLTrainer.CheckTrainerInUpdate("CNIC", txtCnic.Text, FrmTrainerList.ID);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtContact.Text + " is already exist");
                        }
                        else if (dtt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtCnic.Text + " is already exist");
                        }
                        else
                        {
                            string Gender;
                            BLTrainer obj = new BLTrainer();
                            obj.trainername = txtTrainerName.Text;
                            obj.contact = txtContact.Text;
                            obj.cnic = txtCnic.Text;
                            obj.address = txtAddress.Text;
                            obj.status = ddlStatus.Text;
                            obj.type = ddlTrainerType.Text;
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
                            obj.trainerid = FrmTrainerList.ID;
                            if (BLTrainer.Update(obj) > 0)
                            {
                                MessageBox.Show("Updated");
                                BLLog log = new BLLog();
                                log.UserId = FrmLogin.UserId;
                                log.Log = "This User '" + FrmLogin.UserName + "' has Updated the Trainer '" + txtTrainerName.Text + "'";
                                log.dateTime = DateTime.Now;
                                BLLog.Save(log);
                            }
                            FrmTrainerList.ID = 0;
                            txtTrainerName.Text = "";
                            txtContact.Text = "";
                            txtCnic.Text = "";
                            txtAddress.Text = "";
                            ddlStatus.Items.Clear();
                            ddlTrainerType.Items.Clear();
                            rdoMale.Checked = rdoFemale.Checked = rdoOther.Checked = false;
                        }
                    }
                    else
                    {
                        DataTable dt = BLTrainer.CheckTrainer("Contact", txtContact.Text);
                        DataTable dtt = BLTrainer.CheckTrainer("CNIC", txtCnic.Text);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtContact.Text + " is already exist");
                        }
                        else if (dtt.Rows.Count > 0)
                        {
                            MessageBox.Show("This " + txtCnic.Text + " is already exist");
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string Gender;
                                BLTrainer obj = new BLTrainer();
                                obj.trainername = txtTrainerName.Text;
                                obj.contact = txtContact.Text;
                                obj.cnic = txtCnic.Text;
                                obj.address = txtAddress.Text;
                                obj.status = ddlStatus.Text;
                                obj.type = ddlTrainerType.Text;
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
                                if (BLTrainer.Save(obj) == 1)
                                {

                                    MessageBox.Show("Inserted");
                                    BLLog log = new BLLog();
                                    log.UserId = FrmLogin.UserId;
                                    log.Log = "This User '" + FrmLogin.UserName + "' has inserted the Trainer '" + txtTrainerName.Text + "'";
                                    log.dateTime = DateTime.Now;
                                    BLLog.Save(log);
                                }
                                FrmTrainerList.ID = 0;
                                txtTrainerName.Text = "";
                                txtContact.Text = "";
                                txtCnic.Text = "";
                                txtAddress.Text = "";
                                ddlStatus.Items.Clear();
                                ddlTrainerType.Items.Clear();
                                rdoMale.Checked = rdoFemale.Checked = rdoOther.Checked = false;

                            }
                            else
                            {
                                MessageBox.Show("Record is not inserted");
                            }
                        }

                    }

                }
            }
        }

        private void txtTrainerName_TextChanged(object sender, EventArgs e)
        {
            if (txtTrainerName.Text != "")
            {
                lblTrainerName.Text = "";
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
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

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 08))
            {
                e.Handled = true;
            }
            if ((txtContact.TextLength == 11) & (e.KeyChar != 08))
            {
                e.Handled = true;
            }
        }

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') & (e.KeyChar != 08))
            {
                e.Handled = true;
            }
            if ((txtCnic.TextLength == 13) & (e.KeyChar != 08))
            {
                e.Handled = true;
            }
        }

        private void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStatus.Text != "")
            {
                lblStatus.Text = "";
            }
        }

        private void btnTrainerList_Click(object sender, EventArgs e)
        {
            FrmTrainerList obj = new FrmTrainerList();
            this.Hide();
            obj.ShowDialog();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMale.Checked == true)
            {
                lblGender.Text = "";
            }
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFemale.Checked == true)
            {
                lblGender.Text = "";
            }
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOther.Checked == true)
            {
                lblGender.Text = "";
            }
        }

        private void lblmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
