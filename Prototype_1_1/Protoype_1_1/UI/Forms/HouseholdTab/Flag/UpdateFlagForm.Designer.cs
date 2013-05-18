namespace Prototype1_1.UI.Forms.HouseholdTab.Flag
{
    partial class UpdateFlagForm
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
            this.updateFlagInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Flag.UpdateFlagInfoView();
            this.SuspendLayout();
            // 
            // updateFlagInfoView1
            // 
            this.updateFlagInfoView1.BackColor = System.Drawing.Color.White;
            this.updateFlagInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateFlagInfoView1.Location = new System.Drawing.Point(0, 0);
            this.updateFlagInfoView1.Name = "updateFlagInfoView1";
            this.updateFlagInfoView1.Size = new System.Drawing.Size(606, 262);
            this.updateFlagInfoView1.TabIndex = 0;
            // 
            // UpdateFlagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 262);
            this.Controls.Add(this.updateFlagInfoView1);
            this.Name = "UpdateFlagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateFlagForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Flag.UpdateFlagInfoView updateFlagInfoView1;

    }
}