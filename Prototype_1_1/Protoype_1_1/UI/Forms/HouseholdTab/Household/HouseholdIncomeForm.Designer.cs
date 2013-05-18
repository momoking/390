namespace Prototype1_1.UI
{
    partial class FormHouseholdIncome
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
            this.dgvIncomes = new System.Windows.Forms.DataGridView();
            this.FirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeTypeCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IncomePeriodCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IncomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAnnualTotalIncome = new System.Windows.Forms.Label();
            this.txtHouseholdIncome = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncomes
            // 
            this.dgvIncomes.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameCol,
            this.MCareCol,
            this.IncomeTypeCol,
            this.IncomePeriodCol,
            this.IncomeCol});
            this.dgvIncomes.GridColor = System.Drawing.Color.Black;
            this.dgvIncomes.Location = new System.Drawing.Point(15, 58);
            this.dgvIncomes.Name = "dgvIncomes";
            this.dgvIncomes.RowHeadersVisible = false;
            this.dgvIncomes.Size = new System.Drawing.Size(642, 276);
            this.dgvIncomes.TabIndex = 0;
            // 
            // FirstNameCol
            // 
            this.FirstNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstNameCol.HeaderText = "First Name";
            this.FirstNameCol.Name = "FirstNameCol";
            // 
            // MCareCol
            // 
            this.MCareCol.HeaderText = "Medicare";
            this.MCareCol.Name = "MCareCol";
            this.MCareCol.Width = 120;
            // 
            // IncomeTypeCol
            // 
            this.IncomeTypeCol.HeaderText = "Income Type";
            this.IncomeTypeCol.Name = "IncomeTypeCol";
            this.IncomeTypeCol.Width = 150;
            // 
            // IncomePeriodCol
            // 
            this.IncomePeriodCol.HeaderText = "Period";
            this.IncomePeriodCol.Name = "IncomePeriodCol";
            // 
            // IncomeCol
            // 
            this.IncomeCol.HeaderText = "Yearly Income";
            this.IncomeCol.Name = "IncomeCol";
            // 
            // lblAnnualTotalIncome
            // 
            this.lblAnnualTotalIncome.AutoSize = true;
            this.lblAnnualTotalIncome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnualTotalIncome.Location = new System.Drawing.Point(15, 23);
            this.lblAnnualTotalIncome.Name = "lblAnnualTotalIncome";
            this.lblAnnualTotalIncome.Size = new System.Drawing.Size(129, 17);
            this.lblAnnualTotalIncome.TabIndex = 2;
            this.lblAnnualTotalIncome.Text = "Annual Total Income";
            // 
            // txtHouseholdIncome
            // 
            this.txtHouseholdIncome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseholdIncome.Location = new System.Drawing.Point(158, 20);
            this.txtHouseholdIncome.Name = "txtHouseholdIncome";
            this.txtHouseholdIncome.ReadOnly = true;
            this.txtHouseholdIncome.Size = new System.Drawing.Size(129, 22);
            this.txtHouseholdIncome.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(15, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(537, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormHouseholdIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 407);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHouseholdIncome);
            this.Controls.Add(this.lblAnnualTotalIncome);
            this.Controls.Add(this.dgvIncomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHouseholdIncome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Household Income";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncomes;
        private System.Windows.Forms.Label lblAnnualTotalIncome;
        private System.Windows.Forms.TextBox txtHouseholdIncome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCareCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn IncomeTypeCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn IncomePeriodCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeCol;
    }
}