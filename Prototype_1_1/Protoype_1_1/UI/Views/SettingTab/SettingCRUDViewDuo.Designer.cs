namespace Prototype1_1.UI.Views.SettingTab
{
    partial class SettingCRUDViewDuo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItem = new System.Windows.Forms.Label();
            this.txtFieldPrimary = new System.Windows.Forms.TextBox();
            this.txtFieldSecondary = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(3, 19);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(47, 17);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "label1";
            // 
            // txtFieldPrimary
            // 
            this.txtFieldPrimary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldPrimary.Location = new System.Drawing.Point(6, 39);
            this.txtFieldPrimary.Name = "txtFieldPrimary";
            this.txtFieldPrimary.Size = new System.Drawing.Size(165, 27);
            this.txtFieldPrimary.TabIndex = 1;
            // 
            // txtFieldSecondary
            // 
            this.txtFieldSecondary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldSecondary.Location = new System.Drawing.Point(177, 39);
            this.txtFieldSecondary.Name = "txtFieldSecondary";
            this.txtFieldSecondary.Size = new System.Drawing.Size(102, 27);
            this.txtFieldSecondary.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOK.Location = new System.Drawing.Point(6, 95);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 27);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(193, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 27);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem2.Location = new System.Drawing.Point(174, 19);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(47, 17);
            this.lblItem2.TabIndex = 15;
            this.lblItem2.Text = "label2";
            // 
            // SettingCRUDViewDuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblItem2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFieldSecondary);
            this.Controls.Add(this.txtFieldPrimary);
            this.Controls.Add(this.lblItem);
            this.Name = "SettingCRUDViewDuo";
            this.Size = new System.Drawing.Size(289, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtFieldPrimary;
        public System.Windows.Forms.TextBox txtFieldSecondary;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblItem;
        public System.Windows.Forms.Label lblItem2;
    }
}
