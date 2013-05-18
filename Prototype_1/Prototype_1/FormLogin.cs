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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //this.FormClosing += new FormClosingEventHandler(this.FormLogin_FormClosing);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // verify the actual user/pass with DB

            if (username.Equals("123") && password.Equals("123"))
            {
                this.Dispose();
            }
            else
            {
                lblMessage.Visible = true;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
