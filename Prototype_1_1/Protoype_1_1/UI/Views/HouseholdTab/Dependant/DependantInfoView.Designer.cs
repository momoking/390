namespace Prototype1_1.UI.Views.HouseholdTab.Dependant
{
    partial class DependantInfoView
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
            this.dgvDependants = new System.Windows.Forms.DataGridView();
            this.gpbDependant = new System.Windows.Forms.GroupBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.tlt1 = new System.Windows.Forms.ToolTip(this.components);
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependants)).BeginInit();
            this.gpbDependant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDependants
            // 
            this.dgvDependants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDependants.BackgroundColor = System.Drawing.Color.White;
            this.dgvDependants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameColumn,
            this.MedicareColumn,
            this.GenderColumn});
            this.dgvDependants.GridColor = System.Drawing.Color.Gray;
            this.dgvDependants.Location = new System.Drawing.Point(2, 52);
            this.dgvDependants.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDependants.MultiSelect = false;
            this.dgvDependants.Name = "dgvDependants";
            this.dgvDependants.ReadOnly = true;
            this.dgvDependants.RowHeadersVisible = false;
            this.dgvDependants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDependants.Size = new System.Drawing.Size(220, 112);
            this.dgvDependants.TabIndex = 2;
            // 
            // gpbDependant
            // 
            this.gpbDependant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbDependant.BackColor = System.Drawing.Color.White;
            this.gpbDependant.Controls.Add(this.picDelete);
            this.gpbDependant.Controls.Add(this.picEdit);
            this.gpbDependant.Controls.Add(this.picAdd);
            this.gpbDependant.Controls.Add(this.dgvDependants);
            this.gpbDependant.Location = new System.Drawing.Point(3, 3);
            this.gpbDependant.Name = "gpbDependant";
            this.gpbDependant.Size = new System.Drawing.Size(227, 164);
            this.gpbDependant.TabIndex = 1;
            this.gpbDependant.TabStop = false;
            this.gpbDependant.Text = "Dependants Information";
            // 
            // picDelete
            // 
            this.picDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDelete.BackColor = System.Drawing.Color.White;
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Enabled = false;
            this.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;
            this.picDelete.Location = new System.Drawing.Point(190, 14);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(32, 32);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 88;
            this.picDelete.TabStop = false;
            this.tlt1.SetToolTip(this.picDelete, "Delete selected dependant.");
            // 
            // picEdit
            // 
            this.picEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picEdit.BackColor = System.Drawing.Color.White;
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Enabled = false;
            this.picEdit.Image = global::Prototype1_1.Properties.Resources.edit_icon;
            this.picEdit.Location = new System.Drawing.Point(42, 14);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(32, 32);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEdit.TabIndex = 87;
            this.picEdit.TabStop = false;
            this.tlt1.SetToolTip(this.picEdit, "Edit selected dependant.");
            // 
            // picAdd
            // 
            this.picAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAdd.BackColor = System.Drawing.Color.White;
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Enabled = false;
            this.picAdd.Image = global::Prototype1_1.Properties.Resources.add_dependandt_icon;
            this.picAdd.Location = new System.Drawing.Point(4, 14);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(32, 32);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 86;
            this.picAdd.TabStop = false;
            this.tlt1.SetToolTip(this.picAdd, "Add a dependant.");
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "Name";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // MedicareColumn
            // 
            this.MedicareColumn.DataPropertyName = "Medicare";
            this.MedicareColumn.HeaderText = "Medicare";
            this.MedicareColumn.Name = "MedicareColumn";
            this.MedicareColumn.ReadOnly = true;
            // 
            // GenderColumn
            // 
            this.GenderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GenderColumn.DataPropertyName = "Gender";
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            // 
            // DependantInfoView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gpbDependant);
            this.Name = "DependantInfoView";
            this.Size = new System.Drawing.Size(230, 170);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependants)).EndInit();
            this.gpbDependant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDependants;
        private System.Windows.Forms.GroupBox gpbDependant;
        public System.Windows.Forms.PictureBox picAdd;
        public System.Windows.Forms.PictureBox picEdit;
        public System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.ToolTip tlt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;

    }
}
