namespace GymManagementSystem
{
    partial class FrmExpense
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtExpense = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblExpenseHead = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExpenseList = new System.Windows.Forms.Button();
            this.ddlExpenseHead = new System.Windows.Forms.ComboBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexpensehead = new System.Windows.Forms.Button();
            this.lblmain = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(968, 366);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Status";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.BackColor = System.Drawing.Color.Transparent;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExpense.Location = new System.Drawing.Point(968, 206);
            this.lblExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(0, 25);
            this.lblExpense.TabIndex = 56;
            // 
            // txtExpense
            // 
            this.txtExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpense.Location = new System.Drawing.Point(616, 200);
            this.txtExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(340, 33);
            this.txtExpense.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Expense ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(779, 540);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(177, 52);
            this.btnSubmit.TabIndex = 60;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtExpense
            // 
            this.dtExpense.CustomFormat = "MMMM/yyyy";
            this.dtExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpense.Location = new System.Drawing.Point(616, 445);
            this.dtExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtExpense.Name = "dtExpense";
            this.dtExpense.Size = new System.Drawing.Size(340, 33);
            this.dtExpense.TabIndex = 61;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(968, 449);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 25);
            this.lblDate.TabIndex = 62;
            // 
            // lblExpenseHead
            // 
            this.lblExpenseHead.AutoSize = true;
            this.lblExpenseHead.BackColor = System.Drawing.Color.Transparent;
            this.lblExpenseHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExpenseHead.Location = new System.Drawing.Point(968, 120);
            this.lblExpenseHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseHead.Name = "lblExpenseHead";
            this.lblExpenseHead.Size = new System.Drawing.Size(0, 25);
            this.lblExpenseHead.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "ExpenseHead ";
            // 
            // btnExpenseList
            // 
            this.btnExpenseList.BackColor = System.Drawing.Color.DarkRed;
            this.btnExpenseList.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpenseList.Location = new System.Drawing.Point(616, 540);
            this.btnExpenseList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpenseList.Name = "btnExpenseList";
            this.btnExpenseList.Size = new System.Drawing.Size(155, 52);
            this.btnExpenseList.TabIndex = 66;
            this.btnExpenseList.Text = "List";
            this.btnExpenseList.UseVisualStyleBackColor = false;
            this.btnExpenseList.Click += new System.EventHandler(this.btnExpenseList_Click);
            // 
            // ddlExpenseHead
            // 
            this.ddlExpenseHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExpenseHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlExpenseHead.FormattingEnabled = true;
            this.ddlExpenseHead.Location = new System.Drawing.Point(616, 115);
            this.ddlExpenseHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlExpenseHead.Name = "ddlExpenseHead";
            this.ddlExpenseHead.Size = new System.Drawing.Size(340, 37);
            this.ddlExpenseHead.TabIndex = 67;
            this.ddlExpenseHead.SelectionChangeCommitted += new System.EventHandler(this.ddlExpenseHead_SelectionChangeCommitted);
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.ddlStatus.Location = new System.Drawing.Point(616, 363);
            this.ddlStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(340, 37);
            this.ddlStatus.TabIndex = 68;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAmount.Location = new System.Drawing.Point(968, 291);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 25);
            this.lblAmount.TabIndex = 71;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(616, 285);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(340, 33);
            this.txtAmount.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 70;
            this.label6.Text = "Amount";
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
            this.panel1.Size = new System.Drawing.Size(502, 792);
            this.panel1.TabIndex = 92;
            // 
            // btnexpensehead
            // 
            this.btnexpensehead.BackColor = System.Drawing.Color.DarkRed;
            this.btnexpensehead.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexpensehead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexpensehead.Location = new System.Drawing.Point(617, 602);
            this.btnexpensehead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexpensehead.Name = "btnexpensehead";
            this.btnexpensehead.Size = new System.Drawing.Size(339, 52);
            this.btnexpensehead.TabIndex = 93;
            this.btnexpensehead.Text = "ExpenseHead";
            this.btnexpensehead.UseVisualStyleBackColor = false;
            this.btnexpensehead.Click += new System.EventHandler(this.btnexpensehead_Click);
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.BackColor = System.Drawing.Color.Transparent;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.Color.Black;
            this.lblmain.LinkColor = System.Drawing.Color.Red;
            this.lblmain.Location = new System.Drawing.Point(968, 9);
            this.lblmain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(115, 25);
            this.lblmain.TabIndex = 94;
            this.lblmain.TabStop = true;
            this.lblmain.Text = "Go To Main";
            this.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblmain_LinkClicked);
            // 
            // FrmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 792);
            this.Controls.Add(this.lblmain);
            this.Controls.Add(this.btnexpensehead);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.ddlExpenseHead);
            this.Controls.Add(this.btnExpenseList);
            this.Controls.Add(this.lblExpenseHead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtExpense);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtExpense;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblExpenseHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExpenseList;
        private System.Windows.Forms.ComboBox ddlExpenseHead;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexpensehead;
        private System.Windows.Forms.LinkLabel lblmain;
    }
}