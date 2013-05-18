namespace Prototype1_1.UI.Views.SubViews
{
    partial class s
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
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.EventNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.lstSlots = new System.Windows.Forms.ListBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblHouseholdID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventNameCol,
            this.DateCol,
            this.StartTimeCol,
            this.EndTimeCol});
            this.dgvEvents.Location = new System.Drawing.Point(20, 57);
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.Size = new System.Drawing.Size(592, 289);
            this.dgvEvents.TabIndex = 0;
            // 
            // EventNameCol
            // 
            this.EventNameCol.HeaderText = "Event";
            this.EventNameCol.Name = "EventNameCol";
            this.EventNameCol.ReadOnly = true;
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            // 
            // StartTimeCol
            // 
            this.StartTimeCol.HeaderText = "Start Time";
            this.StartTimeCol.Name = "StartTimeCol";
            this.StartTimeCol.ReadOnly = true;
            // 
            // EndTimeCol
            // 
            this.EndTimeCol.HeaderText = "End Time";
            this.EndTimeCol.Name = "EndTimeCol";
            this.EndTimeCol.ReadOnly = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(20, 684);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 46);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.Location = new System.Drawing.Point(512, 684);
            this.btnDeRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(100, 44);
            this.btnDeRegister.TabIndex = 2;
            this.btnDeRegister.Text = "De-Register";
            this.btnDeRegister.UseVisualStyleBackColor = true;
            // 
            // lstSlots
            // 
            this.lstSlots.FormattingEnabled = true;
            this.lstSlots.ItemHeight = 16;
            this.lstSlots.Location = new System.Drawing.Point(20, 415);
            this.lstSlots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSlots.Name = "lstSlots";
            this.lstSlots.Size = new System.Drawing.Size(591, 244);
            this.lstSlots.TabIndex = 3;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(16, 377);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(85, 17);
            this.lblEventName.TabIndex = 4;
            this.lblEventName.Text = "Event Name";
            // 
            // lblHouseholdID
            // 
            this.lblHouseholdID.AutoSize = true;
            this.lblHouseholdID.Location = new System.Drawing.Point(16, 16);
            this.lblHouseholdID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHouseholdID.Name = "lblHouseholdID";
            this.lblHouseholdID.Size = new System.Drawing.Size(93, 17);
            this.lblHouseholdID.TabIndex = 5;
            this.lblHouseholdID.Text = "Household ID";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHouseholdID);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lstSlots);
            this.Controls.Add(this.btnDeRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dgvEvents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "s";
            this.Size = new System.Drawing.Size(628, 769);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeCol;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.Button btnDeRegister;
        private System.Windows.Forms.ListBox lstSlots;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblHouseholdID;
    }
}
