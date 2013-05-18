using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1_1.UI.Views.HouseholdTab.Client
{
    public partial class ClientInfoView : UserControl
    {
        public ClientInfoView()
        {
            InitializeComponent();
        }


        public void clearAllControls()
        {
            txtLastname.Clear();
            txtFirstname.Clear();
            txtMedicare.Clear();            
            txtAge.Clear();
            txtWelfare.Clear();
            txtReferral.Clear();
            txtReasonForService.Clear();            
        }
    }
}
