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
        public static extern int GetAsyncKeyState(Int32 vKey);

        CancellationTokenSource _tokensource = null;
        Thread t = new Thread(module.Start);
        //Thread k = new Thread(Shorty_key);

        public static bool flag;

        public static uc_Edit ucedit = new uc_Edit();
        private string logfile = @"C:\Temp\appslog.txt";

        public Shorty()
        {
            InitializeComponent();
        }

        private void Shorty_Load(object sender, EventArgs e)
        {
            additionBtn.Focus();
            this.KeyPreview = true;

            if (!File.Exists(logfile))
            {
                using (StreamWriter sw = File.CreateText(logfile))
                {

                }
            }
            t.Start();
            //k.Start();
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
                    //_item.appIcon = Bitmap.FromHicon(new Icon(appico, new Size(32, 32)).Handle);
                    _item.appIcon = appico.ToBitmap();
                }
                catch (Exception)
                {
                    _item.appIcon = Properties.Resources.icon_default;
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
            _ = awaitforAsync(_tokensource.Token);
            _flowLayoutPanel.Visible = false;
        }

        private async Task awaitforAsync(CancellationToken token)
        {
            try
            {
                await Task.Delay(160, token);
                viewApps();
            }
            catch (OperationCanceledException)
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
            ucedit.comboboxitem_Rem();
            _flowLayoutPanel.Controls.Add(ucedit);
        }

        private void minmizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            flag = true;
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
                notifyIcon1.BalloonTipTitle = "Minimized";
                notifyIcon1.BalloonTipText = "Click on tray ico to open";
                notifyIcon1.Text = "Shorty";

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
            flag = false;
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
            
            ucedit.appName = Path.GetFileNameWithoutExtension(file[0]);
            ucedit.appLoaction = file[0];
            try
            {
                Icon appico = Icon.ExtractAssociatedIcon(file[0]);
                ucedit.appIcon = Bitmap.FromHicon(new Icon(appico, new Size(32,32)).Handle);
            }
            catch (Exception)
            {
                ucedit.appIcon = Properties.Resources.icon_default;
            }
            

        }

        private void dragdrop_panel_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Drag and Drop here.....";
        }


        //######## FLOWLAYOUTPANEL CONTROL CHANGED EVENT########\\
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

        private void logo_Click(object sender, EventArgs e)
        {

        }

        //######## Global key hook is better than GetAsyncKeyState using loop ########\\

        //public static void Shorty_key()
        //{
        //   
        //    //int VK_ESCAPE = 0x1B;
        //    int VK_SHIFT = 0x10;
        //    int VK_CONTROL = 0x11;
        //    int VK_MENU = 0x12;
        //
        //
        //    while (isRunning == true)
        //    {
        //        string[] lines = File.ReadAllLines(@"C:\Temp\appslog.txt");
        //        Thread.Sleep(300);
        //        if(flag == true)
        //        foreach (var line in lines)
        //        {
        //            string[] info = line.Split(", ");
        //                if (info[2] == "3")
        //                    if ((GetAsyncKeyState(VK_CONTROL) != 0) & (GetAsyncKeyState(VK_MENU) != 0) & GetAsyncKeyState(char.Parse(info[3])) != 0)
        //                    {
        //                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @info[1], UseShellExecute = true });
        //                    }
        //                if (info[2] == "6")
        //                    if ((GetAsyncKeyState(VK_CONTROL) != 0) & (GetAsyncKeyState(VK_SHIFT) != 0) & GetAsyncKeyState(char.Parse(info[3])) != 0)
        //                    {
        //                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @info[1], UseShellExecute = true });
        //                    }
        //        }
        //    }
        //
        //
        //    //for (int i = 32; i<127; i++)
        //    //{
        //    //    int keystate = GetAsyncKeyState(i);
        //    //    if (keystate != 0 )
        //    //        MessageBox.Show(((char)i).ToString());
        //    //}
        //
        //
        //}
    }
}
