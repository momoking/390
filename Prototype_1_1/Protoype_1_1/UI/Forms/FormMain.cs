using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype1_1.UI;
using Prototype1_1.UI.Views;
using Prototype1_1.UI.Views.SearchTab;
using System.Threading;

namespace Prototype1_1.UI.Forms
{
    public partial class MainView : Form
    {
       // private UIMode Mode;

        public MainView()
        {
           // Mode = new UIMode();
            // below is another way to do splash
           // Thread t = new Thread(new ThreadStart(SplashScreen));
            //t.Start();
            //Thread.Sleep(3000);
            InitializeComponent();
           // t.Abort();
        }

        // this method is not used
        public void SplashScreen()
        {
            Application.Run(new Splash());
        }

        private void MainView_Load(object sender, EventArgs e)
        {
         
            // this will "hide" the admin dedicated tabs
            //tabControl.TabPages.Remove(tabReports);
            //tabControl.TabPages.Remove(tabSettings);

            //Load the Autocomplete search box with firstName, lastName and medicare number.

            /*AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            textBox1.AutoCompleteCustomSource = acsc;
            DataTable dt = new DataTable();
            dt = this.soen390DataSet.Tables["client"];
            foreach (DataRow dr in dt.Rows)
            {
                acsc.Add(dr["firstName"].ToString());
                acsc.Add(dr["lastName"].ToString());
                acsc.Add(dr["medicare"].ToString());
            }*/
           // this.reportViewer1.RefreshReport();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MainView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    tabControl.SelectTab(0);
                    tabControl.Container.Add(new SearchView());
                    e.Handled = true;
                    break;
                case Keys.F2: 
                    tabControl.SelectTab(1);e.Handled = true;break;
                case Keys.F3:
                    tabControl.SelectTab(2); e.Handled = true; break;
                case Keys.F4:
                    tabControl.SelectTab(3); e.Handled = true; break;
                case Keys.F5:
                    tabControl.SelectTab(4); e.Handled = true; break;
                case Keys.F6:
                    tabControl.SelectTab(5); e.Handled = true; break;
                default:
                    break;
            }

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            // check which textbox is filled as search key
            // search in db based on above criteria
            // if multiple result, display in Result form
            //FormClientLookupResults frmClientResults = new FormClientLookupResults();
            //frmClientResults.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {         
                 
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
   
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void tabReports_Click(object sender, EventArgs e)
        {

        }

    }
}
