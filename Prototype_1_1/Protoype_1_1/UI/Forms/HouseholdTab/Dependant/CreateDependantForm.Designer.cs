namespace Prototype1_1.UI.Forms.HouseholdTab.Dependant
{
    partial class CreateDependantForm
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
            this.createDependantInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Dependant.CreateDependantInfoView();
            this.SuspendLayout();
            // 
            // createDependantInfoView1
            // 
            this.createDependantInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createDependantInfoView1.Location = new System.Drawing.Point(0, 0);
            this.createDependantInfoView1.Name = "createDependantInfoView1";
            this.createDependantInfoView1.Size = new System.Drawing.Size(510, 181);
            this.createDependantInfoView1.TabIndex = 0;
            // 
            // CreateDependantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 181);
            this.Controls.Add(this.createDependantInfoView1);
            this.Name = "CreateDependantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Dependant.CreateDependantInfoView createDependantInfoView1;







    }
}