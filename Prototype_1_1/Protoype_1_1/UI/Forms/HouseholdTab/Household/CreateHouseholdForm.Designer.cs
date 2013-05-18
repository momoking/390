namespace Prototype1_1.UI.Forms.HouseholdTab.Household
{
    partial class CreateHouseholdForm
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
            this.createHouseholdInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Household.CreateHouseholdInfoView();
            this.SuspendLayout();
            // 
            // createHouseholdInfoView1
            // 
            this.createHouseholdInfoView1.BackColor = System.Drawing.Color.White;
            this.createHouseholdInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createHouseholdInfoView1.Location = new System.Drawing.Point(0, 0);
            this.createHouseholdInfoView1.Name = "createHouseholdInfoView1";
            this.createHouseholdInfoView1.Size = new System.Drawing.Size(495, 244);
            this.createHouseholdInfoView1.TabIndex = 0;
            // 
            // CreateHouseholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 244);
            this.Controls.Add(this.createHouseholdInfoView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateHouseholdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Household";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Household.CreateHouseholdInfoView createHouseholdInfoView1;




    }
}