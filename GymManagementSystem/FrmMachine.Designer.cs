namespace GymManagementSystem
{
    partial class FrmMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMachineList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblmain = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtMachineName
            // 
            this.txtMachineName.BackColor = System.Drawing.Color.White;
            this.txtMachineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.ForeColor = System.Drawing.Color.Black;
            this.txtMachineName.Location = new System.Drawing.Point(531, 140);
            this.txtMachineName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMachineName.Multiline = true;
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(348, 32);
            this.txtMachineName.TabIndex = 1;
            this.txtMachineName.TextChanged += new System.EventHandler(this.txtMachineName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(531, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "MachineName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Machine Status";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(717, 373);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 51);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMachineList
            // 
            this.btnMachineList.BackColor = System.Drawing.Color.DarkRed;
            this.btnMachineList.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineList.ForeColor = System.Drawing.Color.White;
            this.btnMachineList.Location = new System.Drawing.Point(536, 373);
            this.btnMachineList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMachineList.Name = "btnMachineList";
            this.btnMachineList.Size = new System.Drawing.Size(156, 51);
            this.btnMachineList.TabIndex = 10;
            this.btnMachineList.Text = "List";
            this.btnMachineList.UseVisualStyleBackColor = false;
            this.btnMachineList.Click += new System.EventHandler(this.btnMachineList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.BackgroundImage = global::GymManagementSystem.Properties.Resources._941314e48a340eac6a1d534e1971baa72;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 661);
            this.panel1.TabIndex = 93;
            // 
            // ddlStatus
            // 
            this.ddlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Active",
            "InActive",
            "Construction"});
            this.ddlStatus.Location = new System.Drawing.Point(531, 257);
            this.ddlStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(346, 37);
            this.ddlStatus.TabIndex = 94;
            this.ddlStatus.SelectedIndexChanged += new System.EventHandler(this.ddlStatus_SelectedIndexChanged);
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.BackColor = System.Drawing.Color.Transparent;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMachineName.Location = new System.Drawing.Point(888, 140);
            this.lblMachineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(0, 29);
            this.lblMachineName.TabIndex = 95;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatus.Location = new System.Drawing.Point(888, 262);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 29);
            this.lblStatus.TabIndex = 96;
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.BackColor = System.Drawing.Color.Transparent;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.Black;
            this.lblmain.LinkColor = System.Drawing.Color.Red;
            this.lblmain.Location = new System.Drawing.Point(994, 21);
            this.lblmain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(115, 25);
            this.lblmain.TabIndex = 97;
            this.lblmain.TabStop = true;
            this.lblmain.Text = "Go To Main";
            this.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblmain_LinkClicked);
            // 
            // FrmMachine
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 661);
            this.Controls.Add(this.lblmain);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMachineList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMachineList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.LinkLabel lblmain;
    }
}