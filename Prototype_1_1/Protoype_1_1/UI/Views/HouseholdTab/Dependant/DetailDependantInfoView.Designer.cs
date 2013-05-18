namespace Prototype1_1.UI.Views.HouseholdTab.Dependant
{
    partial class DetailDependantInfoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDependantDetail = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FirstnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkstatusCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependantDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDependantDetail
            // 
            this.dgvDependantDetail.AllowUserToAddRows = false;
            this.dgvDependantDetail.AllowUserToDeleteRows = false;
            this.dgvDependantDetail.AllowUserToOrderColumns = true;
            this.dgvDependantDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependantDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstnameCol,
            this.LastnameCol,
            this.MCareCol,
            this.GenderCol,
            this.WorkstatusCol});
            this.dgvDependantDetail.Location = new System.Drawing.Point(10, 9);
            this.dgvDependantDetail.Name = "dgvDependantDetail";
            this.dgvDependantDetail.ReadOnly = true;
            this.dgvDependantDetail.RowHeadersVisible = false;
            this.dgvDependantDetail.Size = new System.Drawing.Size(595, 294);
            this.dgvDependantDetail.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FirstnameCol
            // 
            this.FirstnameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstnameCol.HeaderText = "First Name";
            this.FirstnameCol.Name = "FirstnameCol";
            this.FirstnameCol.ReadOnly = true;
            // 
            // LastnameCol
            // 
            this.LastnameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastnameCol.HeaderText = "Last Name";
            this.LastnameCol.Name = "LastnameCol";
            this.LastnameCol.ReadOnly = true;
            // 
            // MCareCol
            // 
            this.MCareCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MCareCol.HeaderText = "Medicare #";
            this.MCareCol.MinimumWidth = 20;
            this.MCareCol.Name = "MCareCol";
            this.MCareCol.ReadOnly = true;
            // 
            // GenderCol
            // 
            this.GenderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GenderCol.HeaderText = "Gender";
            this.GenderCol.Name = "GenderCol";
            this.GenderCol.ReadOnly = true;
            // 
            // WorkstatusCol
            // 
            this.WorkstatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkstatusCol.HeaderText = "Work Status";
            this.WorkstatusCol.Name = "WorkstatusCol";
            this.WorkstatusCol.ReadOnly = true;
            // 
            // DetailDependantInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvDependantDetail);
            this.Name = "DetailDependantInfoView";
            this.Size = new System.Drawing.Size(613, 313);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependantDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDependantDetail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn WorkstatusCol;

    }
}
