namespace Prototype1_1.UI.Forms
{
    partial class FormRegisterToEvent
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
            this.registerToEventSubView1 = new Prototype1_1.UI.Views.SubViews.RegisterToEventSubView();
            this.SuspendLayout();
            // 
            // registerToEventSubView1
            // 
            this.registerToEventSubView1.Location = new System.Drawing.Point(12, 12);
            this.registerToEventSubView1.Name = "registerToEventSubView1";
            this.registerToEventSubView1.Size = new System.Drawing.Size(242, 359);
            this.registerToEventSubView1.TabIndex = 0;
            // 
            // FormRegisterToEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 365);
            this.Controls.Add(this.registerToEventSubView1);
            this.Name = "FormRegisterToEvent";
            this.Text = "Register To Event";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.SubViews.RegisterToEventSubView registerToEventSubView1;
    }
}