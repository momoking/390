namespace Prototype1_1.UI.Forms.HouseholdTab.HouseholdAndClient
{
    partial class CreateHouseholdAndClientForm
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
            this.createHouseholdAndClientView1 = new Prototype1_1.UI.Views.HouseholdTab.HouseholdAndClient.CreateHouseholdAndClientView();
            this.SuspendLayout();
            // 
            // createHouseholdAndClientView1
            // 
            this.createHouseholdAndClientView1.BackColor = System.Drawing.Color.White;
            this.createHouseholdAndClientView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createHouseholdAndClientView1.Location = new System.Drawing.Point(0, 0);
            this.createHouseholdAndClientView1.Name = "createHouseholdAndClientView1";
            this.createHouseholdAndClientView1.Size = new System.Drawing.Size(571, 527);
            this.createHouseholdAndClientView1.TabIndex = 0;
            // 
            // CreateHouseholdAndClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 527);
            this.Controls.Add(this.createHouseholdAndClientView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateHouseholdAndClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Household";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.HouseholdAndClient.CreateHouseholdAndClientView createHouseholdAndClientView1;

    }
}