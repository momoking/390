namespace Prototype1_1.UI.Views.ReportTab
{
    partial class ReportDateRangeView
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
            this.dtpDateRangeTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateRangeFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDateRangeTo
            // 
            this.dtpDateRangeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateRangeTo.Location = new System.Drawing.Point(201, 3);
            this.dtpDateRangeTo.Name = "dtpDateRangeTo";
            this.dtpDateRangeTo.Size = new System.Drawing.Size(112, 20);
            this.dtpDateRangeTo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "To";
            // 
            // dtpDateRangeFrom
            // 
            this.dtpDateRangeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateRangeFrom.Location = new System.Drawing.Point(49, 3);
            this.dtpDateRangeFrom.Name = "dtpDateRangeFrom";
            this.dtpDateRangeFrom.Size = new System.Drawing.Size(114, 20);
            this.dtpDateRangeFrom.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "From";
            // 
            // ReportDateRangeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateRangeTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateRangeFrom);
            this.Controls.Add(this.label2);
            this.Name = "ReportDateRangeView";
            this.Size = new System.Drawing.Size(338, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpDateRangeTo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpDateRangeFrom;
        private System.Windows.Forms.Label label2;
    }
}
