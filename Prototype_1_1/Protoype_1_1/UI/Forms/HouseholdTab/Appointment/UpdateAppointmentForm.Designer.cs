namespace Prototype1_1.UI.Forms.HouseholdTab.Appointment
{
    partial class UpdateAppointmentForm
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
            this.updateAppointmentInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Appointment.UpdateAppointmentInfoView();
            this.SuspendLayout();
            // 
            // updateAppointmentInfoView1
            // 
            this.updateAppointmentInfoView1.BackColor = System.Drawing.Color.White;
            this.updateAppointmentInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateAppointmentInfoView1.Location = new System.Drawing.Point(0, 0);
            this.updateAppointmentInfoView1.Name = "updateAppointmentInfoView1";
            this.updateAppointmentInfoView1.Size = new System.Drawing.Size(482, 742);
            this.updateAppointmentInfoView1.TabIndex = 0;
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 742);
            this.Controls.Add(this.updateAppointmentInfoView1);
            this.Name = "UpdateAppointmentForm";
            this.Text = "UpdateAppointmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Appointment.UpdateAppointmentInfoView updateAppointmentInfoView1;


    }
}