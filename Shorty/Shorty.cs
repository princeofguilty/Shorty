using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Shorty
{


    public partial class Shorty : Form
    {

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEY_ID = 1;
        

        CancellationTokenSource _tokensource = null;
        public static uc_Edit ucedit = new uc_Edit();
        private string logfile = @"C:\Temp\appslog.txt";

        public Shorty()
        {
            InitializeComponent();
            
        }

        private void Shorty_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Minimized";
            notifyIcon1.BalloonTipText = "Click on tray ico to open";
            notifyIcon1.Text = "Shorty";
            additionBtn.Focus();
            this.KeyPreview = true;

            if (!File.Exists(logfile))
            {
                using (StreamWriter sw = File.CreateText(logfile))
                {

                }
            }
            
        }

        //implement user control in form1 in _flowlayoutpanel control
        private void viewApps() 
        {
            _flowLayoutPanel.Controls.Clear();

            foreach (var line in File.ReadAllLines(logfile))
            {
                appitem _item = new appitem();
                string[] info = line.Split(", ");
                _item.appName = info[0];
                _item.applocation = info[1];
                _item.appctrlKey = info[2];
                _item.appcodeKey = info[3];

                if (info[2] == "3")
                    _item.appshortcut = "CTRL + ALT "+ info[3].ToUpper();
                else
                    _item.appshortcut = "CTRL + SHIFT " + info[3].ToUpper();

                if (!_item.appName.StartsWith(inputTxt.Text.ToLower()))
                    continue;

                try
                {
                    Icon appico = Icon.ExtractAssociatedIcon(info[1]);
                    _item.appIcon = Bitmap.FromHicon(new Icon(appico, new Size(32, 32)).Handle);
                }
                catch (Exception)
                {
                    _item.appIcon = Properties.Resources.fico;
                }

                _flowLayoutPanel.Controls.Add(_item);
            }            
            _flowLayoutPanel.Visible = true;

            if(inputTxt.Text == "")
               _flowLayoutPanel.Controls.Clear();
        }

        //detecting input change and usercontrol updates
        //controlling refresh rate throw canceling operations and Delaying.

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {
            if(_tokensource != null)
                _tokensource.Cancel();

            _tokensource = new CancellationTokenSource();
            awaitforAsync(_tokensource.Token);
            _flowLayoutPanel.Visible = false;
        }

        private async Task awaitforAsync(CancellationToken token)
        {
            try
            {
                await Task.Delay(160, token);
                viewApps();
            }
            catch (OperationCanceledException ex)
            {
                throw;
            }
            
        }

        //###### BUTTON CLICKS AND EVENTS ########\\
        private void additionBtn_Click(object sender, EventArgs e)
        {
            additionBtn.Visible = false;
            
            inputTxt.Visible = false;
            dragdrop_panel.Visible = true;

            _flowLayoutPanel.Controls.Clear();
            _flowLayoutPanel.Controls.Add(ucedit);
        }

        private void minmizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //###### MINIMIZATION THROUGH AND TRY ICON ########\\
        private void Shorty_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            { notifyIcon1.Visible = false; }
        }

        //###### NOTIFYCATION VISABILITY AND BACKGROUND WORKERS ########\\

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }


        //###### SHORTCUTS AND KEYDOWNS ########\\
        private void Shorty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.H)
            {
                inputTxt.Text = "ctrl - h pressed !";
            }
        }

        //###### DRAG AND DROP SECTION ########\\

        private void dragdrop_panel_DragEnter(object sender, DragEventArgs e)
        {
            string[] vs = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (Path.GetExtension(vs[0]).ToString() == ".lnk")
            {
                label1.Text = ".lnk extensions are not allawode";
            }
            else
                e.Effect = DragDropEffects.Copy;
        }

        private void dragdrop_panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            ucedit.appName = Path.GetFileName(file[0]);
            ucedit.appLoaction = file[0];
            try
            {
                Icon appico = Icon.ExtractAssociatedIcon(file[0]);
                ucedit.appIcon = Bitmap.FromHicon(new Icon(appico, new Size(32,32)).Handle);
            }
            catch (Exception)
            {
                ucedit.appIcon = Properties.Resources.fico;
            }
            

        }

        private void dragdrop_panel_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Drag and Drop here.....";
        }
        

        //######  ########\\
        private void _flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ucedit.appLoaction = "";
            ucedit.appName = "";
            ucedit.appIcon = null;

            additionBtn.Visible = true;

            inputTxt.Visible = true;
            dragdrop_panel.Visible = false;

            _flowLayoutPanel.Controls.Clear();

            inputTxt.PlaceholderText = "What are you looking for ?";

        }


        protected override void WndProc(ref Message m)
        {
            if(File.Exists(logfile) && WindowState == FormWindowState.Minimized)
            foreach (var line in File.ReadAllLines(logfile))
            {
                string[] info = line.Split(", ");

                byte[] c = Encoding.ASCII.GetBytes(info[3]);

                RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, Convert.ToInt32(info[2]), c[0]-32);
                if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
                {
                    //MessageBox.Show("1");
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = info[1], UseShellExecute = true });
                }
            }

            
            base.WndProc(ref m);
        }
    }
}
