using Prototype1_1.UI.Views;

namespace Prototype1_1.UI.Forms
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.searchView1 = new Prototype1_1.UI.Views.SearchTab.SearchView();
            this.tabHousehold = new System.Windows.Forms.TabPage();
            this.householdTabView1 = new Prototype1_1.UI.Views.HouseholdTab.HouseholdTabView();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.eventsView1 = new Prototype1_1.UI.Views.EventsTab.EventsView();
            this.button6 = new System.Windows.Forms.Button();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnReportOK = new System.Windows.Forms.Button();
            this.cmbReportSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.settingGeneralView1 = new Prototype1_1.UI.Views.SettingTab.SettingGeneralView();
            this.imglTab = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabHousehold.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.Controls.Add(this.tabHousehold);
            this.tabControl.Controls.Add(this.tabEvents);
            this.tabControl.Controls.Add(this.tabReports);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.HotTrack = true;
            this.tabControl.ImageList = this.imglTab;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(15, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(964, 742);
            this.tabControl.TabIndex = 6;
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.White;
            this.tabSearch.Controls.Add(this.searchView1);
            this.tabSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.ImageIndex = 0;
            this.tabSearch.Location = new System.Drawing.Point(4, 56);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(956, 682);
            this.tabSearch.TabIndex = 5;
            this.tabSearch.Text = "[F1]";
            // 
            // searchView1
            // 
            this.searchView1.BackColor = System.Drawing.Color.White;
            this.searchView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchView1.Location = new System.Drawing.Point(0, 0);
            this.searchView1.Margin = new System.Windows.Forms.Padding(2);
            this.searchView1.Name = "searchView1";
            this.searchView1.Size = new System.Drawing.Size(956, 682);
            this.searchView1.TabIndex = 0;
            // 
            // tabHousehold
            // 
            this.tabHousehold.BackColor = System.Drawing.Color.White;
            this.tabHousehold.Controls.Add(this.householdTabView1);
            this.tabHousehold.ImageIndex = 2;
            this.tabHousehold.Location = new System.Drawing.Point(4, 56);
            this.tabHousehold.Name = "tabHousehold";
            this.tabHousehold.Padding = new System.Windows.Forms.Padding(3);
            this.tabHousehold.Size = new System.Drawing.Size(956, 682);
            this.tabHousehold.TabIndex = 0;
            this.tabHousehold.Text = "[F2]";
            // 
            // householdTabView1
            // 
            this.householdTabView1.BackColor = System.Drawing.Color.White;
            this.householdTabView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.householdTabView1.Location = new System.Drawing.Point(3, 3);
            this.householdTabView1.Margin = new System.Windows.Forms.Padding(3, 315, 3, 315);
            this.householdTabView1.Name = "householdTabView1";
            this.householdTabView1.Size = new System.Drawing.Size(950, 676);
            this.householdTabView1.TabIndex = 0;
            // 
            // tabEvents
            // 
            this.tabEvents.BackColor = System.Drawing.Color.White;
            this.tabEvents.Controls.Add(this.eventsView1);
            this.tabEvents.Controls.Add(this.button6);
            this.tabEvents.ImageIndex = 3;
            this.tabEvents.Location = new System.Drawing.Point(4, 56);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(956, 682);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "[F3]";
            // 
            // eventsView1
            // 
            this.eventsView1.BackColor = System.Drawing.Color.White;
            this.eventsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsView1.Location = new System.Drawing.Point(3, 3);
            this.eventsView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.eventsView1.Name = "eventsView1";
            this.eventsView1.Size = new System.Drawing.Size(950, 676);
            this.eventsView1.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(617, 689);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(0, 0);
            this.button6.TabIndex = 17;
            this.button6.Text = "&Save as new";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.White;
            this.tabReports.Controls.Add(this.btnReportOK);
            this.tabReports.Controls.Add(this.cmbReportSelector);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.ImageIndex = 4;
            this.tabReports.Location = new System.Drawing.Point(4, 56);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(956, 682);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "[F4]";
            this.tabReports.Click += new System.EventHandler(this.tabReports_Click);
            // 
            // btnReportOK
            // 
            this.btnReportOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReportOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnReportOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportOK.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnReportOK.Location = new System.Drawing.Point(603, 21);
            this.btnReportOK.Name = "btnReportOK";
            this.btnReportOK.Size = new System.Drawing.Size(73, 25);
            this.btnReportOK.TabIndex = 13;
            this.btnReportOK.Text = "OK";
            this.btnReportOK.UseVisualStyleBackColor = true;
            // 
            // cmbReportSelector
            // 
            this.cmbReportSelector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbReportSelector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportSelector.FormattingEnabled = true;
            this.cmbReportSelector.Location = new System.Drawing.Point(372, 21);
            this.cmbReportSelector.Name = "cmbReportSelector";
            this.cmbReportSelector.Size = new System.Drawing.Size(225, 25);
            this.cmbReportSelector.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Report Template";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.settingGeneralView1);
            this.tabSettings.ImageIndex = 5;
            this.tabSettings.Location = new System.Drawing.Point(4, 56);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(956, 682);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "[F5]";
            // 
            // settingGeneralView1
            // 
            this.settingGeneralView1.BackColor = System.Drawing.Color.White;
            this.settingGeneralView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingGeneralView1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingGeneralView1.Location = new System.Drawing.Point(0, 0);
            this.settingGeneralView1.Name = "settingGeneralView1";
            this.settingGeneralView1.Size = new System.Drawing.Size(956, 682);
            this.settingGeneralView1.TabIndex = 1;
            // 
            // imglTab
            // 
            this.imglTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglTab.ImageStream")));
            this.imglTab.TransparentColor = System.Drawing.Color.White;
            this.imglTab.Images.SetKeyName(0, "search-icon.png");
            this.imglTab.Images.SetKeyName(1, "family-icon.png");
            this.imglTab.Images.SetKeyName(2, "home-icon.png");
            this.imglTab.Images.SetKeyName(3, "event-icon.png");
            this.imglTab.Images.SetKeyName(4, "report-ico.png");
            this.imglTab.Images.SetKeyName(5, "setting-icon.png");
            this.imglTab.Images.SetKeyName(6, "plus-icon.png");
            this.imglTab.Images.SetKeyName(7, "edit-icon.png");
            this.imglTab.Images.SetKeyName(8, "remove-icon.png");
            // 
            // MainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 742);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Services Tracking System";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabHousehold.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.TabPage tabSearch;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabHousehold;
        public System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.ImageList imglTab;
        public Views.SearchTab.SearchView searchView1;
        public Views.HouseholdTab.HouseholdTabView householdTabView1;        
        public System.Windows.Forms.ComboBox cmbReportSelector;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnReportOK;
        public System.Windows.Forms.TabPage tabSettings;
        public Views.SettingTab.SettingGeneralView settingGeneralView1;
        public Views.EventsTab.EventsView eventsView1;
    }
}

