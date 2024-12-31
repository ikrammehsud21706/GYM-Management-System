namespace GymManagementSystem
{
    partial class FrmExpenseHead
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
            this.lblExpenseHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExpenseHeadList = new System.Windows.Forms.Button();
            this.ddlExpenseHead = new System.Windows.Forms.ComboBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmain = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblExpenseHead
            // 
            this.lblExpenseHead.AutoSize = true;
            this.lblExpenseHead.BackColor = System.Drawing.Color.Transparent;
            this.lblExpenseHead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExpenseHead.Location = new System.Drawing.Point(1000, 234);
            this.lblExpenseHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseHead.Name = "lblExpenseHead";
            this.lblExpenseHead.Size = new System.Drawing.Size(0, 23);
            this.lblExpenseHead.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Expense Head";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(1000, 340);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 23);
            this.lblStatus.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Status";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(849, 454);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 52);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExpenseHeadList
            // 
            this.btnExpenseHeadList.BackColor = System.Drawing.Color.DarkRed;
            this.btnExpenseHeadList.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseHeadList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpenseHeadList.Location = new System.Drawing.Point(678, 454);
            this.btnExpenseHeadList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpenseHeadList.Name = "btnExpenseHeadList";
            this.btnExpenseHeadList.Size = new System.Drawing.Size(154, 52);
            this.btnExpenseHeadList.TabIndex = 52;
            this.btnExpenseHeadList.Text = "List";
            this.btnExpenseHeadList.UseVisualStyleBackColor = false;
            this.btnExpenseHeadList.Click += new System.EventHandler(this.btnExpenseHeadList_Click);
            // 
            // ddlExpenseHead
            // 
            this.ddlExpenseHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExpenseHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlExpenseHead.FormattingEnabled = true;
            this.ddlExpenseHead.Items.AddRange(new object[] {
            "Salary",
            "Rent",
            "Utility Bills",
            "Food "});
            this.ddlExpenseHead.Location = new System.Drawing.Point(678, 231);
            this.ddlExpenseHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlExpenseHead.Name = "ddlExpenseHead";
            this.ddlExpenseHead.Size = new System.Drawing.Size(312, 37);
            this.ddlExpenseHead.TabIndex = 53;
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.ddlStatus.Location = new System.Drawing.Point(678, 340);
            this.ddlStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(312, 37);
            this.ddlStatus.TabIndex = 54;
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
            this.panel1.Size = new System.Drawing.Size(526, 607);
            this.panel1.TabIndex = 93;
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.BackColor = System.Drawing.Color.Transparent;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.Black;
            this.lblmain.LinkColor = System.Drawing.Color.Red;
            this.lblmain.Location = new System.Drawing.Point(989, 9);
            this.lblmain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(115, 25);
            this.lblmain.TabIndex = 95;
            this.lblmain.TabStop = true;
            this.lblmain.Text = "Go To Main";
            this.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblmain_LinkClicked);
            // 
            // FrmExpenseHead
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 607);
            this.Controls.Add(this.lblmain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.ddlExpenseHead);
            this.Controls.Add(this.btnExpenseHeadList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExpenseHead);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExpenseHead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExpenseHead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpenseHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExpenseHeadList;
        private System.Windows.Forms.ComboBox ddlExpenseHead;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblmain;
    }
}