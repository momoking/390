namespace Prototype1_1.UI.Forms.HouseholdTab.Note
{
    partial class CreateNoteInfoForm
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
            this.createNoteInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Note.CreateNoteInfoView();
            this.SuspendLayout();
            // 
            // createNoteInfoView1
            // 
            this.createNoteInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createNoteInfoView1.Location = new System.Drawing.Point(0, 0);
            this.createNoteInfoView1.Name = "createNoteInfoView1";
            this.createNoteInfoView1.Size = new System.Drawing.Size(602, 277);
            this.createNoteInfoView1.TabIndex = 0;
            // 
            // CreateNoteInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 277);
            this.Controls.Add(this.createNoteInfoView1);
            this.Name = "CreateNoteInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNoteInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Note.CreateNoteInfoView createNoteInfoView1;

    }
}