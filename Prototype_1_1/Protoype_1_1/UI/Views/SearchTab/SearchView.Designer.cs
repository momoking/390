namespace Prototype1_1.UI.Views.SearchTab
{
    partial class SearchView
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
            this.txtSearchHint = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pbxLoader = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchHint
            // 
            this.txtSearchHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchHint.AutoSize = true;
            this.txtSearchHint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHint.Location = new System.Drawing.Point(1, 101);
            this.txtSearchHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSearchHint.Name = "txtSearchHint";
            this.txtSearchHint.Size = new System.Drawing.Size(489, 17);
            this.txtSearchHint.TabIndex = 9;
            this.txtSearchHint.Text = "(Search by name, household ID, medicare number, postal code or phone number)";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(4, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(512, 41);
            this.txtSearch.TabIndex = 5;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(4, 139);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvResults.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(622, 390);
            this.dgvResults.TabIndex = 8;
            // 
            // pbxLoader
            // 
            this.pbxLoader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxLoader.Image = global::Prototype1_1.Properties.Resources.loader_gif;
            this.pbxLoader.Location = new System.Drawing.Point(4, 139);
            this.pbxLoader.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLoader.Name = "pbxLoader";
            this.pbxLoader.Size = new System.Drawing.Size(622, 390);
            this.pbxLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLoader.TabIndex = 10;
            this.pbxLoader.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Location = new System.Drawing.Point(521, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 41);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // SearchView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchHint);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbxLoader);
            this.Controls.Add(this.dgvResults);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchView";
            this.Size = new System.Drawing.Size(629, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSearchHint;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dgvResults;
        public System.Windows.Forms.PictureBox pbxLoader;
        public System.Windows.Forms.Button btnSearch;

    }
}
