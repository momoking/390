namespace Prototype1_1.UI.Forms.HouseholdTab.Appointment
{
    partial class CreateAppointmentForm
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
            this.createAppointmentInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Appointment.CreateAppointmentInfoView();
            this.SuspendLayout();
            // 
            // createAppointmentInfoView1
            // 
            this.createAppointmentInfoView1.BackColor = System.Drawing.Color.White;
            this.createAppointmentInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createAppointmentInfoView1.Location = new System.Drawing.Point(0, 0);
            this.createAppointmentInfoView1.Name = "createAppointmentInfoView1";
            this.createAppointmentInfoView1.Size = new System.Drawing.Size(474, 794);
            this.createAppointmentInfoView1.TabIndex = 0;
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 794);
            this.Controls.Add(this.createAppointmentInfoView1);
            this.Name = "CreateAppointmentForm";
            this.Text = "CreateAppointmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Appointment.CreateAppointmentInfoView createAppointmentInfoView1;

    }
}