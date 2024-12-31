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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void PnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PnClose_MouseEnter(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.DarkRed;
            PnClose.BackgroundImage = GymManagementSystem.Properties.Resources.WhiteIcon;
        }

        private void PnClose_MouseLeave(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.White;
            PnClose.BackgroundImage = GymManagementSystem.Properties.Resources.BlackIcon;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            FrmCustomerList obj = new FrmCustomerList();
            this.Hide();
            obj.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmCustomer obj=new FrmCustomer();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmCustomerList obj = new FrmCustomerList();
            this.Hide();
            obj.ShowDialog();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            FrmLog obj = new FrmLog();
            this.Hide();
            obj.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            FrmLog obj = new FrmLog();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmLog obj = new FrmLog();
            this.Hide();
            obj.ShowDialog();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            FrmLogin obj = new FrmLogin();
            this.Hide();
            obj.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FrmLogin obj = new FrmLogin();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmLogin obj = new FrmLogin();
            this.Hide();
            obj.ShowDialog();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            FrmMachine obj = new FrmMachine();
            this.Hide();
            obj.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmMachine obj = new FrmMachine();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmMachineList obj = new FrmMachineList();
            this.Hide();
            obj.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            FrmUserList obj = new FrmUserList();
            this.Hide();
            obj.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmUserRegistration obj = new FrmUserRegistration();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmUserList obj = new FrmUserList();
            this.Hide();
            obj.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            FrmTrainerList obj = new FrmTrainerList();
            this.Hide();
            obj.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FrmTrainer obj = new FrmTrainer();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmTrainerList obj = new FrmTrainerList();
            this.Hide();
            obj.ShowDialog();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            FrmPaymentList obj=new FrmPaymentList();
            this.Hide();
            obj.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            FrmPayment obj = new FrmPayment();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmPaymentList obj = new FrmPaymentList();
            this.Hide();
            obj.ShowDialog();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            FrmSalaryList obj = new FrmSalaryList();
            this.Hide();
            obj.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            FrmSalary obj = new FrmSalary();
            this.Hide();
            obj.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FrmSalaryList obj = new FrmSalaryList();
            this.Hide();
            obj.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            FrmMachineUse obj=new FrmMachineUse();
            this.Hide();
            obj.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            FrmExpense obj=new FrmExpense();
            this.Hide();
            obj.ShowDialog();
        }

       
    }

}
