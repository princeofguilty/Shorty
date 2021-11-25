using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shorty
{
    public partial class Shorty : Form
    {
        #region Draggable_Form
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion

        #region Variables
        internal static protected RegistryKey logkey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Shorty");
        internal static RegistryKey scutOn = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Shorty");

        private string subdir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Shorty";
        internal static string logfile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Shorty\LogData.txt";
        internal static string appinfo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Shorty\AppInfo.txt";

        private uc_Edit ucedit = new uc_Edit();
        private string[] dragedfile;

        CancellationTokenSource _tokensource = null;
        public Thread t = new Thread(module.Start);
        #endregion

        #region staticVar
        internal static bool flag = false;
        protected internal static Panel logoz;
        protected internal static Shorty _Shorty = null;
        #endregion

        public Shorty()
        {
            InitializeComponent();
        }

        private void Shorty_Load(object sender, EventArgs e)
        {

            _Shorty = this;

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }

            if (!File.Exists(logfile))
            {
                using (StreamWriter sw = File.CreateText(logfile)) { sw.Dispose(); }
            }

            if (!File.Exists(Shorty.appinfo))
            {
                using (StreamWriter sw = File.CreateText(Shorty.appinfo))
                {
                    sw.Dispose();
                }
                File.AppendAllText(Shorty.appinfo, "ProductName: " + Application.ProductName + Environment.NewLine);
                File.AppendAllText(Shorty.appinfo, "ProductVersion: " + Application.ProductVersion + Environment.NewLine);
                File.AppendAllText(Shorty.appinfo, "UserAppDataRegistry: " + Application.UserAppDataRegistry + Environment.NewLine);
            }

            t.Priority = ThreadPriority.Lowest;
            t.Start();

            //Speech_recognition.init();
            //InitTimer();
            if (scutOn.GetValue("scutssitt") == null)
                scutOn.SetValue("scutssitt", false);
            else if (scutOn.GetValue("scutssitt").Equals("True"))
            {
                flag = false;
                logo_Click(null, EventArgs.Empty);
            }
            else if (logkey.GetValue("logging").Equals(true))
            {
                flag = false;
                logo_Click(null, EventArgs.Empty);
            }
            logoz = logo;
        }

        //implement user control in form1 in _flowlayoutpanel control
        internal void viewApps()
        {
            _flowLayoutPanel.Controls.Clear();

            foreach (var line in File.ReadAllLines(logfile))
            {
                string[] info = line.Split(",");
                bool state = false;

                if (inputTxt.Text.ToLower().Equals("all")) state = true;
                else if (info[0].StartsWith(inputTxt.Text.ToLower())) state = true;

                if (state)
                {
                    appitem _item = new appitem();

                    _item.appName = info[0];
                    _item.applocation = info[1];
                    _item.appctrlKey = info[2];
                    _item.appcodeKey = info[3];

                    if (info[2] == "3")
                        _item.appshortcut = "CTRL + ALT " + info[3].ToUpper();
                    else
                        _item.appshortcut = "CTRL + SHIFT " + info[3].ToUpper();

                    try
                    {
                        Icon appico = Icon.ExtractAssociatedIcon(info[1]);
                        _item.appIcon = appico.ToBitmap();
                    }
                    catch (Exception)
                    {
                        _item.appIcon = Properties.Resources.icon_default;
                    }

                    _flowLayoutPanel.Controls.Add(_item);
                }
            }
            _flowLayoutPanel.Visible = true;

            if (inputTxt.Text == "")
                _flowLayoutPanel.Controls.Clear();
        }

        //#Scroll through apps
        private void inputTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    Thread.Sleep(30);
                    _flowLayoutPanel.Controls.SetChildIndex(_flowLayoutPanel.Controls[_flowLayoutPanel.Controls.Count - 1], _flowLayoutPanel.Controls.IndexOf(GetNextControl(_flowLayoutPanel.Controls[_flowLayoutPanel.Controls.Count - 1], true)));
                    inputTxt.Select(inputTxt.Text.Length, 0);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    Thread.Sleep(30);
                    _flowLayoutPanel.Controls.SetChildIndex(_flowLayoutPanel.Controls[0], _flowLayoutPanel.Controls.IndexOf(GetNextControl(_flowLayoutPanel.Controls[0], false)));
                    inputTxt.Select(inputTxt.Text.Length, 0);
                }
            }
            catch (Exception) { }
        }

        /*detecting input change and usercontrol updates
        controlling refresh rate throw canceling operations and Delaying of the appmenu or appitem.*/
        internal void inputTxt_TextChanged(object sender, EventArgs e)
        {
            _tokensource?.Cancel();

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
            _flowLayoutPanel.Controls.Clear();
            inputTxt.Visible = false;
            dragdrop_panel.Visible = true;
            ucedit.comboboxitem_Rem();
            _flowLayoutPanel.Controls.Add(ucedit);
        }

        private void minmizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            logkey.Close();
            Application.Exit();
        }

        //###### MINIMIZATION THROUGH AND TRY ICON ########\\
        private void Shorty_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.BalloonTipTitle = "Relaxing here";
                notifyIcon1.BalloonTipText = "For anyhing click on me";
                notifyIcon1.Text = "Shorty";

                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
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

        //###### DRAG AND DROP SECTION ########\\
        private void dragdrop_panel_DragEnter(object sender, DragEventArgs e)
        {
            dragedfile = (string[])e.Data.GetData(DataFormats.FileDrop);
            e.Effect = DragDropEffects.Copy;
        }

        private void dragdrop_panel_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                ucedit.appName = Path.GetFileNameWithoutExtension(dragedfile[0]);
            }
            catch (Exception)
            {

                return;
            }
            ucedit.appLoaction = dragedfile[0];
            try
            {

                Icon appico = Icon.ExtractAssociatedIcon(dragedfile[0]);
                ucedit.appIcon = appico.ToBitmap();
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

        public void logo_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                logo.BackgroundImage = Properties.Resources.logo_default;
            }
            else if (flag == false)
            {
                logo.BackgroundImage = Properties.Resources.logo_click_default;
            }
            flag = !flag;

            logkey.SetValue("logging", flag);
        }

        //move the program on the desktop freely
        private void mainbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //##Do changes from onther thread on this UI through invoke delegating
        internal void resultCallback()
        {
            if (inputTxt.InvokeRequired)
            {
                inputTxt.Invoke(new MethodInvoker(delegate
                {
                    inputTxt.Text = "all";
                    viewApps();
                }));
            }
            else
            {
                inputTxt.Text = inputTxt.Text;
            }
        }
    }
}
