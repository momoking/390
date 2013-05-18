namespace Prototype1_1.UI.Forms.HouseholdTab.HouseholdAndClient
{
    partial class UpdateHouseholdAndClientForm
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
            this.updateHouseholdAndClientView1 = new Prototype1_1.UI.Views.HouseholdTab.HouseholdAndClient.UpdateHouseholdAndClientView();
            this.SuspendLayout();
            // 
            // updateHouseholdAndClientView1
            // 
            this.updateHouseholdAndClientView1.BackColor = System.Drawing.Color.White;
            this.updateHouseholdAndClientView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateHouseholdAndClientView1.Location = new System.Drawing.Point(0, 0);
            this.updateHouseholdAndClientView1.Name = "updateHouseholdAndClientView1";
            this.updateHouseholdAndClientView1.Size = new System.Drawing.Size(564, 498);
            this.updateHouseholdAndClientView1.TabIndex = 0;
            // 
            // UpdateHouseholdAndClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 498);
            this.Controls.Add(this.updateHouseholdAndClientView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateHouseholdAndClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Household Information";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.HouseholdAndClient.UpdateHouseholdAndClientView updateHouseholdAndClientView1;

    }
}