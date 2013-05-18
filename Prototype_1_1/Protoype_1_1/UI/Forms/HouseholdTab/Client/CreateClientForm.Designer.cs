namespace Prototype1_1.UI.Forms.HouseholdTab.Client
{
    partial class CreateClientForm
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
            this.createClientInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Client.UpdateClientInfoView();
            this.SuspendLayout();
            // 
            // createClientInfoView1
            // 
            this.createClientInfoView1.BackColor = System.Drawing.Color.White;
            this.createClientInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createClientInfoView1.Location = new System.Drawing.Point(0, 0);
            this.createClientInfoView1.Name = "createClientInfoView1";
            this.createClientInfoView1.Size = new System.Drawing.Size(521, 318);
            this.createClientInfoView1.TabIndex = 0;
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 318);
            this.Controls.Add(this.createClientInfoView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Client";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Client.UpdateClientInfoView createClientInfoView1;






    }
}