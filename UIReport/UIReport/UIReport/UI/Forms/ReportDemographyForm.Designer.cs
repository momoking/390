namespace UIReport.Popup
{
    partial class formReportDemography
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
            this.reportConfirmationView1 = new UIReport.UI.Views.ReportConfirmationView();
            this.reportDemographyView1 = new UIReport.UI.Views.ReportDemographyView();
            this.reportDateRangeView1 = new UIReport.UI.Views.ReportDateRangeView();
            this.SuspendLayout();
            // 
            // reportConfirmationView1
            // 
            this.reportConfirmationView1.Location = new System.Drawing.Point(12, 176);
            this.reportConfirmationView1.Name = "reportConfirmationView1";
            this.reportConfirmationView1.Size = new System.Drawing.Size(500, 38);
            this.reportConfirmationView1.TabIndex = 2;
            // 
            // reportDemographyView1
            // 
            this.reportDemographyView1.Location = new System.Drawing.Point(12, 47);
            this.reportDemographyView1.Name = "reportDemographyView1";
            this.reportDemographyView1.Size = new System.Drawing.Size(500, 123);
            this.reportDemographyView1.TabIndex = 1;
            // 
            // reportDateRangeView1
            // 
            this.reportDateRangeView1.Location = new System.Drawing.Point(12, 12);
            this.reportDateRangeView1.Name = "reportDateRangeView1";
            this.reportDateRangeView1.Size = new System.Drawing.Size(338, 30);
            this.reportDateRangeView1.TabIndex = 3;
            // 
            // formReportDemography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 232);
            this.Controls.Add(this.reportDateRangeView1);
            this.Controls.Add(this.reportConfirmationView1);
            this.Controls.Add(this.reportDemographyView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formReportDemography";
            this.Text = "Demography Report";
            this.ResumeLayout(false);

        }

        #endregion

        public UI.Views.ReportDemographyView reportDemographyView1;
        public UI.Views.ReportConfirmationView reportConfirmationView1;
        public UI.Views.ReportDateRangeView reportDateRangeView1;



    }
}