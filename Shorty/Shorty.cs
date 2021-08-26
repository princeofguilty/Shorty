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

namespace Shorty
{

    public partial class Shorty : Form
    {
        
        uc_Edit ucedit = new uc_Edit();
        CancellationTokenSource _tokensource = null;

        appitem[] appitems = new appitem[4];

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

        }

        //implement user control in form1 in _flowlayoutpanel control
        private void viewApps() 
        {
            appitems[0] = new appitem();
            appitems[1] = new appitem();
            appitems[2] = new appitem();
            appitems[3] = new appitem();
            appitems[0].appName = "the";
            appitems[1].appName = "theword";
            appitems[2].appName = "thewordstarts";
            appitems[3].appName = "thewordstartswith";

            _flowLayoutPanel.Controls.Clear();

            for (int i = 0; i < appitems.Length; i++)
            {  
                if (inputTxt.Text.Length <= appitems[i].appName.Length)
                {
                   if(appitems[i].appName.StartsWith(inputTxt.Text))
                        _flowLayoutPanel.Controls.Add(appitems[i]);
                }
            }
            _flowLayoutPanel.Visible = true;
            if(inputTxt.Text == "")
               _flowLayoutPanel.Controls.Clear();
        }

        //detecting input change and usercontrol updates
        //controlling refresh rate throw canceling operations.

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
            cancle_Adding.Visible = true;
            
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

        private void cancle_Adding_Click(object sender, EventArgs e)
        {
            additionBtn.Visible = true;
            cancle_Adding.Visible = false;

            inputTxt.Visible = true;
            dragdrop_panel.Visible = false;

            _flowLayoutPanel.Controls.Clear();

            inputTxt.PlaceholderText = "What are you looking for ?";
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
        }

        private void dragdrop_panel_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Drag and Drop here.....";
        }

        private void _flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            additionBtn.Visible = true;
            cancle_Adding.Visible = false;

            inputTxt.Visible = true;
            dragdrop_panel.Visible = false;

            _flowLayoutPanel.Controls.Clear();

            inputTxt.PlaceholderText = "What are you looking for ?";
        }
    }
}
