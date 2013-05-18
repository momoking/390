namespace Prototype1_1.UI.Views.HouseholdTab.Flag
{
    partial class CreateFlagInfoView
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
            this.rchFlag = new System.Windows.Forms.RichTextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFlagType = new System.Windows.Forms.Label();
            this.cmbFlagType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchFlag
            // 
            this.rchFlag.Location = new System.Drawing.Point(5, 60);
            this.rchFlag.Name = "rchFlag";
            this.rchFlag.Size = new System.Drawing.Size(594, 146);
            this.rchFlag.TabIndex = 151;
            this.rchFlag.Text = "";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy/MM/dd";
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(98, 2);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(117, 22);
            this.dtpDate.TabIndex = 149;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(37, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 150;
            this.lblDate.Text = "Date";
            // 
            // lblFlagType
            // 
            this.lblFlagType.AutoSize = true;
            this.lblFlagType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlagType.Location = new System.Drawing.Point(12, 31);
            this.lblFlagType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlagType.Name = "lblFlagType";
            this.lblFlagType.Size = new System.Drawing.Size(63, 17);
            this.lblFlagType.TabIndex = 147;
            this.lblFlagType.Text = "Flag Type";
            // 
            // cmbFlagType
            // 
            this.cmbFlagType.FormattingEnabled = true;
            this.cmbFlagType.Location = new System.Drawing.Point(98, 30);
            this.cmbFlagType.Name = "cmbFlagType";
            this.cmbFlagType.Size = new System.Drawing.Size(117, 21);
            this.cmbFlagType.TabIndex = 152;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(494, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 154;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(5, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 41);
            this.btnSave.TabIndex = 153;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // CreateFlagInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbFlagType);
            this.Controls.Add(this.rchFlag);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFlagType);
            this.Name = "CreateFlagInfoView";
            this.Size = new System.Drawing.Size(604, 259);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rchFlag;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFlagType;
        public System.Windows.Forms.ComboBox cmbFlagType;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;

    }
}
