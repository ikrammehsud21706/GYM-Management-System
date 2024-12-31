namespace GymManagementSystem
{
    partial class FrmPaymentList
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
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgvPaymentList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtPaidCustomer = new System.Windows.Forms.DateTimePicker();
            this.ddlPaidC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDefaulterCustomer = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddPayment.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPayment.Location = new System.Drawing.Point(902, 14);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(206, 52);
            this.btnAddPayment.TabIndex = 38;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            this.btnAddPayment.MouseEnter += new System.EventHandler(this.btnAddPayment_MouseEnter);
            this.btnAddPayment.MouseLeave += new System.EventHandler(this.btnAddPayment_MouseLeave);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Silver;
            this.txtCustomerName.Location = new System.Drawing.Point(36, 84);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 30);
            this.txtCustomerName.TabIndex = 40;
            this.txtCustomerName.Text = "Search CustomerName";
            this.txtCustomerName.Click += new System.EventHandler(this.txtCustomerName_Click);
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtPaymentId_TextChanged);
            // 
            // dgvPaymentList
            // 
            this.dgvPaymentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPaymentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPaymentList.Location = new System.Drawing.Point(0, 261);
            this.dgvPaymentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPaymentList.Name = "dgvPaymentList";
            this.dgvPaymentList.RowHeadersWidth = 62;
            this.dgvPaymentList.Size = new System.Drawing.Size(1122, 531);
            this.dgvPaymentList.TabIndex = 41;
            this.dgvPaymentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Image = global::GymManagementSystem.Properties.Resources.icons8_google_docs_480px4;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Image = global::GymManagementSystem.Properties.Resources.icons8_delete_512px4;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtPaidCustomer
            // 
            this.dtPaidCustomer.CustomFormat = "MMMM/yyyy";
            this.dtPaidCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPaidCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPaidCustomer.Location = new System.Drawing.Point(294, 84);
            this.dtPaidCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPaidCustomer.Name = "dtPaidCustomer";
            this.dtPaidCustomer.Size = new System.Drawing.Size(270, 33);
            this.dtPaidCustomer.TabIndex = 42;
            this.dtPaidCustomer.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dtPaidCustomer.ValueChanged += new System.EventHandler(this.dtPaidCustomer_ValueChanged_1);
            // 
            // ddlPaidC
            // 
            this.ddlPaidC.AutoSize = true;
            this.ddlPaidC.BackColor = System.Drawing.Color.Transparent;
            this.ddlPaidC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPaidC.Location = new System.Drawing.Point(294, 58);
            this.ddlPaidC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ddlPaidC.Name = "ddlPaidC";
            this.ddlPaidC.Size = new System.Drawing.Size(209, 25);
            this.ddlPaidC.TabIndex = 43;
            this.ddlPaidC.Text = "Search Paid Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Search Defaulter Customer";
            // 
            // dtDefaulterCustomer
            // 
            this.dtDefaulterCustomer.CustomFormat = "MMMM/yyyy";
            this.dtDefaulterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDefaulterCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDefaulterCustomer.Location = new System.Drawing.Point(575, 82);
            this.dtDefaulterCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDefaulterCustomer.Name = "dtDefaulterCustomer";
            this.dtDefaulterCustomer.Size = new System.Drawing.Size(265, 33);
            this.dtDefaulterCustomer.TabIndex = 44;
            this.dtDefaulterCustomer.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dtDefaulterCustomer.ValueChanged += new System.EventHandler(this.dtDefaulterCustomer_ValueChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::GymManagementSystem.Properties.Resources.icons8_edit_property_50px;
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
            this.dataGridViewImageColumn2.Image = global::GymManagementSystem.Properties.Resources.icons8_delete_512px;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 352;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackToMain.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMain.Location = new System.Drawing.Point(902, 76);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(206, 52);
            this.btnBackToMain.TabIndex = 46;
            this.btnBackToMain.Text = "Back To Main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // FrmPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 792);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDefaulterCustomer);
            this.Controls.Add(this.ddlPaidC);
            this.Controls.Add(this.dtPaidCustomer);
            this.Controls.Add(this.dgvPaymentList);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnAddPayment);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPaymentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaymentList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvPaymentList;
        private System.Windows.Forms.DateTimePicker dtPaidCustomer;
        private System.Windows.Forms.Label ddlPaidC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDefaulterCustomer;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.Button btnBackToMain;
    }
}