namespace Prototype1_1.UI.Views.HouseholdTab
{
    partial class HouseholdTabView
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
            this.appointmentInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Appointment.AppointmentInfoView();
            this.flagInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Flag.FlagInfoView();
            this.noteInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Note.NoteInfoView();
            this.householdAndClient1 = new Prototype1_1.UI.Views.HouseholdTab.HouseholdAndClient.HouseholdAndClientView();
            this.dependantInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Dependant.DependantInfoView();
            this.SuspendLayout();
            // 
            // appointmentInfoView1
            // 
            this.appointmentInfoView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appointmentInfoView1.Location = new System.Drawing.Point(542, 208);
            this.appointmentInfoView1.Name = "appointmentInfoView1";
            this.appointmentInfoView1.Size = new System.Drawing.Size(230, 247);
            this.appointmentInfoView1.TabIndex = 7;
            // 
            // flagInfoView1
            // 
            this.flagInfoView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flagInfoView1.Location = new System.Drawing.Point(542, 467);
            this.flagInfoView1.Name = "flagInfoView1";
            this.flagInfoView1.Size = new System.Drawing.Size(230, 170);
            this.flagInfoView1.TabIndex = 6;
            // 
            // noteInfoView1
            // 
            this.noteInfoView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.noteInfoView1.Location = new System.Drawing.Point(0, 467);
            this.noteInfoView1.Name = "noteInfoView1";
            this.noteInfoView1.Size = new System.Drawing.Size(529, 170);
            this.noteInfoView1.TabIndex = 5;
            // 
            // householdAndClient1
            // 
            this.householdAndClient1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.householdAndClient1.BackColor = System.Drawing.Color.White;
            this.householdAndClient1.Location = new System.Drawing.Point(3, 3);
            this.householdAndClient1.Name = "householdAndClient1";
            this.householdAndClient1.Size = new System.Drawing.Size(533, 513);
            this.householdAndClient1.TabIndex = 4;
            // 
            // dependantInfoView1
            // 
            this.dependantInfoView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dependantInfoView1.Location = new System.Drawing.Point(542, 26);
            this.dependantInfoView1.Name = "dependantInfoView1";
            this.dependantInfoView1.Size = new System.Drawing.Size(230, 164);
            this.dependantInfoView1.TabIndex = 3;
            // 
            // HouseholdTabView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.appointmentInfoView1);
            this.Controls.Add(this.flagInfoView1);
            this.Controls.Add(this.noteInfoView1);
            this.Controls.Add(this.householdAndClient1);
            this.Controls.Add(this.dependantInfoView1);
            this.Name = "HouseholdTabView";
            this.Size = new System.Drawing.Size(782, 640);
            this.ResumeLayout(false);

        }

        #endregion

        public Dependant.DependantInfoView dependantInfoView1;
        public HouseholdAndClient.HouseholdAndClientView householdAndClient1;
        public Note.NoteInfoView noteInfoView1;
        public Flag.FlagInfoView flagInfoView1;
        public Appointment.AppointmentInfoView appointmentInfoView1;

    }
}
