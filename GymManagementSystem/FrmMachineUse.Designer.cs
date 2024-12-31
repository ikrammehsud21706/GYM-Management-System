namespace GymManagementSystem
{
    partial class FrmMachineUse
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
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.ddlMachineName = new System.Windows.Forms.ComboBox();
            this.ddlTime = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnMachineUseList = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmain = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Active",
            "InActive",
            "UnderConstructor"});
            this.ddlStatus.Location = new System.Drawing.Point(556, 303);
            this.ddlStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(343, 37);
            this.ddlStatus.TabIndex = 3;
            this.ddlStatus.SelectedIndexChanged += new System.EventHandler(this.ddlStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 80;
            this.label2.Text = "Machine Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 83;
            this.label3.Text = "Time";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(738, 465);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 52);
            this.btnSubmit.TabIndex = 82;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 29);
            this.label8.TabIndex = 81;
            this.label8.Text = "Status";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerName.Location = new System.Drawing.Point(906, 137);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 25);
            this.lblCustomerName.TabIndex = 84;
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.BackColor = System.Drawing.Color.Transparent;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMachineName.Location = new System.Drawing.Point(904, 222);
            this.lblMachineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(0, 25);
            this.lblMachineName.TabIndex = 85;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(906, 306);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 86;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(906, 395);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 25);
            this.lblTime.TabIndex = 87;
            // 
            // ddlMachineName
            // 
            this.ddlMachineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMachineName.FormattingEnabled = true;
            this.ddlMachineName.Items.AddRange(new object[] {
            "Active",
            "InActive",
            "OnLeave"});
            this.ddlMachineName.Location = new System.Drawing.Point(556, 218);
            this.ddlMachineName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlMachineName.Name = "ddlMachineName";
            this.ddlMachineName.Size = new System.Drawing.Size(343, 37);
            this.ddlMachineName.TabIndex = 89;
            this.ddlMachineName.SelectedIndexChanged += new System.EventHandler(this.ddlMachineName_SelectedIndexChanged);
            // 
            // ddlTime
            // 
            this.ddlTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTime.FormattingEnabled = true;
            this.ddlTime.Items.AddRange(new object[] {
            "7:00 To 7:45 AM",
            "7:45 To 8:15 AM",
            "8:15 To 9:00 AM",
            "9:00 To 45AM",
            "9:45 To 10:15 AM",
            "10:15 To 11:00 AM",
            "11:00 To 11:45 AM",
            "11:45 To 12:15 PM",
            "12:15 To 1:00 PM",
            "1:00 To 1:45 PM",
            "1:45 To 2:15 PM",
            "2:15 To 3:00 PM",
            "3:00 To 3:45 PM",
            "3:45 To 4:15 PM",
            "4:15 To 5:00 PM"});
            this.ddlTime.Location = new System.Drawing.Point(555, 395);
            this.ddlTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlTime.Name = "ddlTime";
            this.ddlTime.Size = new System.Drawing.Size(344, 37);
            this.ddlTime.TabIndex = 90;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(555, 137);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(340, 33);
            this.txtCustomerName.TabIndex = 91;
            // 
            // btnMachineUseList
            // 
            this.btnMachineUseList.BackColor = System.Drawing.Color.DarkRed;
            this.btnMachineUseList.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineUseList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMachineUseList.Location = new System.Drawing.Point(556, 465);
            this.btnMachineUseList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMachineUseList.Name = "btnMachineUseList";
            this.btnMachineUseList.Size = new System.Drawing.Size(160, 52);
            this.btnMachineUseList.TabIndex = 92;
            this.btnMachineUseList.Text = "List";
            this.btnMachineUseList.UseVisualStyleBackColor = false;
            this.btnMachineUseList.Click += new System.EventHandler(this.btnMachineUseList_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddCustomer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCustomer.Location = new System.Drawing.Point(555, 537);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(340, 52);
            this.btnAddCustomer.TabIndex = 95;
            this.btnAddCustomer.Text = "Go to Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.panel1.Size = new System.Drawing.Size(480, 634);
            this.panel1.TabIndex = 94;
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.BackColor = System.Drawing.Color.Transparent;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.Black;
            this.lblmain.LinkColor = System.Drawing.Color.Red;
            this.lblmain.Location = new System.Drawing.Point(994, 19);
            this.lblmain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(115, 25);
            this.lblmain.TabIndex = 96;
            this.lblmain.TabStop = true;
            this.lblmain.Text = "Go To Main";
            this.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblmain_LinkClicked);
            // 
            // FrmMachineUse
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1122, 634);
            this.Controls.Add(this.lblmain);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMachineUseList);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.ddlTime);
            this.Controls.Add(this.ddlMachineName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMachineUse";
            this.Text = "FrmMachineUse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox ddlMachineName;
        private System.Windows.Forms.ComboBox ddlTime;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnMachineUseList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.LinkLabel lblmain;
    }
}