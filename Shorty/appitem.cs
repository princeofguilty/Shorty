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
    public partial class appitem : UserControl
    {

        uc_Edit ucedit = new uc_Edit();

        public appitem()
        {
            InitializeComponent();
        }

        private Image _appIcon;
        private string _appName;
        private string _appLocation;


        [Category("Custom props")]
        public string appName
        {
            get { return _appName; }
            set { _appName = value; itemLabel.Text = value; }
        }
        
        [Category("Custom props")]
        public Image appIcon
        {
            get { return _appIcon; }
            set { _appIcon = value; itemIcon.Image = value; }
        }

        [Category("Custom props")]
        public string applocation
        {
            get { return _appLocation; }
            set { _appLocation = value;}
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @applocation, UseShellExecute = true });
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(ucedit);

        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }
    }
}
