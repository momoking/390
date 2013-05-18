namespace Prototype1_1.UI.Forms.HouseholdTab.Dependant
{
    partial class UpdateDependantForm
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
            this.updateDependantInfoView1 = new Prototype1_1.UI.Views.HouseholdTab.Dependant.UpdateDependantInfoView();
            this.SuspendLayout();
            // 
            // updateDependantInfoView1
            // 
            this.updateDependantInfoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateDependantInfoView1.Location = new System.Drawing.Point(0, 0);
            this.updateDependantInfoView1.Name = "updateDependantInfoView1";
            this.updateDependantInfoView1.Size = new System.Drawing.Size(524, 182);
            this.updateDependantInfoView1.TabIndex = 0;
            // 
            // UpdateDependantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 182);
            this.Controls.Add(this.updateDependantInfoView1);
            this.Name = "UpdateDependantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDependantForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.HouseholdTab.Dependant.UpdateDependantInfoView updateDependantInfoView1;

    }
}