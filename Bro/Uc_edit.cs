using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Bro
{
    public partial class uc_Edit : UserControl
    {


        RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "Bro1110";

        private string[] lines;
        public uc_Edit()
        {
            InitializeComponent();
        }
        private void uc_Edit_Load(object sender, EventArgs e)
        {
            if (key.GetValue("Bro1110") != null)
            {
                Startup_Check.Checked = true;
            }
        }

        private string _nameBox;
        private string _lockBox;
        private Image _iconPanel;
        private string _appctrlKey;
        private string _appcodeKey;
        public string _appcallname;

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

        [Category("Custom props")]
        public Image panel
        {
            get { return panel1.BackgroundImage; }
            set { panel1.BackgroundImage = value; }
        }

        internal void comboboxitem_Rem()
        {
            keyCbox.SelectedIndex = -1;
            controlCobox.SelectedIndex = -1;

            //keyCbox.Items.Clear();
            //keyCbox.Items.AddRange(new string[]
            //{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"});
            //
            //foreach (var line in lines)
            //{
            //    string[] info = line.Split(",");
            //    if (keyCbox.Items.Contains(info[3]))
            //    {
            //        keyCbox.Items.Remove(info[3]);
            //    }
            //}
        }
        private void controlCobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lines = File.ReadAllLines(Bro.logfile);
            keyCbox.Items.Clear();
            keyCbox.Items.AddRange(new string[]
            {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"});

            foreach (var line in lines)
            {
                string[] info = line.Split(",");
                if (controlCobox.SelectedItem.Equals("ALT") && keyCbox.Items.Contains(info[3]) && info[2] == "3")
                {
                    keyCbox.Items.Remove(info[3]);
                }
                else if (controlCobox.SelectedItem.Equals("SHIFT") && keyCbox.Items.Contains(info[3]) && info[2] == "6")
                {
                    keyCbox.Items.Remove(info[3]);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (controlCobox.SelectedIndex == -1 || keyCbox.SelectedIndex == -1 || locBox.TextLength == 0)
            {
                MessageBox.Show("don't leave anything empty");
                return;
            }

            if (File.Exists(Bro.logfile))
            {
                lines = File.ReadAllLines(Bro.logfile);

                // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
                // Compute the addition of each combination of the keys you want to be pressed
                // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
                if (controlCobox.SelectedItem.ToString() == "SHIFT")
                    appctrlKey = "6";
                else
                    appctrlKey = "3";

                appcodeKey = keyCbox.SelectedItem.ToString();

                string CallName = callbox.Text.ToString();
                CallName = CallName.TrimStart();
                CallName = CallName.TrimEnd();
                CallName = CallName.ToLower();

                string lineLog = appName.ToLower() + "," + appLoaction + "," + appctrlKey + "," + appcodeKey.ToUpper() + "," + CallName;

                if (Array.Find(lines, s => s.Split(",").ElementAt(0).Equals(appName.ToLower())) != null)
                {
                    MessageBox.Show("Cant be added twice !!");
                    this.Parent.Controls.Clear();
                    return;
                }

                File.AppendAllText(Bro.logfile, lineLog + Environment.NewLine);
            }

            appName = "";
            appLoaction = "";
            _appcallname = "";
            iconBox.Image = null;
            Speech_recognition.init();
            this.Parent.Controls.Clear();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            appName = "";
            appLoaction = "";
            _appcallname = "";
            this.Parent.Controls.Clear();
        }

        private void Startup_Check_CheckStateChanged(object sender, EventArgs e)
        {
            if (Startup_Check.Checked)
            {
                key.SetValue(StartupValue, Application.ExecutablePath.ToString());
            }
            else if (!Startup_Check.Checked)
            {
                key.DeleteValue("Bro1110");
            }
        }

    }
}
