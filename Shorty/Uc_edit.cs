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
                    string full = (lines.Length+1) + ", "+appName+", "+appLoaction;
                    File.AppendAllText(fileName, full + Environment.NewLine);
            }

            appName = "";
            appLoaction = "";
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
