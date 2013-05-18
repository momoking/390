namespace Prototype1_1.UI.Views.HouseholdTab.Note
{
    partial class NoteInfoView
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
            this.grpNote = new System.Windows.Forms.GroupBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNote
            // 
            this.grpNote.BackColor = System.Drawing.Color.White;
            this.grpNote.Controls.Add(this.picDelete);
            this.grpNote.Controls.Add(this.picEdit);
            this.grpNote.Controls.Add(this.picAdd);
            this.grpNote.Controls.Add(this.dgvNotes);
            this.grpNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNote.Location = new System.Drawing.Point(0, 0);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(531, 170);
            this.grpNote.TabIndex = 2;
            this.grpNote.TabStop = false;
            this.grpNote.Text = "Notes";
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Enabled = false;
            this.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;
            this.picDelete.Location = new System.Drawing.Point(470, 18);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(32, 32);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 91;
            this.picDelete.TabStop = false;
            // 
            // picEdit
            // 
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Enabled = false;
            this.picEdit.Image = global::Prototype1_1.Properties.Resources.edit_icon;
            this.picEdit.Location = new System.Drawing.Point(43, 19);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(32, 31);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEdit.TabIndex = 89;
            this.picEdit.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Enabled = false;
            this.picAdd.Image = global::Prototype1_1.Properties.Resources.note_add1;
            this.picAdd.InitialImage = global::Prototype1_1.Properties.Resources.note_add1;
            this.picAdd.Location = new System.Drawing.Point(6, 18);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(31, 32);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 90;
            this.picAdd.TabStop = false;
            // 
            // dgvNotes
            // 
            this.dgvNotes.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.OperatorColumn,
            this.NoteColumn});
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNotes.Location = new System.Drawing.Point(3, 56);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(525, 111);
            this.dgvNotes.TabIndex = 2;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DateColumn.DataPropertyName = "DateStamp";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 55;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OperatorColumn.DataPropertyName = "ModifiedBy";
            this.OperatorColumn.HeaderText = "Operator";
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.Width = 73;
            // 
            // NoteColumn
            // 
            this.NoteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoteColumn.DataPropertyName = "NoteInfo";
            this.NoteColumn.HeaderText = "Note";
            this.NoteColumn.Name = "NoteColumn";
            // 
            // NoteInfoView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grpNote);
            this.Name = "NoteInfoView";
            this.Size = new System.Drawing.Size(531, 170);
            this.grpNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvNotes;
        public System.Windows.Forms.PictureBox picEdit;
        public System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteColumn;
        public System.Windows.Forms.PictureBox picDelete;
        public System.Windows.Forms.GroupBox grpNote;




    }
}
