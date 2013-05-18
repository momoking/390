namespace Prototype1_1.UI.Views.ReportTab
{
    partial class ReportTabView
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
            this.reportHeader1 = new Prototype1_1.UI.Views.ReportTab.ReportHeader();
            this.SuspendLayout();
            // 
            // reportHeader1
            // 
            this.reportHeader1.BackColor = System.Drawing.Color.White;
            this.reportHeader1.Location = new System.Drawing.Point(3, 0);
            this.reportHeader1.Name = "reportHeader1";
            this.reportHeader1.Size = new System.Drawing.Size(578, 41);
            this.reportHeader1.TabIndex = 0;
            // 
            // ReportTabView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reportHeader1);
            this.Name = "ReportTabView";
            this.Size = new System.Drawing.Size(581, 493);
            this.ResumeLayout(false);

        }

        #endregion

        private ReportHeader reportHeader1;
        
    }
}
