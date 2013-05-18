namespace Prototype1_1.UI.Views
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
            this.lblBarUpcomingEvents = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingEvents.Location = new System.Drawing.Point(3, 0);
            this.lblUpcomingEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(198, 23);
            this.lblUpcomingEvents.TabIndex = 68;
            this.lblUpcomingEvents.Text = "UPCOMING EVENTS";
            // 
            // lblBarUpcomingEvents
            // 
            this.lblBarUpcomingEvents.BackColor = System.Drawing.Color.Black;
            this.lblBarUpcomingEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBarUpcomingEvents.Location = new System.Drawing.Point(8, 23);
            this.lblBarUpcomingEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarUpcomingEvents.Name = "lblBarUpcomingEvents";
            this.lblBarUpcomingEvents.Size = new System.Drawing.Size(526, 2);
            this.lblBarUpcomingEvents.TabIndex = 69;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 2;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(791, 443);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 55);
            this.btnCreate.TabIndex = 91;
            this.btnCreate.Text = "&CREATE EVENT";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // calendar
            // 
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
            this.calendar.Location = new System.Drawing.Point(8, 33);
            this.calendar.MaximumFullDays = 5;
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(771, 705);
            this.calendar.TabIndex = 94;
            this.calendar.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar.Location = new System.Drawing.Point(791, 33);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 95;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(791, 506);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 55);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.White;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.FlatAppearance.BorderSize = 2;
            this.btnDeleteAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAll.Location = new System.Drawing.Point(911, 506);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(112, 55);
            this.btnDeleteAll.TabIndex = 97;
            this.btnDeleteAll.Text = "DELETE &ALL";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(911, 443);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 55);
            this.btnUpdate.TabIndex = 98;
            this.btnUpdate.Text = "&UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // EventsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblBarUpcomingEvents);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventsView";
            this.Size = new System.Drawing.Size(1128, 881);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpcomingEvents;
        private System.Windows.Forms.Label lblBarUpcomingEvents;
        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.Calendar.Calendar calendar;
        public System.Windows.Forms.MonthCalendar monthCalendar;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnDeleteAll;
        public System.Windows.Forms.Button btnUpdate;

    }
}
