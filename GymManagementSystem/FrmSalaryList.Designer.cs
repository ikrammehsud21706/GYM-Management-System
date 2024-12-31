namespace GymManagementSystem
{
    partial class FrmSalaryList
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
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.dgvSalaryList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtUnPaidTrainer = new System.Windows.Forms.DateTimePicker();
            this.ddlPaidC = new System.Windows.Forms.Label();
            this.dtPaidTrainer = new System.Windows.Forms.DateTimePicker();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddSalary.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSalary.Location = new System.Drawing.Point(898, 5);
            this.btnAddSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(206, 52);
            this.btnAddSalary.TabIndex = 40;
            this.btnAddSalary.Text = "Add Salary";
            this.btnAddSalary.UseVisualStyleBackColor = false;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // dgvSalaryList
            // 
            this.dgvSalaryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaryList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSalaryList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSalaryList.Location = new System.Drawing.Point(0, 286);
            this.dgvSalaryList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSalaryList.Name = "dgvSalaryList";
            this.dgvSalaryList.RowHeadersWidth = 62;
            this.dgvSalaryList.Size = new System.Drawing.Size(1122, 506);
            this.dgvSalaryList.TabIndex = 39;
            this.dgvSalaryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Image = global::GymManagementSystem.Properties.Resources.icons8_edit_property_50px;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Image = global::GymManagementSystem.Properties.Resources.icons8_delete_512px;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerName.ForeColor = System.Drawing.Color.Gray;
            this.txtTrainerName.Location = new System.Drawing.Point(18, 130);
            this.txtTrainerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(320, 30);
            this.txtTrainerName.TabIndex = 44;
            this.txtTrainerName.Text = "Search TrainerName";
            this.txtTrainerName.Click += new System.EventHandler(this.txtTrainerName_Click);
            this.txtTrainerName.TextChanged += new System.EventHandler(this.txtSalaryId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Search Unpaid Trainer";
            // 
            // dtUnPaidTrainer
            // 
            this.dtUnPaidTrainer.CustomFormat = "MMMM/yyyy";
            this.dtUnPaidTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtUnPaidTrainer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtUnPaidTrainer.Location = new System.Drawing.Point(630, 125);
            this.dtUnPaidTrainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtUnPaidTrainer.Name = "dtUnPaidTrainer";
            this.dtUnPaidTrainer.Size = new System.Drawing.Size(265, 30);
            this.dtUnPaidTrainer.TabIndex = 48;
            this.dtUnPaidTrainer.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dtUnPaidTrainer.ValueChanged += new System.EventHandler(this.dtUnPaidTrainer_ValueChanged);
            // 
            // ddlPaidC
            // 
            this.ddlPaidC.AutoSize = true;
            this.ddlPaidC.BackColor = System.Drawing.Color.Transparent;
            this.ddlPaidC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPaidC.Location = new System.Drawing.Point(350, 96);
            this.ddlPaidC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ddlPaidC.Name = "ddlPaidC";
            this.ddlPaidC.Size = new System.Drawing.Size(186, 25);
            this.ddlPaidC.TabIndex = 47;
            this.ddlPaidC.Text = "Search Paid Trainer";
            // 
            // dtPaidTrainer
            // 
            this.dtPaidTrainer.CustomFormat = "MMMM/yyyy";
            this.dtPaidTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPaidTrainer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPaidTrainer.Location = new System.Drawing.Point(350, 125);
            this.dtPaidTrainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPaidTrainer.Name = "dtPaidTrainer";
            this.dtPaidTrainer.Size = new System.Drawing.Size(270, 30);
            this.dtPaidTrainer.TabIndex = 46;
            this.dtPaidTrainer.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dtPaidTrainer.ValueChanged += new System.EventHandler(this.dtPaidTrainer_ValueChanged);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackToMain.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMain.Location = new System.Drawing.Point(898, 69);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(206, 52);
            this.btnBackToMain.TabIndex = 50;
            this.btnBackToMain.Text = "Back To Main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // FrmSalaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 792);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtUnPaidTrainer);
            this.Controls.Add(this.ddlPaidC);
            this.Controls.Add(this.dtPaidTrainer);
            this.Controls.Add(this.txtTrainerName);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.dgvSalaryList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSalaryList";
            this.Text = "FrmSalaryList";
            this.Load += new System.EventHandler(this.FrmSalaryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSalary;
        private System.Windows.Forms.DataGridView dgvSalaryList;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtUnPaidTrainer;
        private System.Windows.Forms.Label ddlPaidC;
        private System.Windows.Forms.DateTimePicker dtPaidTrainer;
        private System.Windows.Forms.Button btnBackToMain;
    }
}