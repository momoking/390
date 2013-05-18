using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype1_1.UI;
using Prototype1_1.UI.Forms;
using Prototype1_1.Presenters.HouseholdTab;
using Prototype1_1.Presenters.SettingTab;
using Prototype1_1.Presenters.SearchTab;
using Prototype1_1.Presenters.EventsTab;


namespace Prototype1_1.Presenters
{
    class MainPresenter
    {
        #region Attributes

        static MainPresenter _instance;
        MainView _view;

        #endregion

        #region Properties

        public MainView View
        {
            get { return _view; }
        }

        #endregion

        #region Constructor

        private MainPresenter()
        {
            _view = new MainView();

            if (!Prototype1_1.Utilities.SecurityAPI.IsUserAdministrator())
            {
                _view.tabControl.TabPages.RemoveByKey("tabSettings");
            }

            HouseholdTabPresenter.getInstance().initializeView(_view.householdTabView1);
            SearchPresenter.getInstance().initializeView(_view.searchView1);
            EventsPresenter.GetInstance().intializeView(_view.eventsView1);
            SettingPresenter.getInstance().initializeView(_view.settingGeneralView1);
            
            AttachEventHandlers();
        }

        public static MainPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new MainPresenter();
            }

            return _instance;
        }
        #endregion

        #region Methods

        private void AttachEventHandlers()
        {
            _view.KeyDown += new KeyEventHandler(View_KeyDown);
        }

        #endregion

        #region Methods

        public void SelectTab(String name)
        {
            _view.tabControl.SelectTab(name);
        }

        void View_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    SelectTab("tabSearch");
                    e.Handled = true;
                    break;
                case Keys.F2:
                    SelectTab("tabHousehold");
                    e.Handled = true;
                    break;
                case Keys.F3:
                    SelectTab("tabEvents");
                    e.Handled = true;
                    break;
                case Keys.F4:
                  SelectTab("tabReports"); 
                  e.Handled = true; 
                  break;
                case Keys.F5:
                  SelectTab("tabSettings"); 
                  e.Handled = true; 
                  break;
            }
        }

        #endregion
    }
}
