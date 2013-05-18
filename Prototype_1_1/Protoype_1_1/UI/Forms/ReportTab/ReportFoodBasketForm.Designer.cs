namespace Prototype1_1.UI.Forms.ReportTab
{
    partial class ReportFoodBasketForm
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
            this.reportFoodBasketView1 = new Prototype1_1.UI.Views.ReportTab.ReportFoodBasketView();
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
            // reportFoodBasketView1
            // 
            this.reportFoodBasketView1.Location = new System.Drawing.Point(12, 48);
            this.reportFoodBasketView1.Name = "reportFoodBasketView1";
            this.reportFoodBasketView1.Size = new System.Drawing.Size(505, 122);
            this.reportFoodBasketView1.TabIndex = 1;
            // 
            // reportConfirmationView1
            // 
            this.reportConfirmationView1.Location = new System.Drawing.Point(12, 176);
            this.reportConfirmationView1.Name = "reportConfirmationView1";
            this.reportConfirmationView1.Size = new System.Drawing.Size(500, 38);
            this.reportConfirmationView1.TabIndex = 2;
            // 
            // formReportFoodBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 238);
            this.Controls.Add(this.reportConfirmationView1);
            this.Controls.Add(this.reportFoodBasketView1);
            this.Controls.Add(this.reportDateRangeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formReportFoodBasket";
            this.Text = "Food Basket Report";
            this.ResumeLayout(false);

        }

        #endregion

        public Prototype1_1.UI.Views.ReportTab.ReportDateRangeView reportDateRangeView1;
        public Prototype1_1.UI.Views.ReportTab.ReportFoodBasketView reportFoodBasketView1;
        public Prototype1_1.UI.Views.ReportTab.ReportConfirmationView reportConfirmationView1;

    }
}