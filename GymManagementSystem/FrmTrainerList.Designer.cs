namespace GymManagementSystem
{
    partial class FrmTrainerList
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
            this.dgvTrainerList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.btnTrainerList = new System.Windows.Forms.Button();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainerList
            // 
            this.dgvTrainerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainerList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTrainerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTrainerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTrainerList.Location = new System.Drawing.Point(0, 241);
            this.dgvTrainerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTrainerList.Name = "dgvTrainerList";
            this.dgvTrainerList.RowHeadersWidth = 62;
            this.dgvTrainerList.Size = new System.Drawing.Size(1122, 551);
            this.dgvTrainerList.TabIndex = 0;
            this.dgvTrainerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainerList_CellContentClick);
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
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.Silver;
            this.txtContact.Location = new System.Drawing.Point(25, 60);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(316, 30);
            this.txtContact.TabIndex = 2;
            this.txtContact.Text = "Search Contact";
            this.txtContact.Click += new System.EventHandler(this.txtContact_Click);
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtCNIC
            // 
            this.txtCNIC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNIC.ForeColor = System.Drawing.Color.Silver;
            this.txtCNIC.Location = new System.Drawing.Point(378, 60);
            this.txtCNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(320, 30);
            this.txtCNIC.TabIndex = 4;
            this.txtCNIC.Text = "Search CNIC";
            this.txtCNIC.Click += new System.EventHandler(this.txtCNIC_Click);
            this.txtCNIC.TextChanged += new System.EventHandler(this.txtCNIC_TextChanged);
            // 
            // btnTrainerList
            // 
            this.btnTrainerList.BackColor = System.Drawing.Color.DarkRed;
            this.btnTrainerList.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainerList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrainerList.Location = new System.Drawing.Point(917, 14);
            this.btnTrainerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrainerList.Name = "btnTrainerList";
            this.btnTrainerList.Size = new System.Drawing.Size(192, 52);
            this.btnTrainerList.TabIndex = 30;
            this.btnTrainerList.Text = "Add Trainer";
            this.btnTrainerList.UseVisualStyleBackColor = false;
            this.btnTrainerList.Click += new System.EventHandler(this.btnTrainerList_Click);
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerName.ForeColor = System.Drawing.Color.Silver;
            this.txtTrainerName.Location = new System.Drawing.Point(25, 14);
            this.txtTrainerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(316, 30);
            this.txtTrainerName.TabIndex = 31;
            this.txtTrainerName.Text = "Search TrainerName";
            this.txtTrainerName.Click += new System.EventHandler(this.txtTrainerName_Click);
            this.txtTrainerName.TextChanged += new System.EventHandler(this.txtTrainerName_TextChanged);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackToMain.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToMain.Location = new System.Drawing.Point(897, 75);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(212, 52);
            this.btnBackToMain.TabIndex = 32;
            this.btnBackToMain.Text = "Back to Main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // FrmTrainerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 792);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.txtTrainerName);
            this.Controls.Add(this.btnTrainerList);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.dgvTrainerList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTrainerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrainerList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainerList;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Button btnTrainerList;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.Button btnBackToMain;
    }
}