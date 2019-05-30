using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Restaurant_Management
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings["con"].ConnectionString == "null")
            {
                Settings obj = new Settings();
                MainClass.showWindow(obj, this);
            }
            else
            {
                LoginScreen ls = new LoginScreen();
                MainClass.showWindow(ls, this);
            }
        }
    }
}
