namespace Prototype1_1.UI.Views.HouseholdTab.Appointment
{
    partial class UpdateAppointmentInfoView
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
            this.dgvDateSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.EventColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fvgTimeSlots = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSelectEvent = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fvgTimeSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDateSelect
            // 
            this.dgvDateSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvDateSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDateSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dgvDateSelect.GridColor = System.Drawing.Color.Gray;
            this.dgvDateSelect.Location = new System.Drawing.Point(41, 277);
            this.dgvDateSelect.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDateSelect.MultiSelect = false;
            this.dgvDateSelect.Name = "dgvDateSelect";
            this.dgvDateSelect.ReadOnly = true;
            this.dgvDateSelect.RowHeadersVisible = false;
            this.dgvDateSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDateSelect.Size = new System.Drawing.Size(390, 185);
            this.dgvDateSelect.TabIndex = 119;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(38, 495);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(108, 13);
            this.lblTimeSlot.TabIndex = 118;
            this.lblTimeSlot.Text = "3 - Select a Time Slot";
            // 
            // dgvEvents
            // 
            this.dgvEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventColumn,
            this.LocationColumn,
            this.DescriptionColumn});
            this.dgvEvents.GridColor = System.Drawing.Color.Gray;
            this.dgvEvents.Location = new System.Drawing.Point(41, 49);
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(390, 185);
            this.dgvEvents.TabIndex = 114;
            // 
            // EventColumn
            // 
            this.EventColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventColumn.DataPropertyName = "Event";
            this.EventColumn.HeaderText = "Event";
            this.EventColumn.Name = "EventColumn";
            this.EventColumn.ReadOnly = true;
            // 
            // LocationColumn
            // 
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // fvgTimeSlots
            // 
            this.fvgTimeSlots.BackgroundColor = System.Drawing.Color.White;
            this.fvgTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fvgTimeSlots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.RegisterColumn});
            this.fvgTimeSlots.GridColor = System.Drawing.Color.Gray;
            this.fvgTimeSlots.Location = new System.Drawing.Point(41, 510);
            this.fvgTimeSlots.Margin = new System.Windows.Forms.Padding(2);
            this.fvgTimeSlots.MultiSelect = false;
            this.fvgTimeSlots.Name = "fvgTimeSlots";
            this.fvgTimeSlots.ReadOnly = true;
            this.fvgTimeSlots.RowHeadersVisible = false;
            this.fvgTimeSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fvgTimeSlots.Size = new System.Drawing.Size(390, 185);
            this.fvgTimeSlots.TabIndex = 115;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Booked";
            this.dataGridViewTextBoxColumn2.HeaderText = "Place Left";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // RegisterColumn
            // 
            this.RegisterColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RegisterColumn.HeaderText = "Registered";
            this.RegisterColumn.Name = "RegisterColumn";
            this.RegisterColumn.ReadOnly = true;
            this.RegisterColumn.Width = 64;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(38, 262);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 13);
            this.lblDate.TabIndex = 117;
            this.lblDate.Text = "2 - Select a date";
            // 
            // lblSelectEvent
            // 
            this.lblSelectEvent.AutoSize = true;
            this.lblSelectEvent.Location = new System.Drawing.Point(38, 34);
            this.lblSelectEvent.Name = "lblSelectEvent";
            this.lblSelectEvent.Size = new System.Drawing.Size(101, 13);
            this.lblSelectEvent.TabIndex = 116;
            this.lblSelectEvent.Text = "1 - Select an Event:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(326, 747);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 41);
            this.btnCancel.TabIndex = 148;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.Location = new System.Drawing.Point(41, 747);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(105, 41);
            this.btnRegister.TabIndex = 147;
            this.btnRegister.Text = "&REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // UpdateAppointmentInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dgvDateSelect);
            this.Controls.Add(this.lblTimeSlot);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.fvgTimeSlots);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSelectEvent);
            this.Name = "UpdateAppointmentInfoView";
            this.Size = new System.Drawing.Size(468, 811);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fvgTimeSlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDateSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblTimeSlot;
        public System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        public System.Windows.Forms.DataGridView fvgTimeSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RegisterColumn;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSelectEvent;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnRegister;


    }
}
