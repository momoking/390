namespace Prototype1_1.UI.Views.ReportTab
{
    partial class ReportHeader
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
            this.btnReportOK = new System.Windows.Forms.Button();
            this.cmbReportSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReportOK
            // 
            this.btnReportOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnReportOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportOK.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnReportOK.Location = new System.Drawing.Point(424, 3);
            this.btnReportOK.Name = "btnReportOK";
            this.btnReportOK.Size = new System.Drawing.Size(73, 25);
            this.btnReportOK.TabIndex = 16;
            this.btnReportOK.Text = "OK";
            this.btnReportOK.UseVisualStyleBackColor = true;
            // 
            // cmbReportSelector
            // 
            this.cmbReportSelector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportSelector.FormattingEnabled = true;
            this.cmbReportSelector.Location = new System.Drawing.Point(193, 3);
            this.cmbReportSelector.Name = "cmbReportSelector";
            this.cmbReportSelector.Size = new System.Drawing.Size(225, 25);
            this.cmbReportSelector.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose Report Template";
            // 
            // ReportHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReportOK);
            this.Controls.Add(this.cmbReportSelector);
            this.Controls.Add(this.label1);
            this.Name = "ReportHeader";
            this.Size = new System.Drawing.Size(512, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnReportOK;
        public System.Windows.Forms.ComboBox cmbReportSelector;
        private System.Windows.Forms.Label label1;


    }
}
