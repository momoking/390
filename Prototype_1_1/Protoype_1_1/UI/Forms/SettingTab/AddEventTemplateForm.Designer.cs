namespace Prototype1_1.UI.Forms.SettingTab
{
    partial class AddEventTemplateForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnRemoveSlot = new System.Windows.Forms.Button();
            this.btnAddSlot = new System.Windows.Forms.Button();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblAddSlot = new System.Windows.Forms.Label();
            this.lstSlots = new System.Windows.Forms.ListBox();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnds = new System.Windows.Forms.DateTimePicker();
            this.dtpStarts = new System.Windows.Forms.DateTimePicker();
            this.cmbRepeats = new System.Windows.Forms.ComboBox();
            this.lblEnds = new System.Windows.Forms.Label();
            this.lblStarts = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(112, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 45);
            this.btnCancel.TabIndex = 187;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSaveTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTemplate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTemplate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSaveTemplate.Location = new System.Drawing.Point(393, 341);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(145, 45);
            this.btnSaveTemplate.TabIndex = 186;
            this.btnSaveTemplate.Text = "SAVE AS &TEMPLATE";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSlot
            // 
            this.btnRemoveSlot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveSlot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnRemoveSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSlot.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveSlot.Location = new System.Drawing.Point(578, 111);
            this.btnRemoveSlot.Name = "btnRemoveSlot";
            this.btnRemoveSlot.Size = new System.Drawing.Size(95, 29);
            this.btnRemoveSlot.TabIndex = 184;
            this.btnRemoveSlot.Text = "&REMOVE";
            this.btnRemoveSlot.UseVisualStyleBackColor = true;
            // 
            // btnAddSlot
            // 
            this.btnAddSlot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddSlot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnAddSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSlot.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddSlot.Location = new System.Drawing.Point(393, 111);
            this.btnAddSlot.Name = "btnAddSlot";
            this.btnAddSlot.Size = new System.Drawing.Size(95, 29);
            this.btnAddSlot.TabIndex = 183;
            this.btnAddSlot.Text = "&ADD";
            this.btnAddSlot.UseVisualStyleBackColor = true;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(487, 72);
            this.numCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(38, 20);
            this.numCapacity.TabIndex = 182;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(487, 40);
            this.numDuration.Margin = new System.Windows.Forms.Padding(2);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(38, 20);
            this.numDuration.TabIndex = 181;
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
            this.lblCapacity.Location = new System.Drawing.Point(390, 74);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(76, 17);
            this.lblCapacity.TabIndex = 180;
            this.lblCapacity.Text = "Capacity: ";
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblMins.Location = new System.Drawing.Point(530, 42);
            this.lblMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(58, 17);
            this.lblMins.TabIndex = 179;
            this.lblMins.Text = "minutes";
            // 
            // lblAddSlot
            // 
            this.lblAddSlot.AutoSize = true;
            this.lblAddSlot.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblAddSlot.Location = new System.Drawing.Point(390, 42);
            this.lblAddSlot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSlot.Name = "lblAddSlot";
            this.lblAddSlot.Size = new System.Drawing.Size(98, 17);
            this.lblAddSlot.TabIndex = 178;
            this.lblAddSlot.Text = "Slot duration: ";
            // 
            // lstSlots
            // 
            this.lstSlots.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSlots.FormattingEnabled = true;
            this.lstSlots.ItemHeight = 17;
            this.lstSlots.Location = new System.Drawing.Point(393, 154);
            this.lstSlots.Margin = new System.Windows.Forms.Padding(2);
            this.lstSlots.Name = "lstSlots";
            this.lstSlots.Size = new System.Drawing.Size(280, 157);
            this.lstSlots.TabIndex = 177;
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(12, 9);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(125, 21);
            this.lblEventDetails.TabIndex = 176;
            this.lblEventDetails.Text = "EVENT DETAILS";
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeEnd.Location = new System.Drawing.Point(250, 101);
            this.dtpTimeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(96, 20);
            this.dtpTimeEnd.TabIndex = 175;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.Location = new System.Drawing.Point(218, 99);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(32, 17);
            this.lblTimeEnd.TabIndex = 174;
            this.lblTimeEnd.Text = "End";
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeStart.Location = new System.Drawing.Point(112, 100);
            this.dtpTimeStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(91, 20);
            this.dtpTimeStart.TabIndex = 173;
            // 
            // dtpEnds
            // 
            this.dtpEnds.Enabled = false;
            this.dtpEnds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnds.Location = new System.Drawing.Point(112, 190);
            this.dtpEnds.Name = "dtpEnds";
            this.dtpEnds.Size = new System.Drawing.Size(234, 23);
            this.dtpEnds.TabIndex = 171;
            // 
            // dtpStarts
            // 
            this.dtpStarts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStarts.Location = new System.Drawing.Point(112, 162);
            this.dtpStarts.Name = "dtpStarts";
            this.dtpStarts.Size = new System.Drawing.Size(234, 23);
            this.dtpStarts.TabIndex = 170;
            // 
            // cmbRepeats
            // 
            this.cmbRepeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepeats.FormattingEnabled = true;
            this.cmbRepeats.Location = new System.Drawing.Point(140, 126);
            this.cmbRepeats.Name = "cmbRepeats";
            this.cmbRepeats.Size = new System.Drawing.Size(206, 25);
            this.cmbRepeats.TabIndex = 169;
            // 
            // lblEnds
            // 
            this.lblEnds.AutoSize = true;
            this.lblEnds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnds.Location = new System.Drawing.Point(63, 190);
            this.lblEnds.Name = "lblEnds";
            this.lblEnds.Size = new System.Drawing.Size(37, 17);
            this.lblEnds.TabIndex = 168;
            this.lblEnds.Text = "Ends";
            // 
            // lblStarts
            // 
            this.lblStarts.AutoSize = true;
            this.lblStarts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarts.Location = new System.Drawing.Point(58, 162);
            this.lblStarts.Name = "lblStarts";
            this.lblStarts.Size = new System.Drawing.Size(42, 17);
            this.lblStarts.TabIndex = 167;
            this.lblStarts.Text = "Starts";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.Location = new System.Drawing.Point(69, 100);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(37, 17);
            this.lblTimeStart.TabIndex = 166;
            this.lblTimeStart.Text = "Start";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepeat.Location = new System.Drawing.Point(45, 130);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRepeat.Size = new System.Drawing.Size(79, 21);
            this.chkRepeat.TabIndex = 165;
            this.chkRepeat.Text = "Repeats";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(112, 218);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(234, 93);
            this.txtDescription.TabIndex = 164;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(20, 221);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 163;
            this.lblDescription.Text = "Description";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(112, 71);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(234, 23);
            this.txtLocation.TabIndex = 161;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(41, 74);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 17);
            this.lblLocation.TabIndex = 162;
            this.lblLocation.Text = "Location";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(112, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 23);
            this.txtName.TabIndex = 159;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(58, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 160;
            this.lblName.Text = "Name";
            // 
            // AddEventTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 408);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveTemplate);
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
            this.Name = "AddEventTemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adding an Event Template";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSaveTemplate;
        public System.Windows.Forms.Button btnRemoveSlot;
        public System.Windows.Forms.Button btnAddSlot;
        public System.Windows.Forms.NumericUpDown numCapacity;
        public System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblAddSlot;
        public System.Windows.Forms.ListBox lstSlots;
        private System.Windows.Forms.Label lblEventDetails;
        public System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.Label lblTimeEnd;
        public System.Windows.Forms.DateTimePicker dtpTimeStart;
        public System.Windows.Forms.DateTimePicker dtpEnds;
        public System.Windows.Forms.DateTimePicker dtpStarts;
        public System.Windows.Forms.ComboBox cmbRepeats;
        private System.Windows.Forms.Label lblEnds;
        private System.Windows.Forms.Label lblStarts;
        private System.Windows.Forms.Label lblTimeStart;
        public System.Windows.Forms.CheckBox chkRepeat;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}