namespace Prototype1_1.UI.Forms.ReportTab
{
    partial class ReportDemographyForm
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
            this.reportDateRangeView1 = new Prototype1_1.UI.Views.ReportTab.ReportDateRangeView();
            this.reportDemographyView1 = new Prototype1_1.UI.Views.ReportTab.ReportDemographyView();
            this.reportConfirmationView1 = new Prototype1_1.UI.Views.ReportTab.ReportConfirmationView();
            this.SuspendLayout();
            // 
            // reportDateRangeView1
            // 
            this.reportDateRangeView1.Location = new System.Drawing.Point(12, 12);
            this.reportDateRangeView1.Name = "reportDateRangeView1";
            this.reportDateRangeView1.Size = new System.Drawing.Size(338, 30);
            this.reportDateRangeView1.TabIndex = 0;
            // 
            // reportDemographyView1
            // 
            this.reportDemographyView1.Location = new System.Drawing.Point(12, 48);
            this.reportDemographyView1.Name = "reportDemographyView1";
            this.reportDemographyView1.Size = new System.Drawing.Size(500, 123);
            this.reportDemographyView1.TabIndex = 1;
            // 
            // reportConfirmationView1
            // 
            this.reportConfirmationView1.Location = new System.Drawing.Point(12, 177);
            this.reportConfirmationView1.Name = "reportConfirmationView1";
            this.reportConfirmationView1.Size = new System.Drawing.Size(500, 38);
            this.reportConfirmationView1.TabIndex = 2;
            // 
            // ReportDemographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 231);
            this.Controls.Add(this.reportConfirmationView1);
            this.Controls.Add(this.reportDemographyView1);
            this.Controls.Add(this.reportDateRangeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportDemographyForm";
            this.Text = "Demography Report Criteria";
            this.ResumeLayout(false);

        }

        #endregion

        public Prototype1_1.UI.Views.ReportTab.ReportDateRangeView reportDateRangeView1;
        public Prototype1_1.UI.Views.ReportTab.ReportDemographyView reportDemographyView1;
        public Prototype1_1.UI.Views.ReportTab.ReportConfirmationView reportConfirmationView1;

    }
}