using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI.Forms.EventsTab;
using Prototype1_1.Data;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.EventsTab
{
    class UpdateEventPresenter
    {
        #region Attributes

        FormUpdateEvent _view;
        soen390Entities _entities;
        @event _toUpdate;

        #endregion

        #region Constructor

        public UpdateEventPresenter(@event toUpdate)
        {
            _view = new FormUpdateEvent();
            _entities = EntityModel.getInstance()._soen390Entities;
            _toUpdate = toUpdate;
            AttachEventHandlers();
        }


        #endregion

        #region Methods

        private void AttachEventHandlers()
        {
            _view.Load += _view_Load;
            _view.btnUpdate.Click += btnUpdate_Click;
            _view.btnUpdateAll.Click += btnUpdateAll_Click;
            _view.btnCancel.Click += btnCancel_Click;
        }

        public void ShowDialog()
        {
            _view.ShowDialog();
        }

        void _view_Load(object sender, EventArgs e)
        {
            _view.txtName.Text = _toUpdate.Name;
            _view.txtLocation.Text = _toUpdate.Location;
            _view.txtDescription.Text = _toUpdate.Description;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            _view.Close();
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            @event toUpdate = _entities.@event.Where(ev => ev.Name == _toUpdate.Name && ev.Start == _toUpdate.Start && ev.End == _toUpdate.End).First();
            if (toUpdate != null)
            {
                toUpdate.Name = _view.txtName.Text;
                toUpdate.Location = _view.txtLocation.Text;
                toUpdate.Description = _view.txtDescription.Text;
                _entities.SaveChanges();
            }

            if (EventsPresenter.GetInstance().EventList.Count > 0)
            {
                foreach (@event ev in EventsPresenter.GetInstance().EventList)
                {
                    if (ev.Name == _toUpdate.Name && ev.Start == _toUpdate.Start && ev.End == _toUpdate.End)
                    {
                        ev.Name = _view.txtName.Text;
                        ev.Location = _view.txtLocation.Text;
                        ev.Description = _view.txtDescription.Text;
                        break;
                    }
                }
            }

            _view.Close();
        }

        void btnUpdateAll_Click(object sender, EventArgs e)
        {
            List<@event> toRemoveList = _entities.@event.Where(ev => ev.Name == _toUpdate.Name).ToList();
            if (toRemoveList.Count > 0)
            {
                foreach (@event toUpdate in toRemoveList)
                {
                    toUpdate.Name = _view.txtName.Text;
                    toUpdate.Location = _view.txtLocation.Text;
                    toUpdate.Description = _view.txtDescription.Text;
                }
                _entities.SaveChanges();
            }

            if (EventsPresenter.GetInstance().EventList.Count > 0)
            {
                foreach (@event ev in EventsPresenter.GetInstance().EventList)
                {
                    if (ev.Name == _toUpdate.Name)
                    {
                        ev.Name = _view.txtName.Text;
                        ev.Location = _view.txtLocation.Text;
                        ev.Description = _view.txtDescription.Text;
                    }
                }
            }
            _view.Close();
        }


        #endregion
    }
}
