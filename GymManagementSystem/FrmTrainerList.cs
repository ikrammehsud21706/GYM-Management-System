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
    public partial class FrmTrainerList : Form
    {
        public FrmTrainerList()
        {
            InitializeComponent();
            if (FrmLogin.Role == "Operator")
            {
                dgvTrainerList.Columns[0].Visible = false;
                dgvTrainerList.Columns[1].Visible = false;
            }
            dgvTrainerList.DataSource = BLTrainer.GetData();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            dgvTrainerList.DataSource = BLTrainer.Searching("Contact", txtContact.Text);
        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            dgvTrainerList.DataSource = BLTrainer.Searching("CNIC", txtCNIC.Text);
        }
        private void btnTrainerList_Click(object sender, EventArgs e)
        {
            FrmTrainer obj = new FrmTrainer();
            this.Hide();
            obj.ShowDialog();
        }
        public static int ID;
        public static string trainername, contact, cnic, address, status, type, gender;

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            FrmMain obj = new FrmMain();
            this.Hide();
            obj.ShowDialog();
        }

        private void txtTrainerName_TextChanged(object sender, EventArgs e)
        {
            dgvTrainerList.DataSource = BLTrainer.Searching("TrainerName", txtTrainerName.Text);
        }

        private void txtCNIC_Click(object sender, EventArgs e)
        {
            if (txtCNIC.Text == "Search CNIC")
            {
                txtCNIC.Text = "";
                txtCNIC.ForeColor = Color.Black;
            }
        }

        private void txtContact_Click(object sender, EventArgs e)
        {
            if (txtContact.Text == "Search Contact")
            {
                txtContact.Text = "";
                txtContact.ForeColor = Color.Black;
            }
        }

        private void txtTrainerName_Click(object sender, EventArgs e)
        {
            if (txtTrainerName.Text == "Search TrainerName")
            {
                txtTrainerName.Text = "";
                txtTrainerName.ForeColor = Color.Black;
            }
        }

        private void dgvTrainerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgvTrainerList.Rows[e.RowIndex].Cells["TrainerID"].Value);
            if (e.ColumnIndex == 0)
            {
                trainername = "" + dgvTrainerList.Rows[e.RowIndex].Cells["TrainerName"].Value;
                contact = "" + dgvTrainerList.Rows[e.RowIndex].Cells["Contact"].Value;
                cnic = "" + dgvTrainerList.Rows[e.RowIndex].Cells["CNIC"].Value;
                address = "" + dgvTrainerList.Rows[e.RowIndex].Cells["Address"].Value;
                status = "" + dgvTrainerList.Rows[e.RowIndex].Cells["Status"].Value;
                type = "" + dgvTrainerList.Rows[e.RowIndex].Cells["Type"].Value;
                gender = "" + dgvTrainerList.Rows[e.RowIndex].Cells["Gender"].Value;
                FrmTrainer obj = new FrmTrainer();
                this.Hide();
                obj.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int check = BLTrainer.Delete(ID);
                    if (check > 0)
                    {
                        MessageBox.Show("Record Deleted");
                        dgvTrainerList.DataSource = BLTrainer.GetData();
                        BLLog log = new BLLog();
                        log.UserId = FrmLogin.UserId;
                        log.Log = "This User '" + FrmLogin.UserName + "' has deleted the Trainer '" + trainername + "'";
                        log.dateTime = DateTime.Now;
                        BLLog.Save(log);
                    }
                }
            }
        }
    }
}
