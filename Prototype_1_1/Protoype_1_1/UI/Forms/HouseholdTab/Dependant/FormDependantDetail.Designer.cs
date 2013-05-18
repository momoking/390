namespace Prototype1_1.UI.Forms
{
    partial class FormDependantDetail
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
            this.dgvDependantDetail = new System.Windows.Forms.DataGridView();
            this.clientInfoView1 = new Prototype1_1.UI.Views.ClientInfoView();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkstatusCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveAsNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependantDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDependantDetail
            // 
            this.dgvDependantDetail.AllowUserToAddRows = false;
            this.dgvDependantDetail.AllowUserToDeleteRows = false;
            this.dgvDependantDetail.AllowUserToOrderColumns = true;
            this.dgvDependantDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDependantDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependantDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstnameCol,
            this.LastnameCol,
            this.MCareCol,
            this.GenderCol,
            this.AgeCol,
            this.WorkstatusCol});
            this.dgvDependantDetail.Location = new System.Drawing.Point(12, 12);
            this.dgvDependantDetail.Name = "dgvDependantDetail";
            this.dgvDependantDetail.ReadOnly = true;
            this.dgvDependantDetail.RowHeadersVisible = false;
            this.dgvDependantDetail.Size = new System.Drawing.Size(595, 172);
            this.dgvDependantDetail.TabIndex = 1;
            // 
            // clientInfoView1
            // 
            this.clientInfoView1.Location = new System.Drawing.Point(49, 222);
            this.clientInfoView1.Name = "clientInfoView1";
            this.clientInfoView1.Size = new System.Drawing.Size(489, 250);
            this.clientInfoView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name ID";
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
            // AgeCol
            // 
            this.AgeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AgeCol.HeaderText = "Age";
            this.AgeCol.Name = "AgeCol";
            this.AgeCol.ReadOnly = true;
            // 
            // WorkstatusCol
            // 
            this.WorkstatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkstatusCol.HeaderText = "Work Status";
            this.WorkstatusCol.Name = "WorkstatusCol";
            this.WorkstatusCol.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(48, 478);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "&UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSaveAsNew
            // 
            this.btnSaveAsNew.BackColor = System.Drawing.Color.White;
            this.btnSaveAsNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAsNew.FlatAppearance.BorderSize = 2;
            this.btnSaveAsNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAsNew.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsNew.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAsNew.Location = new System.Drawing.Point(438, 478);
            this.btnSaveAsNew.Name = "btnSaveAsNew";
            this.btnSaveAsNew.Size = new System.Drawing.Size(100, 35);
            this.btnSaveAsNew.TabIndex = 51;
            this.btnSaveAsNew.Text = "&SAVE AS NEW";
            this.btnSaveAsNew.UseVisualStyleBackColor = false;
            this.btnSaveAsNew.Click += new System.EventHandler(this.btnSaveAsNew_Click);
            // 
            // FormDependantDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 576);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveAsNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientInfoView1);
            this.Controls.Add(this.dgvDependantDetail);
            this.Name = "FormDependantDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dependant Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependantDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDependantDetail;
        private Views.ClientInfoView clientInfoView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn WorkstatusCol;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSaveAsNew;
    }
}