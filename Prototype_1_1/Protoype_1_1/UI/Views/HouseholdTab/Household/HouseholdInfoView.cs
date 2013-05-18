using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1_1.UI.Views.HouseholdTab.Household
{
    public partial class HouseholdInfoView : UserControl
    {
        public HouseholdInfoView()
        {
            InitializeComponent();
        }

        public void clearAllControls()
        {
            txtHouseholdID.Clear();
            txtStreetName.Clear();
            txtStreetNumber.Clear();
            txtApt.Clear();
            txtPostal.Clear();
            txtPhone.Clear();          
          
        }

        public void lockAllControls()
        {
            txtHouseholdID.ReadOnly = true;
            txtStreetName.ReadOnly = true;
            txtStreetNumber.ReadOnly = true;
            txtPostal.ReadOnly = true;
            txtPhone.ReadOnly = true;
        
        }

        public void unlockAllControls()
        {
            txtHouseholdID.ReadOnly = false;
            txtStreetName.ReadOnly = false;
            txtStreetNumber.ReadOnly = false;
            txtPostal.ReadOnly = false;
            txtPhone.ReadOnly = false;
          
        }
    }
}
