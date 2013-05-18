using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using Prototype1_1.UI;
using Prototype1_1.UI.Views.SearchTab;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.EntityModel;
using System.Data.Objects.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace Prototype1_1.Presenters.SearchTab
{
    class SearchPresenter
    {
        #region Attributes

        SearchView _view;
        private static SearchPresenter _instance;
        private soen390Entities _entities;
        private DataTable _searchResults;
        private BackgroundWorker _worker;

        #endregion

        #region Properties

        public SearchView View
        {
            get { return _view; }
        }

        #endregion

        #region Constructor and getInstance()

        private SearchPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _searchResults = new DataTable();
            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;
        }

        public static SearchPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new SearchPresenter();
            }

            return _instance;
        }

        #endregion

        #region Methods

        internal void initializeView(SearchView searchView)
        {
            _view = searchView;
            _view.pbxLoader.Visible = false;
            AttachEventHandlers();
            InitializeDataTable();
        }

        private void AttachEventHandlers()
        {
            _view.txtSearch.KeyUp += OnKeyUp;
            _view.dgvResults.CellDoubleClick += OpenClient;
            _worker.DoWork += SearchAndFillDgv;
            _worker.RunWorkerCompleted += StopAnimationAndShowResults;
            _view.btnSearch.Click += btnSearch_Click;

            _view.KeyDown += _view_KeyDown;
        }

        void _view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                MainPresenter.getInstance().SelectTab("tabHousehold");

                e.Handled = true;
            }
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            if (_worker.IsBusy)
            {
                _worker.CancelAsync();
            }

            while (_worker.IsBusy)
            {
                Application.DoEvents();
            }

            _view.pbxLoader.Visible = true;
            _view.dgvResults.Visible = false;
            _worker.RunWorkerAsync();
        }

        private void InitializeDataTable()
        {
            _searchResults.Columns.Add("Household ID");
            _searchResults.Columns.Add("Last Name");
            _searchResults.Columns.Add("First Name");
            _searchResults.Columns.Add("Medicare");
            _searchResults.Columns.Add("Postal Code");
            _searchResults.Columns.Add("Phone Number");
            _view.dgvResults.DataSource = _searchResults;
            _view.dgvResults.Columns["Household ID"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _view.dgvResults.Columns["Last Name"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _view.dgvResults.Columns["First Name"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _view.dgvResults.Columns["Medicare"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _view.dgvResults.Columns["Postal Code"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _view.dgvResults.Columns["Phone Number"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SearchAndFillDgv(object sender, DoWorkEventArgs e)
        {
            if (_worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
                _searchResults.Clear();
                String query = _view.txtSearch.Text;
                String[] splitQuery = query.Split(' ');
                List<HashSet<client>> allResults = new List<HashSet<client>>(splitQuery.Length);
                HashSet<client> finalResult = new HashSet<client>();

                for (int i = 0; i < splitQuery.Length; i++)
                {
                    HashSet<client> results = new HashSet<client>();
                    List<client> clients = SearchByClientAttributes(splitQuery[i]);
                    List<household> households = SearchByHouseholdAttributes(splitQuery[i]);
                    List<household> householdsfoundByID = SearchByHouseholdID(splitQuery[i]);

                    foreach (household found in householdsfoundByID)
                    {
                        if (found.client.Count > 0)
                            results.Add(found.client.First());
                    }

                    foreach (household found in households)
                    {
                        if (found.client.Count > 0)
                            results.Add(found.client.First());
                    }

                    foreach (client found in clients)
                    {
                        results.Add(found);
                    }

                    allResults.Add(results);
                }

                foreach (HashSet<client> res in allResults)
                {
                    if (finalResult.Count == 0)
                    {
                        finalResult = res;
                    }

                    else
                    {
                        finalResult.IntersectWith(res);
                    }
                }

                //Populate the DataTable
                foreach (client cli in finalResult)
                {
                    if (cli.household.Count > 0)
                    {
                        var row = _searchResults.NewRow();
                        row["Household ID"] = cli.household.First().HouseholdID;
                        row["Last Name"] = cli.LastName;
                        row["First Name"] = cli.FirstName;
                        row["Medicare"] = cli.Medicare;
                        row["Postal Code"] = cli.household.First().PostalCode;
                        row["Phone Number"] = cli.household.First().PhoneNumber;
                        _searchResults.Rows.Add(row);
                    }
                }
        
        }

        private List<client> SearchByClientAttributes(string query)
        {
            //TODO: Spouse name ?
            List<client> results = _entities.client.Where(c => c.LastName.Contains(query) || c.FirstName.Contains(query) || c.Medicare.Contains(query)).ToList();
            return results;
        }

        private List<household> SearchByHouseholdAttributes(string query)
        {
            List<household> results = _entities.household.Where(h => h.PhoneNumber.Contains(query) || h.PostalCode.Contains(query)).ToList();
            return results;
        }

        private List<household> SearchByHouseholdID(string query)
        {
            var linqQuery = from h in _entities.household
                            select new { h.HouseholdID };
            var householdIDresults = linqQuery.AsEnumerable().Where(h => h.HouseholdID.ToString().Contains(query)).ToList();
            List<household> householdResults = new List<household>();
            foreach (var anon in householdIDresults)
            {
                householdResults.Add(_entities.household.Find(anon.HouseholdID));
            }
            return householdResults;
        }

        private void StopAnimationAndShowResults(object sender, RunWorkerCompletedEventArgs e)
        {
            _view.pbxLoader.Visible = false;
            _view.dgvResults.Visible = true;
        }

        private void OnKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (_worker.IsBusy)
                {
                    _worker.CancelAsync();
                }

                while (_worker.IsBusy)
                {
                    Application.DoEvents();
                }

                _view.pbxLoader.Visible = true;
                _view.dgvResults.Visible = false;
                _worker.RunWorkerAsync();
            }
        }

        private void OpenClient(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1 || e.ColumnIndex == -1))
            {
                String clientHouseholdID = _view.dgvResults["Household ID", e.RowIndex].Value.ToString();
                long clientHouseholdIDToLong = long.Parse(clientHouseholdID);
                client clientToOpen = _entities.household.Where(h => h.HouseholdID == clientHouseholdIDToLong).First().client.First();
                HouseholdTabPresenter.getInstance().loadClient(clientToOpen);
                MainPresenter.getInstance().SelectTab("tabHousehold");
            }
        }

        

        #endregion

    }
}
