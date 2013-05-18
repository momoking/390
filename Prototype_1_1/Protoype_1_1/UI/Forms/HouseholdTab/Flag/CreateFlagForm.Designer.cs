namespace Prototype1_1.UI.Forms.HouseholdTab.Flag
{
    partial class CreateFlagForm
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
            this.createFlagInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Flag.CreateFlagInfoView();
            this.SuspendLayout();
            // 
            // createFlagInfoView1
            // 
            this.createFlagInfoView1.BackColor = System.Drawing.Color.White;
            this.createFlagInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createFlagInfoView1.Location = new System.Drawing.Point(0, 0);
            this.createFlagInfoView1.Name = "createFlagInfoView1";
            this.createFlagInfoView1.Size = new System.Drawing.Size(603, 268);
            this.createFlagInfoView1.TabIndex = 0;
            // 
            // CreateFlagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 268);
            this.Controls.Add(this.createFlagInfoView1);
            this.Name = "CreateFlagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateFlagForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Flag.CreateFlagInfoView createFlagInfoView1;

    }
}