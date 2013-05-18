namespace Prototype1_1.UI.Views.HouseholdTab.Income
{
    partial class IncomeInfoView
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
            this.grbIncome = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.FistNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IncomePeriodColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIncome
            // 
            this.grbIncome.Controls.Add(this.txtIncome);
            this.grbIncome.Controls.Add(this.label1);
            this.grbIncome.Controls.Add(this.dgvIncome);
            this.grbIncome.Location = new System.Drawing.Point(3, 16);
            this.grbIncome.Name = "grbIncome";
            this.grbIncome.Size = new System.Drawing.Size(437, 306);
            this.grbIncome.TabIndex = 0;
            this.grbIncome.TabStop = false;
            this.grbIncome.Text = "Income information";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(346, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 38);
            this.btnCancel.TabIndex = 149;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 38);
            this.btnSave.TabIndex = 148;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvIncome
            // 
            this.dgvIncome.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FistNameColumn,
            this.IncomePeriodColumn,
            this.AmountColumn});
            this.dgvIncome.Location = new System.Drawing.Point(6, 19);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersVisible = false;
            this.dgvIncome.Size = new System.Drawing.Size(425, 230);
            this.dgvIncome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Household Income";
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(331, 269);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.ReadOnly = true;
            this.txtIncome.Size = new System.Drawing.Size(100, 20);
            this.txtIncome.TabIndex = 2;
            // 
            // FistNameColumn
            // 
            this.FistNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FistNameColumn.HeaderText = "First Name";
            this.FistNameColumn.Name = "FistNameColumn";
            // 
            // IncomePeriodColumn
            // 
            this.IncomePeriodColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IncomePeriodColumn.HeaderText = "Income Period";
            this.IncomePeriodColumn.Name = "IncomePeriodColumn";
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            // 
            // IncomeInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbIncome);
            this.Name = "IncomeInfoView";
            this.Size = new System.Drawing.Size(443, 395);
            this.grbIncome.ResumeLayout(false);
            this.grbIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIncome;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIncome;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn FistNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn IncomePeriodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    }
}
