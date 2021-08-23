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
        uc_Edit ucedit = new uc_Edit();
        appitem[] appitems = new appitem[4];

        public Shorty()
        {
            InitializeComponent();
        }

        private void Shorty_Load(object sender, EventArgs e)
        {
           // panel1.Visible = false;
           //_flowLayoutPanel.Visible = false;

        }

        private void viewApps() 
        {
            appitems[0] = new appitem();
            appitems[1] = new appitem();
            appitems[2] = new appitem();
            appitems[3] = new appitem();
            appitems[0].appName = "the";
            appitems[1].appName = "theword";
            appitems[2].appName = "thewordstarts";
            appitems[3].appName = "thewordstartswith";

            _flowLayoutPanel.Controls.Clear();

            for (int i = 0; i < appitems.Length; i++)
            {  
                if (inputTxt.Text.Length <= appitems[i].appName.Length)
                {
                   if(appitems[i].appName.StartsWith(inputTxt.Text))
                        _flowLayoutPanel.Controls.Add(appitems[i]);
                }
            }

            if(inputTxt.Text == "")
               _flowLayoutPanel.Controls.Clear();
        }

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {
            viewApps();    
        }


        private void additionBtn_Click(object sender, EventArgs e)
        {
            additionBtn.Visible = false;
            cancle_Adding.Visible = true;

            inputTxt.PlaceholderText = "To cancle press again...                        ";
            inputTxt.Enabled = false;
            _flowLayoutPanel.Controls.Clear();
            _flowLayoutPanel.Controls.Add(ucedit);
        }

        private void minmizeBtn_Click(object sender, EventArgs e)
        {

        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        private void cancle_Adding_Click(object sender, EventArgs e)
        {
            additionBtn.Visible = true;
            cancle_Adding.Visible = false;

            _flowLayoutPanel.Controls.Clear();
            inputTxt.PlaceholderText = "What are you looking for ?";
            inputTxt.Enabled = true;
        }
    }
}
