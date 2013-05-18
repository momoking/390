namespace Prototype1_1.UI.Views.EventsTab
{
    partial class EventsView
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange8 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange9 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange10 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingEvents.Location = new System.Drawing.Point(3, 0);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(164, 21);
            this.lblUpcomingEvents.TabIndex = 68;
            this.lblUpcomingEvents.Text = "UPCOMING EVENTS";
            // 
            // calendar
            // 
            this.calendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange8.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange8.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange8.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange9.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange9.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange9.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange10.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange10.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange10.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange6,
        calendarHighlightRange7,
        calendarHighlightRange8,
        calendarHighlightRange9,
        calendarHighlightRange10};
            this.calendar.Location = new System.Drawing.Point(2, 27);
            this.calendar.Margin = new System.Windows.Forms.Padding(2);
            this.calendar.MaximumFullDays = 5;
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(546, 578);
            this.calendar.TabIndex = 94;
            this.calendar.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar.Location = new System.Drawing.Point(569, 27);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 95;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCreate.Location = new System.Drawing.Point(569, 439);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(227, 41);
            this.btnCreate.TabIndex = 151;
            this.btnCreate.Text = "&CREATE EVENT";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(569, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(227, 41);
            this.btnUpdate.TabIndex = 152;
            this.btnUpdate.Text = "&UPDATE EVENT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Location = new System.Drawing.Point(569, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 41);
            this.btnDelete.TabIndex = 153;
            this.btnDelete.Text = "&DELETE EVENT";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // EventsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Name = "EventsView";
            this.Size = new System.Drawing.Size(813, 607);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpcomingEvents;
        public System.Windows.Forms.Calendar.Calendar calendar;
        public System.Windows.Forms.MonthCalendar monthCalendar;
        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;

    }
}
