namespace GymManagementSystem
{
    partial class FrmExpenseHeadList
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
            this.dgvExpenseHeadList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddExpenseHead = new System.Windows.Forms.Button();
            this.txtExpenseHead = new System.Windows.Forms.TextBox();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseHeadList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpenseHeadList
            // 
            this.dgvExpenseHeadList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseHeadList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpenseHeadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseHeadList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvExpenseHeadList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvExpenseHeadList.Location = new System.Drawing.Point(0, 258);
            this.dgvExpenseHeadList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvExpenseHeadList.Name = "dgvExpenseHeadList";
            this.dgvExpenseHeadList.RowHeadersWidth = 62;
            this.dgvExpenseHeadList.Size = new System.Drawing.Size(1122, 534);
            this.dgvExpenseHeadList.TabIndex = 0;
            this.dgvExpenseHeadList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseHeadList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Image = global::GymManagementSystem.Properties.Resources.icons8_google_docs_480px3;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Image = global::GymManagementSystem.Properties.Resources.icons8_delete_512px3;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddExpenseHead
            // 
            this.btnAddExpenseHead.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddExpenseHead.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpenseHead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddExpenseHead.Location = new System.Drawing.Point(835, 24);
            this.btnAddExpenseHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddExpenseHead.Name = "btnAddExpenseHead";
            this.btnAddExpenseHead.Size = new System.Drawing.Size(274, 52);
            this.btnAddExpenseHead.TabIndex = 52;
            this.btnAddExpenseHead.Text = "Add ExpenseHead";
            this.btnAddExpenseHead.UseVisualStyleBackColor = false;
            this.btnAddExpenseHead.Click += new System.EventHandler(this.btnAddExpenseHead_Click);
            // 
            // txtExpenseHead
            // 
            this.txtExpenseHead.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenseHead.ForeColor = System.Drawing.Color.Silver;
            this.txtExpenseHead.Location = new System.Drawing.Point(45, 46);
            this.txtExpenseHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpenseHead.Name = "txtExpenseHead";
            this.txtExpenseHead.Size = new System.Drawing.Size(340, 30);
            this.txtExpenseHead.TabIndex = 54;
            this.txtExpenseHead.Text = "Search ExpenseHead";
            this.txtExpenseHead.Click += new System.EventHandler(this.txtExpenseHead_Click);
            this.txtExpenseHead.TextChanged += new System.EventHandler(this.txtExpenseHead_TextChanged);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackToMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.Color.White;
            this.btnBackToMain.Location = new System.Drawing.Point(835, 86);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(274, 49);
            this.btnBackToMain.TabIndex = 55;
            this.btnBackToMain.Text = "Back to Main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // FrmExpenseHeadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 792);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.txtExpenseHead);
            this.Controls.Add(this.btnAddExpenseHead);
            this.Controls.Add(this.dgvExpenseHeadList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExpenseHeadList";
            this.Text = "FrmExpenseHeadList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseHeadList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpenseHeadList;
        private System.Windows.Forms.Button btnAddExpenseHead;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.TextBox txtExpenseHead;
        private System.Windows.Forms.Button btnBackToMain;
    }
}