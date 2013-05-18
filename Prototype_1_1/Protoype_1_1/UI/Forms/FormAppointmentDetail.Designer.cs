namespace Prototype1_1.UI.Forms
{
    partial class FormAppointmentDetail
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
            this.appointmentDetailView = new Prototype1_1.UI.Views.SubViews.s();
            this.SuspendLayout();
            // 
            // appointmentDetailView
            // 
            this.appointmentDetailView.Location = new System.Drawing.Point(12, 12);
            this.appointmentDetailView.Name = "appointmentDetailView";
            this.appointmentDetailView.Size = new System.Drawing.Size(471, 625);
            this.appointmentDetailView.TabIndex = 1;
            // 
            // FormAppointmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 638);
            this.Controls.Add(this.appointmentDetailView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAppointmentDetail";
            this.Text = "Appointment Details";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.SubViews.s appointmentDetailView;
    }
}