namespace Prototype1_1.UI.Views.HouseholdTab.Note
{
    partial class CreateNoteInfoView
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.rchNote = new System.Windows.Forms.RichTextBox();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy/MM/dd";
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(96, 2);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(117, 22);
            this.dtpDate.TabIndex = 126;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 143;
            this.lblDate.Text = "Date";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(10, 31);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(63, 17);
            this.lblOperator.TabIndex = 119;
            this.lblOperator.Text = "Operator";
            // 
            // txtOperator
            // 
            this.txtOperator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperator.Location = new System.Drawing.Point(96, 28);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(2);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(115, 22);
            this.txtOperator.TabIndex = 123;
            // 
            // rchNote
            // 
            this.rchNote.Location = new System.Drawing.Point(3, 60);
            this.rchNote.Name = "rchNote";
            this.rchNote.Size = new System.Drawing.Size(594, 146);
            this.rchNote.TabIndex = 144;
            this.rchNote.Text = "";
            // 
            // erp1
            // 
            this.erp1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(3, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 41);
            this.btnSave.TabIndex = 145;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(492, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 146;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateNoteInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rchNote);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperator);
            this.Name = "CreateNoteInfoView";
            this.Size = new System.Drawing.Size(600, 273);
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOperator;
        public System.Windows.Forms.TextBox txtOperator;
        public System.Windows.Forms.RichTextBox rchNote;
        public System.Windows.Forms.ErrorProvider erp1;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
    }
}
