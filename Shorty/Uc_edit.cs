using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shorty
{
    public partial class uc_Edit : UserControl
    {
        public uc_Edit()
        {
            InitializeComponent();
        }

        private string _nameBox;
        private string _lockBox;
        private Image _iconPanel;
        private string _appctrlKey;
        private string _appcodeKey;

        public string appctrlKey
        {
            get { return _appctrlKey; }
            set { _appctrlKey = value; }
        }
        public string appcodeKey
        {
            get { return _appcodeKey; }
            set { _appcodeKey = value; }
        }

        [Category("Custom props")]
        public string appName
        {
            get { return _nameBox; }
            set { _nameBox = value; nameBox.Text = value; }
        }

        [Category("Custom props")]
        public string appLoaction
        {
            get { return _lockBox; }
            set { _lockBox = value; locBox.Text = value; }
        }

        [Category("Custom props")]
        public Image appIcon
        {
            get { return _iconPanel; }
            set { _iconPanel = value; iconBox.Image = value; }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\appslog.txt";

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
                // Compute the addition of each combination of the keys you want to be pressed
                // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
                if (controlCobox.SelectedItem.ToString() == "SHIFT")
                    appctrlKey = "6";
                else
                    appctrlKey = "3";

                appcodeKey = keyCbox.SelectedItem.ToString();

                string lineLog = (appName + ", " + appLoaction + ", " + appctrlKey + ", " + appcodeKey).ToLower();

                if (Array.Find(lines, s => s.Equals(lineLog)) != null)
                {
                    MessageBox.Show("Cant be added twice !!");
                    this.Parent.Controls.Clear();
                    return;
                }


                File.AppendAllText(fileName, lineLog + Environment.NewLine);
            }

            appName = "";
            appLoaction = "";
            iconBox.Image = null;
            this.Parent.Controls.Clear();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            appName = "";
            appLoaction = "";
            this.Parent.Controls.Clear();
        }
    }
}
