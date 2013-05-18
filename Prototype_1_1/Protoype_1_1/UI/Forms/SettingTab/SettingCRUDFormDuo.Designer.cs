namespace Prototype1_1.UI.Forms.SettingTab
{
    partial class SettingCRUDFormDuo
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
            this.crudViewDuo = new Prototype1_1.UI.Views.SettingTab.SettingCRUDViewDuo();
            this.SuspendLayout();
            // 
            // crudViewDuo
            // 
            this.crudViewDuo.BackColor = System.Drawing.Color.White;
            this.crudViewDuo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudViewDuo.Location = new System.Drawing.Point(0, 0);
            this.crudViewDuo.Name = "crudViewDuo";
            this.crudViewDuo.Size = new System.Drawing.Size(291, 131);
            this.crudViewDuo.TabIndex = 0;
            // 
            // SettingCRUDFormDuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 131);
            this.Controls.Add(this.crudViewDuo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingCRUDFormDuo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingCRUDFormDuo";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.SettingTab.SettingCRUDViewDuo crudViewDuo;

    }
}