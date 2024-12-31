namespace GymManagementSystem
{
    partial class FrmMachineList
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
            this.DgvMachineList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMachineList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMachineList
            // 
            this.DgvMachineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMachineList.BackgroundColor = System.Drawing.Color.LightGray;
            this.DgvMachineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMachineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvMachineList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvMachineList.Location = new System.Drawing.Point(0, 157);
            this.DgvMachineList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvMachineList.Name = "DgvMachineList";
            this.DgvMachineList.RowHeadersWidth = 62;
            this.DgvMachineList.Size = new System.Drawing.Size(1200, 535);
            this.DgvMachineList.TabIndex = 660;
            this.DgvMachineList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMachineList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Image = global::GymManagementSystem.Properties.Resources.icons8_google_docs_480px1;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Image = global::GymManagementSystem.Properties.Resources.icons8_delete_512px1;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddMachine.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachine.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMachine.Location = new System.Drawing.Point(988, 37);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(194, 43);
            this.btnAddMachine.TabIndex = 1;
            this.btnAddMachine.Text = "Add Machine";
            this.btnAddMachine.UseVisualStyleBackColor = false;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // txtMachineName
            // 
            this.txtMachineName.BackColor = System.Drawing.Color.White;
            this.txtMachineName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.ForeColor = System.Drawing.Color.Silver;
            this.txtMachineName.Location = new System.Drawing.Point(18, 91);
            this.txtMachineName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(308, 30);
            this.txtMachineName.TabIndex = 662;
            this.txtMachineName.Text = "Search MachineName";
            this.txtMachineName.Click += new System.EventHandler(this.txtMachineName_Click);
            this.txtMachineName.TextChanged += new System.EventHandler(this.txtMachineId_TextChanged);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackToMain.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMain.Location = new System.Drawing.Point(974, 91);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(208, 43);
            this.btnBackToMain.TabIndex = 663;
            this.btnBackToMain.Text = "Back to Main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // FrmMachineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.DgvMachineList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMachineList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMachineList";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMachineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMachineList;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Button btnBackToMain;
    }
}