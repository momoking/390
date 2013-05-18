using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.UI.Views;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Prototype1_1.Data;
using System.Windows.Forms.Calendar;
using Prototype1_1.Data.EntityModel;
using Prototype1_1.UI.Views.EventsTab;

namespace Prototype1_1.Presenters.EventsTab
{
    class EventsPresenter
    {
        #region Attributes

        EventsView _view;
        soen390Entities _entities;
        static EventsPresenter _instance;
        List<@event> _eventList;

        #endregion

        #region Properties

        public EventsView View
        {
            get { return _view; }
        }

        public List<@event> EventList
        {
            get { return _eventList; }
            set { _eventList = value;}
        }

        #endregion

        #region Constructor and GetInstance()

        private EventsPresenter()
        {
           
        }

        public static EventsPresenter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EventsPresenter();
            }

            return _instance;
        }

        public void intializeView(EventsView aView)
        {
            _view = aView;
            _entities = EntityModel.getInstance()._soen390Entities;
            _eventList = _entities.@event.ToList();
            RefreshCalendar();
            AttachEventHandlers();
        }

        #endregion

        #region Methods

        private void AttachEventHandlers()
        {
            _view.Load += _view_Load;
            _view.monthCalendar.DateChanged += monthCalendar_DateChanged;
            _view.btnCreate.Click += btnCreate_Click;
            _view.btnUpdate.Click += btnUpdate_Click;
            _view.btnDelete.Click += DeleteEvent;
            _view.calendar.ItemDeleting += DeleteEvent;
        }

        void DeleteEvent(object sender, EventArgs e)
        {
            if (_view.calendar.GetSelectedItems().Count() > 0)
            {
                CalendarItem selectedEvent = _view.calendar.GetSelectedItems().First();
                if (selectedEvent != null)
                {
                    List<@event> toRemoveList = _entities.@event.Where(ev => ev.Name == selectedEvent.Text).ToList();
                    if (toRemoveList.Count > 0)
                    {
                        foreach (@event toRemove in toRemoveList)
                        {
                            foreach (slot s in toRemove.slot.ToList())
                                _entities.slot.Remove(s);
                            _entities.@event.Remove(toRemove);
                            RemoveFromList(toRemove);
                        }
                        _entities.SaveChanges();
                    }
                    RefreshCalendar();
                }
            }
        }

        private void RemoveFromList(@event toRemove)
        {
            foreach (@event ev in _eventList)
            {
                if (ev.Name == toRemove.Name && ev.Start == toRemove.Start && ev.End == toRemove.End)
                {
                    _eventList.Remove(ev);
                    break;
                }
            }
        }

        void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (_view.monthCalendar.SelectionStart.Date == _view.monthCalendar.SelectionEnd.Date)
            {
                DateTime date = this._view.monthCalendar.SelectionStart.Date;
                if (DateTime.Compare(date, _view.calendar.ViewStart) < 0)
                {
                    _view.calendar.ViewStart = date;
                    _view.calendar.ViewEnd = date.AddDays(3);
                }
                else
                {
                    _view.calendar.ViewEnd = date.AddDays(3);
                    _view.calendar.ViewStart = date;
                }
            }

            else
            {
                if (DateTime.Compare(_view.monthCalendar.SelectionStart, _view.calendar.ViewStart) < 0)
                {
                    _view.calendar.ViewStart = _view.monthCalendar.SelectionStart.Date;
                    _view.calendar.ViewEnd = _view.monthCalendar.SelectionEnd.Date;
                }
                else
                {
                    _view.calendar.ViewEnd = _view.monthCalendar.SelectionEnd.Date;
                    _view.calendar.ViewStart = _view.monthCalendar.SelectionStart.Date;
                }
            }
            RefreshCalendar();
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CalendarItem selectedEvent = _view.calendar.GetSelectedItems().First();
                @event toUpdate = _entities.@event.Where(ev => ev.Name == selectedEvent.Text && ev.Start == selectedEvent.StartDate && ev.End == selectedEvent.EndDate).First();

                if (toUpdate != null)
                {
                    UpdateEventPresenter updatePresenter = new UpdateEventPresenter(toUpdate);
                    updatePresenter.ShowDialog();
                    RefreshCalendar();
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Please select an event on the calendar first.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            CreateEventPresenter createEvent = new CreateEventPresenter();
            createEvent.ShowDialog();
        }

        void _view_Load(object sender, EventArgs e)
        {
            _view.monthCalendar.MaxSelectionCount = 15;
            _view.calendar.ViewStart = DateTime.Today;
            _view.calendar.ViewEnd = DateTime.Today.AddDays(3);
            RefreshCalendar();
        }

        public void AddEvents(List<@event> eventList)
        {
            _eventList = _eventList.Concat(eventList).ToList();
            RefreshCalendar();
        }

        private void RefreshCalendar()
        {
            List<@event> toDisplay = _eventList.Where(e => InCalendarRange(e) == true).ToList();
            _view.calendar.Items.Clear();
            foreach (@event ev in toDisplay)
            {
                CalendarItem calItem = new CalendarItem(_view.calendar, ev.Start.Value, ev.End.Value, ev.Name);
                _view.calendar.Items.Add(calItem);
            }

            _view.calendar.Refresh();
        }

        private bool InCalendarRange(@event ev)
        {
            return (ev.Start.Value >= _view.calendar.ViewStart) && (ev.End.Value < _view.calendar.ViewEnd);
        }

        #endregion
    }
}
