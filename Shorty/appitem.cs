using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Shorty
{
    public partial class appitem : UserControl
    {

        public appitem()
        {
            InitializeComponent();
        }

        private Image _appIcon;
        private string _appName;
        private string _appLocation;
        private string _appctrlKey;
        private string _appcodeKey;
        private string _appshortCut;
        public string appCallName;

        public string appshortcut
        {
            get {return _appshortCut; }
            set { _appshortCut = value; shortcutLbl.Text = value; }
        }
        public string appctrlKey
        {
            get { return _appctrlKey; }
            set { _appctrlKey = value;}
        }
        public string appcodeKey
        {
            get { return _appcodeKey; }
            set { _appcodeKey = value; }
        }

        [Category("Custom props")]
        public string appName
        {
            get { return _appName; }
            set { _appName = value; itemLabel.Text = value.Substring(0,value.Length); }
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
            set { _appLocation = value; }
        }


        private void openBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @applocation, UseShellExecute = true });
        }

        
        private void remBtn_Click(object sender, EventArgs e)
        {
            string fileName = Shorty.logfile;

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                lines = lines.Where(element => element.Split(", ")[0] != appName).ToArray();
                File.WriteAllLines(fileName, lines);
            }

            Speech_recognition.init();
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
