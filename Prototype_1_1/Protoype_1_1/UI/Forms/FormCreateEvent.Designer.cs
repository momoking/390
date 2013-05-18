namespace Prototype1_1.UI.Forms
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
            this.lblLoadTemplate = new System.Windows.Forms.Label();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.lblEnds = new System.Windows.Forms.Label();
            this.lblStarts = new System.Windows.Forms.Label();
            this.dtpStarts = new System.Windows.Forms.DateTimePicker();
            this.dtpEnds = new System.Windows.Forms.DateTimePicker();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.btnRemoveSlot = new System.Windows.Forms.Button();
            this.btnAddSlot = new System.Windows.Forms.Button();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblAddSlot = new System.Windows.Forms.Label();
            this.lstSlots = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeEnd.Location = new System.Drawing.Point(356, 192);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(99, 22);
            this.dtpTimeEnd.TabIndex = 109;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.Location = new System.Drawing.Point(313, 192);
            this.lblTimeEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(41, 21);
            this.lblTimeEnd.TabIndex = 108;
            this.lblTimeEnd.Text = "End";
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeStart.Location = new System.Drawing.Point(166, 194);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(104, 22);
            this.dtpTimeStart.TabIndex = 107;
            // 
            // lblLoadTemplate
            // 
            this.lblLoadTemplate.AutoSize = true;
            this.lblLoadTemplate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadTemplate.Location = new System.Drawing.Point(22, 76);
            this.lblLoadTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoadTemplate.Name = "lblLoadTemplate";
            this.lblLoadTemplate.Size = new System.Drawing.Size(89, 42);
            this.lblLoadTemplate.TabIndex = 106;
            this.lblLoadTemplate.Text = "Load\r\nTemplate";
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(126, 76);
            this.cmbTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(357, 29);
            this.cmbTemplate.TabIndex = 105;
            // 
            // cmbRepeats
            // 
            this.cmbRepeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepeats.FormattingEnabled = true;
            this.cmbRepeats.Location = new System.Drawing.Point(236, 221);
            this.cmbRepeats.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRepeats.Name = "cmbRepeats";
            this.cmbRepeats.Size = new System.Drawing.Size(247, 29);
            this.cmbRepeats.TabIndex = 102;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.Location = new System.Drawing.Point(115, 193);
            this.lblTimeStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(49, 21);
            this.lblTimeStart.TabIndex = 98;
            this.lblTimeStart.Text = "Start";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepeat.Location = new System.Drawing.Point(126, 223);
            this.chkRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(102, 25);
            this.chkRepeat.TabIndex = 97;
            this.chkRepeat.Text = "Repeats";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(126, 328);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(357, 80);
            this.txtDescription.TabIndex = 96;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(18, 331);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 21);
            this.lblDescription.TabIndex = 95;
            this.lblDescription.Text = "Description";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(126, 157);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(357, 27);
            this.txtLocation.TabIndex = 93;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(18, 160);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 21);
            this.lblLocation.TabIndex = 94;
            this.lblLocation.Text = "Location";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 122);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 27);
            this.txtName.TabIndex = 91;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 125);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 21);
            this.lblName.TabIndex = 92;
            this.lblName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(22, 471);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "&SAVE AS\r\nNEW";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.BackColor = System.Drawing.Color.White;
            this.btnSaveTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTemplate.FlatAppearance.BorderSize = 2;
            this.btnSaveTemplate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTemplate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveTemplate.Location = new System.Drawing.Point(130, 471);
            this.btnSaveTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(108, 55);
            this.btnSaveTemplate.TabIndex = 87;
            this.btnSaveTemplate.Text = "SAVE AS &TEMPLATE";
            this.btnSaveTemplate.UseVisualStyleBackColor = false;
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(22, 9);
            this.lblEventDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(149, 23);
            this.lblEventDetails.TabIndex = 110;
            this.lblEventDetails.Text = "EVENT DETAILS";
            // 
            // lblEnds
            // 
            this.lblEnds.AutoSize = true;
            this.lblEnds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnds.Location = new System.Drawing.Point(63, 298);
            this.lblEnds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnds.Name = "lblEnds";
            this.lblEnds.Size = new System.Drawing.Size(48, 21);
            this.lblEnds.TabIndex = 101;
            this.lblEnds.Text = "Ends";
            // 
            // lblStarts
            // 
            this.lblStarts.AutoSize = true;
            this.lblStarts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarts.Location = new System.Drawing.Point(55, 263);
            this.lblStarts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStarts.Name = "lblStarts";
            this.lblStarts.Size = new System.Drawing.Size(56, 21);
            this.lblStarts.TabIndex = 100;
            this.lblStarts.Text = "Starts";
            // 
            // dtpStarts
            // 
            this.dtpStarts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStarts.Location = new System.Drawing.Point(123, 258);
            this.dtpStarts.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStarts.Name = "dtpStarts";
            this.dtpStarts.Size = new System.Drawing.Size(360, 27);
            this.dtpStarts.TabIndex = 103;
            // 
            // dtpEnds
            // 
            this.dtpEnds.Enabled = false;
            this.dtpEnds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnds.Location = new System.Drawing.Point(123, 293);
            this.dtpEnds.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnds.Name = "dtpEnds";
            this.dtpEnds.Size = new System.Drawing.Size(360, 27);
            this.dtpEnds.TabIndex = 104;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(672, 112);
            this.numCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(51, 22);
            this.numCapacity.TabIndex = 118;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(672, 73);
            this.numDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(51, 22);
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
            this.lblCapacity.Location = new System.Drawing.Point(543, 114);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(99, 21);
            this.lblCapacity.TabIndex = 116;
            this.lblCapacity.Text = "Capacity: ";
            // 
            // btnRemoveSlot
            // 
            this.btnRemoveSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRemoveSlot.Location = new System.Drawing.Point(672, 150);
            this.btnRemoveSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveSlot.Name = "btnRemoveSlot";
            this.btnRemoveSlot.Size = new System.Drawing.Size(120, 34);
            this.btnRemoveSlot.TabIndex = 115;
            this.btnRemoveSlot.Text = "Remove";
            this.btnRemoveSlot.UseVisualStyleBackColor = true;
            // 
            // btnAddSlot
            // 
            this.btnAddSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAddSlot.Location = new System.Drawing.Point(545, 150);
            this.btnAddSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSlot.Name = "btnAddSlot";
            this.btnAddSlot.Size = new System.Drawing.Size(120, 34);
            this.btnAddSlot.TabIndex = 114;
            this.btnAddSlot.Text = "Add";
            this.btnAddSlot.UseVisualStyleBackColor = true;
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblMins.Location = new System.Drawing.Point(729, 75);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(73, 21);
            this.lblMins.TabIndex = 113;
            this.lblMins.Text = "minutes";
            // 
            // lblAddSlot
            // 
            this.lblAddSlot.AutoSize = true;
            this.lblAddSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblAddSlot.Location = new System.Drawing.Point(543, 75);
            this.lblAddSlot.Name = "lblAddSlot";
            this.lblAddSlot.Size = new System.Drawing.Size(124, 21);
            this.lblAddSlot.TabIndex = 112;
            this.lblAddSlot.Text = "Slot duration: ";
            // 
            // lstSlots
            // 
            this.lstSlots.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSlots.FormattingEnabled = true;
            this.lstSlots.ItemHeight = 21;
            this.lstSlots.Location = new System.Drawing.Point(547, 192);
            this.lstSlots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSlots.Name = "lstSlots";
            this.lstSlots.Size = new System.Drawing.Size(372, 214);
            this.lstSlots.TabIndex = 111;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(246, 471);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 55);
            this.btnCancel.TabIndex = 119;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 545);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.btnRemoveSlot);
            this.Controls.Add(this.btnAddSlot);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.lblAddSlot);
            this.Controls.Add(this.lstSlots);
            this.Controls.Add(this.lblEventDetails);
            this.Controls.Add(this.dtpTimeEnd);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.dtpTimeStart);
            this.Controls.Add(this.lblLoadTemplate);
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
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveTemplate);
            this.Name = "FormCreateEvent";
            this.Text = "FormCreateEvent";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Label lblLoadTemplate;
        public System.Windows.Forms.ComboBox cmbTemplate;
        public System.Windows.Forms.ComboBox cmbRepeats;
        private System.Windows.Forms.Label lblTimeStart;
        public System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnSaveTemplate;
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
        public System.Windows.Forms.Button btnRemoveSlot;
        public System.Windows.Forms.Button btnAddSlot;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblAddSlot;
        public System.Windows.Forms.ListBox lstSlots;
        public System.Windows.Forms.Button btnCancel;
    }
}