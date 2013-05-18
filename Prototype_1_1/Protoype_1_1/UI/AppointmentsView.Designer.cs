namespace Prototype1_1.UI
{
    partial class AppointmentsView
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
            this.btnSave = new System.Windows.Forms.Button();
            this.grpAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.chkClosed = new System.Windows.Forms.CheckBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtAvailable2 = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.chkAllDay = new System.Windows.Forms.CheckBox();
            this.calCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAppointments = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpAppointmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(538, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 45);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "&Save as new";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // grpAppointmentDetails
            // 
            this.grpAppointmentDetails.Controls.Add(this.chkClosed);
            this.grpAppointmentDetails.Controls.Add(this.lblSlash);
            this.grpAppointmentDetails.Controls.Add(this.txtAvailable2);
            this.grpAppointmentDetails.Controls.Add(this.txtAvailable);
            this.grpAppointmentDetails.Controls.Add(this.lblAvailable);
            this.grpAppointmentDetails.Controls.Add(this.txtNote);
            this.grpAppointmentDetails.Controls.Add(this.lblNote);
            this.grpAppointmentDetails.Controls.Add(this.txtLocation);
            this.grpAppointmentDetails.Controls.Add(this.lblLocation);
            this.grpAppointmentDetails.Controls.Add(this.txtName);
            this.grpAppointmentDetails.Controls.Add(this.lblName);
            this.grpAppointmentDetails.Controls.Add(this.chkRepeat);
            this.grpAppointmentDetails.Controls.Add(this.chkAllDay);
            this.grpAppointmentDetails.Controls.Add(this.calCalendar);
            this.grpAppointmentDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppointmentDetails.Location = new System.Drawing.Point(407, 0);
            this.grpAppointmentDetails.Name = "grpAppointmentDetails";
            this.grpAppointmentDetails.Size = new System.Drawing.Size(388, 469);
            this.grpAppointmentDetails.TabIndex = 22;
            this.grpAppointmentDetails.TabStop = false;
            this.grpAppointmentDetails.Text = "Appointment Details";
            // 
            // chkClosed
            // 
            this.chkClosed.AutoSize = true;
            this.chkClosed.Checked = true;
            this.chkClosed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClosed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClosed.Location = new System.Drawing.Point(272, 38);
            this.chkClosed.Name = "chkClosed";
            this.chkClosed.Size = new System.Drawing.Size(72, 21);
            this.chkClosed.TabIndex = 23;
            this.chkClosed.Text = "Closed";
            this.chkClosed.UseVisualStyleBackColor = true;
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.Location = new System.Drawing.Point(158, 282);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(12, 16);
            this.lblSlash.TabIndex = 22;
            this.lblSlash.Text = "/";
            // 
            // txtAvailable2
            // 
            this.txtAvailable2.Location = new System.Drawing.Point(178, 281);
            this.txtAvailable2.Name = "txtAvailable2";
            this.txtAvailable2.Size = new System.Drawing.Size(82, 23);
            this.txtAvailable2.TabIndex = 4;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(78, 281);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(74, 23);
            this.txtAvailable.TabIndex = 3;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(7, 285);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(69, 17);
            this.lblAvailable.TabIndex = 19;
            this.lblAvailable.Text = "Available";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(78, 314);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(304, 141);
            this.txtNote.TabIndex = 5;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(35, 315);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(40, 17);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = "Note";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(78, 252);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(304, 23);
            this.txtLocation.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(11, 255);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 17);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 223);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 224);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepeat.Location = new System.Drawing.Point(272, 91);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(90, 21);
            this.chkRepeat.TabIndex = 8;
            this.chkRepeat.Text = "Repeat ...";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // chkAllDay
            // 
            this.chkAllDay.AutoSize = true;
            this.chkAllDay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllDay.Location = new System.Drawing.Point(272, 65);
            this.chkAllDay.Name = "chkAllDay";
            this.chkAllDay.Size = new System.Drawing.Size(71, 21);
            this.chkAllDay.TabIndex = 7;
            this.chkAllDay.Text = "All Day";
            this.chkAllDay.UseVisualStyleBackColor = true;
            // 
            // calCalendar
            // 
            this.calCalendar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calCalendar.Location = new System.Drawing.Point(33, 38);
            this.calCalendar.Name = "calCalendar";
            this.calCalendar.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(670, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 45);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // grpAppointments
            // 
            this.grpAppointments.Location = new System.Drawing.Point(3, 0);
            this.grpAppointments.Name = "grpAppointments";
            this.grpAppointments.Size = new System.Drawing.Size(388, 523);
            this.grpAppointments.TabIndex = 21;
            this.grpAppointments.TabStop = false;
            this.grpAppointments.Text = "Appointments";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(407, 478);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 45);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // AppointmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAppointmentDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpAppointments);
            this.Controls.Add(this.btnUpdate);
            this.Name = "AppointmentsView";
            this.Size = new System.Drawing.Size(799, 527);
            this.grpAppointmentDetails.ResumeLayout(false);
            this.grpAppointmentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpAppointmentDetails;
        private System.Windows.Forms.CheckBox chkClosed;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.TextBox txtAvailable2;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.CheckBox chkAllDay;
        private System.Windows.Forms.MonthCalendar calCalendar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpAppointments;
        private System.Windows.Forms.Button btnUpdate;
    }
}
