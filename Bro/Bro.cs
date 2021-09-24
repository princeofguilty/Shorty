using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bro
{
    public partial class Bro : Form
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
        private string subdir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Bro";
        internal static string logfile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Bro\LogData.txt";
        internal static string appinfo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Bro\AppInfo.txt";

        internal static bool flag = false;
        internal static bool flag_speech;

        internal uc_Edit ucedit = new uc_Edit();
        private string[] dragedfile;

        private System.Windows.Forms.Timer timer1;

        CancellationTokenSource _tokensource = null;
        Thread t = new Thread(module.Start);
        #endregion


        public Bro()
        {
            InitializeComponent();
        }

        private void Bro_Load(object sender, EventArgs e)
        {
            using (System.Speech.Synthesis.SpeechSynthesizer sythesizer = new System.Speech.Synthesis.SpeechSynthesizer())
            {
                sythesizer.Speak("Its Me, Bro!");
                sythesizer.Dispose();
            }

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }

            if (!File.Exists(logfile))
            {
                using (StreamWriter sw = File.CreateText(logfile)) { sw.Dispose(); }
            }

            if (!File.Exists(Bro.appinfo))
            {
                using (StreamWriter sw = File.CreateText(Bro.appinfo))
                {
                    sw.Dispose();
                }
                File.AppendAllText(Bro.appinfo, "ProductName: " + Application.ProductName + Environment.NewLine);
                File.AppendAllText(Bro.appinfo, "ProductVersion: " + Application.ProductVersion + Environment.NewLine);
                File.AppendAllText(Bro.appinfo, "UserAppDataRegistry: " + Application.UserAppDataRegistry + Environment.NewLine);
            }

            t.Priority = ThreadPriority.Lowest;
            t.Start();

            Speech_recognition.init();
            InitTimer();
        }


        //implement user control in form1 in _flowlayoutpanel control
        private void viewApps()
        {
            _flowLayoutPanel.Controls.Clear();

            foreach (var line in File.ReadAllLines(logfile))
            {
                string[] info = line.Split(",");
                bool state = false;

                if (inputTxt.Text.ToLower() == ">all") state = true;
                else if (info[0].StartsWith(inputTxt.Text.ToLower())) state = true;

                if (state)
                {
                    appitem _item = new appitem();

                    _item.appName = info[0];
                    _item.applocation = info[1];
                    _item.appctrlKey = info[2];
                    _item.appcodeKey = info[3];
                    //_item.appCallName = info[4];


                    if (info[2] == "3")
                        _item.appshortcut = "CTRL + ALT " + info[3].ToUpper();
                    else
                        _item.appshortcut = "CTRL + SHIFT " + info[3].ToUpper();

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
            }
            _flowLayoutPanel.Visible = true;

            if (inputTxt.Text == "")
                _flowLayoutPanel.Controls.Clear();
        }


        private void inputTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    Thread.Sleep(30);
                    _flowLayoutPanel.Controls.SetChildIndex(_flowLayoutPanel.Controls[_flowLayoutPanel.Controls.Count - 1], _flowLayoutPanel.Controls.IndexOf(GetNextControl(_flowLayoutPanel.Controls[_flowLayoutPanel.Controls.Count - 1], true)));
                }
                else if (e.KeyCode == Keys.Down)
                {
                    Thread.Sleep(30);
                    _flowLayoutPanel.Controls.SetChildIndex(_flowLayoutPanel.Controls[0], _flowLayoutPanel.Controls.IndexOf(GetNextControl(_flowLayoutPanel.Controls[0], false)));
                }
            }
            catch (Exception) { }
            finally
            {
                inputTxt.Select(inputTxt.Text.Length, 0);
            }
        }

        //detecting input change and usercontrol updates
        //controlling refresh rate throw canceling operations and Delaying.

        private void inputTxt_TextChanged(object sender, EventArgs e)
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
            Application.Exit();
        }

        //###### MINIMIZATION THROUGH AND TRY ICON ########\\
        private void Bro_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.BalloonTipTitle = "Relaxing here";
                notifyIcon1.BalloonTipText = "For anyhing click on me";
                notifyIcon1.Text = "Bro";

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

            //if (Path.GetExtension(dragedfile[0]).ToString() == ".lnk")
            //{
            //    label1.Text = ".lnk extensions are not allawode";
            //}
            //else
            e.Effect = DragDropEffects.Copy;
        }

        private void dragdrop_panel_DragDrop(object sender, DragEventArgs e)
        {

            ucedit.appName = Path.GetFileNameWithoutExtension(dragedfile[0]);
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


        internal void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(logo_Click);
            timer1.Interval = 700; // in miliseconds
            timer1.Start();
        }



        public void logo_Click(object sender, EventArgs e)
        {
            if (flag_speech || e != EventArgs.Empty)
            {
                //MessageBox.Show("flag speech = " + flag_speech.ToString() + " _/_ flag = " + flag.ToString() + "_/_ e = " + e);
                if (flag == true)
                {
                    logo.BackgroundImage = Properties.Resources.logo_default;
                }
                else if (flag == false)
                {
                    logo.BackgroundImage = Properties.Resources.logo_click_default;
                }
                flag = !flag;
                flag_speech = false;

            }
        }

        private void mainbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void inputTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           //if(e.KeyChar == (char)8)
           //{
           //    inputTxt.Text = inputTxt.Text.Substring(inputTxt.SelectionStart);
           //}

        }
    }
}
