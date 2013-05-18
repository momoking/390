namespace Prototype1_1.UI.Forms.HouseholdTab.Household
{
    partial class UpdateHouseholdForm
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
            this.updateHouseholdInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Household.UpdateHouseholdInfoView();
            this.SuspendLayout();
            // 
            // updateHouseholdInfoView1
            // 
            this.updateHouseholdInfoView1.BackColor = System.Drawing.Color.White;
            this.updateHouseholdInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateHouseholdInfoView1.Location = new System.Drawing.Point(0, 0);
            this.updateHouseholdInfoView1.Name = "updateHouseholdInfoView1";
            this.updateHouseholdInfoView1.Size = new System.Drawing.Size(495, 244);
            this.updateHouseholdInfoView1.TabIndex = 0;
            // 
            // UpdateHouseholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 244);
            this.Controls.Add(this.updateHouseholdInfoView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateHouseholdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Household";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Household.UpdateHouseholdInfoView updateHouseholdInfoView1;






    }
}