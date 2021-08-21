using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shorty
{
    public partial class Shorty : Form
    {
        public Shorty()
        {
            InitializeComponent();
        }

        private void viewApps() 
        {
            appitem[] appitems = new appitem[12];

            for (int i = 0; i < appitems.Length; i++)
            {
                appitems[i] = new appitem();
                appitems[i].appName = "kaka";

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    flowLayoutPanel1.Controls.Add(appitems[i]);
            }
        }

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {
            viewApps();
        }
    }
}
