namespace Prototype1_1.UI.Forms.HouseholdTab.Note
{
    partial class UpdateNoteInfoForm
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
            this.updateNoteInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Note.UpdateNoteInfoView();
            this.SuspendLayout();
            // 
            // updateNoteInfoView1
            // 
            this.updateNoteInfoView1.BackColor = System.Drawing.Color.White;
            this.updateNoteInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateNoteInfoView1.Location = new System.Drawing.Point(0, 0);
            this.updateNoteInfoView1.Name = "updateNoteInfoView1";
            this.updateNoteInfoView1.Size = new System.Drawing.Size(602, 277);
            this.updateNoteInfoView1.TabIndex = 0;
            // 
            // UpdateNoteInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 277);
            this.Controls.Add(this.updateNoteInfoView1);
            this.Name = "UpdateNoteInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateNoteInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Note.UpdateNoteInfoView updateNoteInfoView1;

    }
}