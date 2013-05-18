namespace Prototype1_1.UI.Views.HouseholdTab.Appointment
{
    partial class AppointmentInfoView
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.grpAppointment = new System.Windows.Forms.GroupBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.grpAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAppointments.GridColor = System.Drawing.Color.Gray;
            this.dgvAppointments.Location = new System.Drawing.Point(3, 56);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(224, 191);
            this.dgvAppointments.TabIndex = 92;
            // 
            // grpAppointment
            // 
            this.grpAppointment.BackColor = System.Drawing.Color.White;
            this.grpAppointment.Controls.Add(this.dgvAppointments);
            this.grpAppointment.Controls.Add(this.picDelete);
            this.grpAppointment.Controls.Add(this.picAdd);
            this.grpAppointment.Location = new System.Drawing.Point(0, 0);
            this.grpAppointment.Name = "grpAppointment";
            this.grpAppointment.Size = new System.Drawing.Size(230, 250);
            this.grpAppointment.TabIndex = 93;
            this.grpAppointment.TabStop = false;
            this.grpAppointment.Text = "Appointments";
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Enabled = false;
            this.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;
            this.picDelete.Location = new System.Drawing.Point(192, 19);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(32, 32);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 91;
            this.picDelete.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Enabled = false;
            this.picAdd.Image = global::Prototype1_1.Properties.Resources.calendar_add;
            this.picAdd.Location = new System.Drawing.Point(6, 19);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(32, 32);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 89;
            this.picAdd.TabStop = false;
            // 
            // AppointmentInfoView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grpAppointment);
            this.Name = "AppointmentInfoView";
            this.Size = new System.Drawing.Size(230, 250);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.grpAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picDelete;
        public System.Windows.Forms.PictureBox picAdd;
        public System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.GroupBox grpAppointment;
    }
}
