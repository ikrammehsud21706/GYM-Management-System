namespace GymManagementSystem
{
    partial class FrmMachineUseList
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
            this.dgvMachineUseList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddMachineUse = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnmain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineUseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMachineUseList
            // 
            this.dgvMachineUseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachineUseList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMachineUseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineUseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMachineUseList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMachineUseList.Location = new System.Drawing.Point(0, 224);
            this.dgvMachineUseList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMachineUseList.Name = "dgvMachineUseList";
            this.dgvMachineUseList.RowHeadersWidth = 62;
            this.dgvMachineUseList.Size = new System.Drawing.Size(1122, 568);
            this.dgvMachineUseList.TabIndex = 0;
            this.dgvMachineUseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachineUseList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Image = global::GymManagementSystem.Properties.Resources.icons8_google_docs_480px5;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Image = global::GymManagementSystem.Properties.Resources.icons8_delete_512px5;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddMachineUse
            // 
            this.btnAddMachineUse.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddMachineUse.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachineUse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMachineUse.Location = new System.Drawing.Point(834, 14);
            this.btnAddMachineUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMachineUse.Name = "btnAddMachineUse";
            this.btnAddMachineUse.Size = new System.Drawing.Size(243, 43);
            this.btnAddMachineUse.TabIndex = 94;
            this.btnAddMachineUse.Text = "Add MachineUse";
            this.btnAddMachineUse.UseVisualStyleBackColor = false;
            this.btnAddMachineUse.Click += new System.EventHandler(this.btnAddMachineUse_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.Location = new System.Drawing.Point(25, 65);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(283, 30);
            this.txtCustomerName.TabIndex = 95;
            this.txtCustomerName.Text = "Search CustomerName";
            this.txtCustomerName.Click += new System.EventHandler(this.txtCustomerName_Click);
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged_1);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::GymManagementSystem.Properties.Resources.icons8_google_docs_480px5;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 353;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::GymManagementSystem.Properties.Resources.icons8_delete_512px5;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 352;
            // 
            // btnmain
            // 
            this.btnmain.BackColor = System.Drawing.Color.DarkRed;
            this.btnmain.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnmain.Location = new System.Drawing.Point(834, 65);
            this.btnmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmain.Name = "btnmain";
            this.btnmain.Size = new System.Drawing.Size(243, 43);
            this.btnmain.TabIndex = 96;
            this.btnmain.Text = "Go To Main";
            this.btnmain.UseVisualStyleBackColor = false;
            this.btnmain.Click += new System.EventHandler(this.btnmain_Click);
            // 
            // FrmMachineUseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1122, 792);
            this.Controls.Add(this.btnmain);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnAddMachineUse);
            this.Controls.Add(this.dgvMachineUseList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMachineUseList";
            this.Text = "FrmMachineUseList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineUseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMachineUseList;
        private System.Windows.Forms.Button btnAddMachineUse;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnmain;
    }
}