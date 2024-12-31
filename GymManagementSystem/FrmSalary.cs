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
    public partial class FrmSalary : Form
    {
        public FrmSalary()
        {
            InitializeComponent();
            LoadTrainer();
            if (FrmSalaryList.ID > 0)
            {
                ddlTrainerName.SelectedValue = FrmSalaryList.TrainerId;
            }
           
            txtAmount.Text = FrmSalaryList.Amount;
            dateTimePicker1.Text = "" + FrmSalaryList.Date;
            FrmSalaryList.Amount = "";
            FrmSalaryList.TrainerId = 0;
        }
        public void LoadTrainer()
        {
            ddlTrainerName.DataSource = BLTrainer.GetData();
            ddlTrainerName.DisplayMember = "TrainerName";
            ddlTrainerName.ValueMember = "TrainerId";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ddlTrainerName.Text == "")
            {
                lblTrainerId.Text = "Required";
            }
            else if (txtPerHeadAmount.Text == "")
            {
                lblPerHeadAmount.Text = "Required";
            }
            else if (txtAmount.Text == "")
            {
                lblAmount.Text = "Required";
            }
            else if (dateTimePicker1.Text == "")
            {
                lblDate.Text = "Required";
            }
            else
            {
                if (FrmSalaryList.ID > 0)
                {
                    BLSalary obj = new BLSalary();
                    obj.Amount = txtAmount.Text;
                    obj.Date = dateTimePicker1.Value.ToString("Y");
                    obj.TrainerId = Convert.ToInt32(ddlTrainerName.SelectedValue);
                    obj.SalaryId = FrmSalaryList.ID;
                    if (BLSalary.Update(obj) == 1)
                    {
                        MessageBox.Show("Updated successfully");
                        BLLog log = new BLLog();
                        log.UserId = FrmLogin.UserId;
                        log.Log = "This User:" + FrmLogin.UserName + " Updated salary of Trainer:'" + ddlTrainerName.Text + "' SuccessFully";
                        log.dateTime = DateTime.Now;
                        BLLog.Save(log);
                    }
                    txtAmount.Text = "";
                    dateTimePicker1.Text = "";
                    FrmSalaryList.ID = 0;
                }
                else
                {
                    BLSalary obj = new BLSalary();
                    obj.Amount = txtAmount.Text;
                    obj.Date = dateTimePicker1.Value.ToString("Y");
                    obj.TrainerId = Convert.ToInt32(ddlTrainerName.SelectedValue);
                    if (BLSalary.Save(obj) == 1)
                    {
                        MessageBox.Show("Inserted successfully");
                        BLLog log = new BLLog();
                        log.UserId = FrmLogin.UserId;
                        log.Log = "This User:" + FrmLogin.UserName + " Inserted salary of Trainer:'" + ddlTrainerName.Text + "' SuccessFully";
                        log.dateTime = DateTime.Now;
                        BLLog.Save(log);
                       
                    }
                    MessageBox.Show("Salary Inserted");
                    txtAmount.Text = "";
                    dateTimePicker1.Text = "";
                    FrmSalaryList.ID = 0;
                }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                lblAmount.Text = "";
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "")
            {
                lblDate.Text = "";
            }
        }

        private void btnSalaryList_Click(object sender, EventArgs e)
        {
            FrmSalaryList obj = new FrmSalaryList();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkRed;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkRed;
        }

        private void btnSalaryList_MouseEnter(object sender, EventArgs e)
        {
            btnSalaryList.BackColor = Color.DarkRed;
        }

        private void btnSalaryList_MouseLeave(object sender, EventArgs e)
        {
            btnSalaryList.BackColor = Color.DarkRed;
        }

        private void ddlTrainerName_Click(object sender, EventArgs e)
        {
            ddlTrainerName.DataSource = BLTrainer.GetData();
            ddlTrainerName.DisplayMember = "TrainerName";
            ddlTrainerName.ValueMember = "TrainerId";
        }

        private void ddlTrainerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Salary =Convert.ToInt32(txtPerHeadAmount.Text);
            int SelectedTrainerId = Convert.ToInt32(ddlTrainerName.SelectedValue);
            DataTable dt = BLTrainer.GetData(SelectedTrainerId);
            string Type = "" + dt.Rows[0]["Type"];
            if (Type == "Personal Trainer")
            {
                dt = BLCustomer.GetCustomersForTrainerId(SelectedTrainerId);
                Salary += dt.Rows.Count * 2000;
                txtAmount.Text = Convert.ToString(Salary);
                Salary = 0;
            }
            else if (Type == "General Trainer")
            {
                dt = BLCustomer.GetCustomersForTrainerId(SelectedTrainerId);
                Salary += dt.Rows.Count * 1000;
                txtAmount.Text = Convert.ToString(Salary);
                Salary = 0;
            }
        }

      

        private void lblmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain frm=new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
