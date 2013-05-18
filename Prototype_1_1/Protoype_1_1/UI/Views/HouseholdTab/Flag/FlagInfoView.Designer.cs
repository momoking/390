namespace Prototype1_1.UI.Views.HouseholdTab.Flag
{
    partial class FlagInfoView
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
            this.components = new System.ComponentModel.Container();
            this.dgvFlags = new System.Windows.Forms.DataGridView();
            this.FlagDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlagColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFlag = new System.Windows.Forms.GroupBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.tlt1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlags)).BeginInit();
            this.grpFlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlags
            // 
            this.dgvFlags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFlags.BackgroundColor = System.Drawing.Color.White;
            this.dgvFlags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlagDate,
            this.FlagColumn});
            this.dgvFlags.Location = new System.Drawing.Point(3, 56);
            this.dgvFlags.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFlags.Name = "dgvFlags";
            this.dgvFlags.RowHeadersVisible = false;
            this.dgvFlags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlags.Size = new System.Drawing.Size(224, 111);
            this.dgvFlags.TabIndex = 23;
            // 
            // FlagDate
            // 
            this.FlagDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FlagDate.DataPropertyName = "DateStamp";
            this.FlagDate.HeaderText = "Date";
            this.FlagDate.Name = "FlagDate";
            this.FlagDate.Width = 55;
            // 
            // FlagColumn
            // 
            this.FlagColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FlagColumn.DataPropertyName = "FlagInfo";
            this.FlagColumn.HeaderText = "Flag";
            this.FlagColumn.Name = "FlagColumn";
            this.FlagColumn.ReadOnly = true;
            // 
            // grpFlag
            // 
            this.grpFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpFlag.BackColor = System.Drawing.Color.White;
            this.grpFlag.Controls.Add(this.picDelete);
            this.grpFlag.Controls.Add(this.picEdit);
            this.grpFlag.Controls.Add(this.picAdd);
            this.grpFlag.Controls.Add(this.dgvFlags);
            this.grpFlag.Location = new System.Drawing.Point(0, 0);
            this.grpFlag.Name = "grpFlag";
            this.grpFlag.Size = new System.Drawing.Size(230, 170);
            this.grpFlag.TabIndex = 24;
            this.grpFlag.TabStop = false;
            this.grpFlag.Text = "Flag";
            // 
            // picDelete
            // 
            this.picDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDelete.BackColor = System.Drawing.Color.White;
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Enabled = false;
            this.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;
            this.picDelete.Location = new System.Drawing.Point(192, 19);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(32, 32);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 91;
            this.picDelete.TabStop = false;
            this.tlt1.SetToolTip(this.picDelete, "Delete selected flag.");
            // 
            // picEdit
            // 
            this.picEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picEdit.BackColor = System.Drawing.Color.White;
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Enabled = false;
            this.picEdit.Image = global::Prototype1_1.Properties.Resources.edit_icon;
            this.picEdit.Location = new System.Drawing.Point(44, 19);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(32, 32);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEdit.TabIndex = 90;
            this.picEdit.TabStop = false;
            this.tlt1.SetToolTip(this.picEdit, "Edit selected flag.");
            // 
            // picAdd
            // 
            this.picAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAdd.BackColor = System.Drawing.Color.White;
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Enabled = false;
            this.picAdd.Image = global::Prototype1_1.Properties.Resources.red_flag_icon1;
            this.picAdd.Location = new System.Drawing.Point(6, 19);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(32, 32);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 89;
            this.picAdd.TabStop = false;
            this.tlt1.SetToolTip(this.picAdd, "Add a new flag.");
            // 
            // FlagInfoView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grpFlag);
            this.Name = "FlagInfoView";
            this.Size = new System.Drawing.Size(230, 170);
            this.Load += new System.EventHandler(this.FlagInfoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlags)).EndInit();
            this.grpFlag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFlags;
        private System.Windows.Forms.GroupBox grpFlag;
        public System.Windows.Forms.PictureBox picDelete;
        public System.Windows.Forms.PictureBox picEdit;
        public System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlagDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlagColumn;
        private System.Windows.Forms.ToolTip tlt1;

    }
}
