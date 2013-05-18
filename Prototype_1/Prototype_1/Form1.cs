using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this will "hide" the admin dedicated tabs
            tabControl1.TabPages.Remove(tabReports);
            tabControl1.TabPages.Remove(tabAdmin);
        }


        private void label5_Click(object sender, EventArgs e)
        {
            // DONT DELETE THESE EMPTY METHOD, VS WILL GIVE BUIL ERR
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FormRepeat repeatForm = new FormRepeat();
            repeatForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    tabControl1.SelectTab(0); e.Handled = true; break;
                case Keys.F2:
                    tabControl1.SelectTab(1); e.Handled = true; break;
                case Keys.F3:
                    tabControl1.SelectTab(2); e.Handled = true; break;
                case Keys.F4:
                    tabControl1.SelectTab(3); e.Handled = true; break;
                //case Keys.F5:
                  //  tabControl1.SelectTab(4); e.Handled = true; break;
                //case Keys.F6:
                 //   tabControl1.SelectTab(5); e.Handled = true; break;
                default:
                    break;
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            // check which textbox is filled as search key
            // search in db based on above criteria
            // if multiple result, display in Result form
            //FormClientLookupResults frmClientResults = new FormClientLookupResults();
            //frmClientResults.ShowDialog();

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ClientSearch cs = new ClientSearch();
            //List<Client> cl = cs.getClientByName(this.textBox1.Text);
            /** Dictionary<string, string> dic1=new Dictionary<string,string>();
            dic1.Add("firstname","jenia");
            dic1.Add("lastname","ivlev");
            Dictionary<string, string> dic2=new Dictionary<string,string>();
            dic2.Add("firstname", "elena");
            dic2.Add("lastname","ivlev");
            Client c1 = new Client(dic1);
            Client c2 = new Client(dic2);
            **/
            String query = this.textBox1.Text;
            ClientSearch cs = new ClientSearch();
            List<Client>  cl = cs.getClientByName(query);
            List<HouseHold> hl = new List<HouseHold>();
            List<ClientHouseHoldTuple> client_household = new List<ClientHouseHoldTuple>();
            foreach (Client client in cl) {
                //hl.AddRange(cs.getHouseHold(client));
                hl = cs.getHouseHold(client);
                foreach (HouseHold hh in hl) {
                    client_household.Add(new ClientHouseHoldTuple(client, hh));
                }
            }
            this.dataGridView2.DataSource = client_household;
            

        }
        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) {
            Console.WriteLine("row index: "+e.RowIndex);

            List<ClientHouseHoldTuple> cl = (List<ClientHouseHoldTuple>)this.dataGridView2.DataSource;
            Client c = cl[e.RowIndex].client;
            this.txtFirstname.Text = c.firstname;
            this.txtLastname.Text = c._lastname;
        }

    }
}


