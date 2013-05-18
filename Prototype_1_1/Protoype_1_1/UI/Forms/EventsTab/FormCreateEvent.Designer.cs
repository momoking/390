namespace Prototype1_1.UI.Forms.EventsTab
{
    partial class FormCreateEvent
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
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.cmbRepeats = new System.Windows.Forms.ComboBox();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.lblEnds = new System.Windows.Forms.Label();
            this.lblStarts = new System.Windows.Forms.Label();
            this.dtpStarts = new System.Windows.Forms.DateTimePicker();
            this.dtpEnds = new System.Windows.Forms.DateTimePicker();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblAddSlot = new System.Windows.Forms.Label();
            this.lstSlots = new System.Windows.Forms.ListBox();
            this.btnAddSlot = new System.Windows.Forms.Button();
            this.btnRemoveSlot = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeEnd.Location = new System.Drawing.Point(267, 149);
            this.dtpTimeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(96, 20);
            this.dtpTimeEnd.TabIndex = 109;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.Location = new System.Drawing.Point(235, 147);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(32, 17);
            this.lblTimeEnd.TabIndex = 108;
            this.lblTimeEnd.Text = "End";
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeStart.Location = new System.Drawing.Point(129, 148);
            this.dtpTimeStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(91, 20);
            this.dtpTimeStart.TabIndex = 107;
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(129, 58);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(234, 25);
            this.cmbTemplate.TabIndex = 105;
            // 
            // cmbRepeats
            // 
            this.cmbRepeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepeats.FormattingEnabled = true;
            this.cmbRepeats.Location = new System.Drawing.Point(157, 174);
            this.cmbRepeats.Name = "cmbRepeats";
            this.cmbRepeats.Size = new System.Drawing.Size(206, 25);
            this.cmbRepeats.TabIndex = 102;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.Location = new System.Drawing.Point(86, 148);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(37, 17);
            this.lblTimeStart.TabIndex = 98;
            this.lblTimeStart.Text = "Start";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepeat.Location = new System.Drawing.Point(62, 178);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRepeat.Size = new System.Drawing.Size(79, 21);
            this.chkRepeat.TabIndex = 97;
            this.chkRepeat.Text = "Repeats";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(129, 266);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(234, 66);
            this.txtDescription.TabIndex = 96;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(37, 269);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 95;
            this.lblDescription.Text = "Description";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(129, 119);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(234, 23);
            this.txtLocation.TabIndex = 93;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(58, 122);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 17);
            this.lblLocation.TabIndex = 94;
            this.lblLocation.Text = "Location";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(129, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 23);
            this.txtName.TabIndex = 91;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(75, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 92;
            this.lblName.Text = "Name";
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(16, 7);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(125, 21);
            this.lblEventDetails.TabIndex = 110;
            this.lblEventDetails.Text = "EVENT DETAILS";
            // 
            // lblEnds
            // 
            this.lblEnds.AutoSize = true;
            this.lblEnds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnds.Location = new System.Drawing.Point(80, 238);
            this.lblEnds.Name = "lblEnds";
            this.lblEnds.Size = new System.Drawing.Size(37, 17);
            this.lblEnds.TabIndex = 101;
            this.lblEnds.Text = "Ends";
            // 
            // lblStarts
            // 
            this.lblStarts.AutoSize = true;
            this.lblStarts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarts.Location = new System.Drawing.Point(75, 210);
            this.lblStarts.Name = "lblStarts";
            this.lblStarts.Size = new System.Drawing.Size(42, 17);
            this.lblStarts.TabIndex = 100;
            this.lblStarts.Text = "Starts";
            // 
            // dtpStarts
            // 
            this.dtpStarts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStarts.Location = new System.Drawing.Point(129, 210);
            this.dtpStarts.Name = "dtpStarts";
            this.dtpStarts.Size = new System.Drawing.Size(234, 23);
            this.dtpStarts.TabIndex = 103;
            // 
            // dtpEnds
            // 
            this.dtpEnds.Enabled = false;
            this.dtpEnds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnds.Location = new System.Drawing.Point(129, 238);
            this.dtpEnds.Name = "dtpEnds";
            this.dtpEnds.Size = new System.Drawing.Size(234, 23);
            this.dtpEnds.TabIndex = 104;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(504, 91);
            this.numCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(38, 20);
            this.numCapacity.TabIndex = 118;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(504, 59);
            this.numDuration.Margin = new System.Windows.Forms.Padding(2);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(38, 20);
            this.numDuration.TabIndex = 117;
            this.numDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblCapacity.Location = new System.Drawing.Point(407, 93);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(76, 17);
            this.lblCapacity.TabIndex = 116;
            this.lblCapacity.Text = "Capacity: ";
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblMins.Location = new System.Drawing.Point(547, 61);
            this.lblMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(58, 17);
            this.lblMins.TabIndex = 113;
            this.lblMins.Text = "minutes";
            // 
            // lblAddSlot
            // 
            this.lblAddSlot.AutoSize = true;
            this.lblAddSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblAddSlot.Location = new System.Drawing.Point(407, 61);
            this.lblAddSlot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSlot.Name = "lblAddSlot";
            this.lblAddSlot.Size = new System.Drawing.Size(98, 17);
            this.lblAddSlot.TabIndex = 112;
            this.lblAddSlot.Text = "Slot duration: ";
            // 
            // lstSlots
            // 
            this.lstSlots.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSlots.FormattingEnabled = true;
            this.lstSlots.ItemHeight = 17;
            this.lstSlots.Location = new System.Drawing.Point(410, 173);
            this.lstSlots.Margin = new System.Windows.Forms.Padding(2);
            this.lstSlots.Name = "lstSlots";
            this.lstSlots.Size = new System.Drawing.Size(280, 157);
            this.lstSlots.TabIndex = 111;
            // 
            // btnAddSlot
            // 
            this.btnAddSlot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddSlot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnAddSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSlot.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddSlot.Location = new System.Drawing.Point(410, 130);
            this.btnAddSlot.Name = "btnAddSlot";
            this.btnAddSlot.Size = new System.Drawing.Size(95, 29);
            this.btnAddSlot.TabIndex = 153;
            this.btnAddSlot.Text = "&ADD";
            this.btnAddSlot.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSlot
            // 
            this.btnRemoveSlot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveSlot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnRemoveSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSlot.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveSlot.Location = new System.Drawing.Point(595, 130);
            this.btnRemoveSlot.Name = "btnRemoveSlot";
            this.btnRemoveSlot.Size = new System.Drawing.Size(95, 29);
            this.btnRemoveSlot.TabIndex = 154;
            this.btnRemoveSlot.Text = "&REMOVE";
            this.btnRemoveSlot.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(410, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 155;
            this.btnSave.Text = "&SAVE AS NEW";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(129, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 45);
            this.btnCancel.TabIndex = 157;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 158;
            this.label1.Text = "Load Template";
            // 
            // FormCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveSlot);
            this.Controls.Add(this.btnAddSlot);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.lblAddSlot);
            this.Controls.Add(this.lstSlots);
            this.Controls.Add(this.lblEventDetails);
            this.Controls.Add(this.dtpTimeEnd);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.dtpTimeStart);
            this.Controls.Add(this.cmbTemplate);
            this.Controls.Add(this.dtpEnds);
            this.Controls.Add(this.dtpStarts);
            this.Controls.Add(this.cmbRepeats);
            this.Controls.Add(this.lblEnds);
            this.Controls.Add(this.lblStarts);
            this.Controls.Add(this.lblTimeStart);
            this.Controls.Add(this.chkRepeat);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creating an Event";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeEnd;
        public System.Windows.Forms.ComboBox cmbTemplate;
        public System.Windows.Forms.ComboBox cmbRepeats;
        private System.Windows.Forms.Label lblTimeStart;
        public System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEventDetails;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.DateTimePicker dtpTimeEnd;
        public System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.Label lblEnds;
        private System.Windows.Forms.Label lblStarts;
        public System.Windows.Forms.DateTimePicker dtpStarts;
        public System.Windows.Forms.DateTimePicker dtpEnds;
        public System.Windows.Forms.NumericUpDown numCapacity;
        public System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblAddSlot;
        public System.Windows.Forms.ListBox lstSlots;
        public System.Windows.Forms.Button btnAddSlot;
        public System.Windows.Forms.Button btnRemoveSlot;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}