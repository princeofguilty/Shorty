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
    public partial class appitem : UserControl
    {
        public appitem()
        {
            InitializeComponent();
        }

        private Image _icon;
        private string _appName;

        [Category("Custom props")]
        public Image icon
        {
            get { return _icon; }
            set { _icon = value; itemIcon.Image = value; }
        }

        [Category("Custom props")]
        public string appName
        {
            get { return _appName; }
            set { _appName = value; itemLabel.Text = value; }
        }

    }
}
