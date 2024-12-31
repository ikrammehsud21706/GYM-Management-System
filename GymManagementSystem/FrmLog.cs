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
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
            dgvLog.DataSource = BLLog.GetData();
        }

        private void lblGoToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMain obj= new FrmMain();
            this.Close();   
            obj.ShowDialog();
        }
    }
}
