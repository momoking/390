using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.UI.Views;

namespace Prototype1_1.Presenters
{
    class AppointmentsPresenter
    {
        #region Attributes

        private static AppointmentsPresenter _instance;

        #endregion

        #region Constructor and getInstance()

        private AppointmentsPresenter()
        {
            attachEventsHandlers();
        }

        public static AppointmentsPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new AppointmentsPresenter();
            }

            return _instance;
        }

        #endregion

        #region Methods

        private void attachEventsHandlers()
        {

        }

        #endregion
    }
}
