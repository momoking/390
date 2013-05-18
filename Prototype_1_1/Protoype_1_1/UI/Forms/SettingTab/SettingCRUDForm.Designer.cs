namespace Prototype1_1.UI.Forms.SettingTab
{
    partial class SettingCRUDForm
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
            this.crudView = new Prototype1_1.UI.Views.SettingTab.SettingCRUDView();
            this.SuspendLayout();
            // 
            // crudView
            // 
            this.crudView.Location = new System.Drawing.Point(12, 12);
            this.crudView.Name = "crudView";
            this.crudView.Size = new System.Drawing.Size(278, 136);
            this.crudView.TabIndex = 0;
            // 
            // SettingCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 158);
            this.Controls.Add(this.crudView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CRUD Item";
            this.ResumeLayout(false);

        }

        #endregion

        public Views.SettingTab.SettingCRUDView crudView;

    }
}