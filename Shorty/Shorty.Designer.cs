
namespace Shorty
{
    partial class Shorty
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shorty));
            this.mainbar = new System.Windows.Forms.Panel();
            this.dragdrop_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.additionBtn = new System.Windows.Forms.Button();
            this.minmizeBtn = new System.Windows.Forms.Button();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Panel();
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainbar.SuspendLayout();
            this.dragdrop_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainbar
            // 
            this.mainbar.AllowDrop = true;
            this.mainbar.BackgroundImage = global::Shorty.Properties.Resources.mainpanel_default;
            this.mainbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainbar.Controls.Add(this.dragdrop_panel);
            this.mainbar.Controls.Add(this.closeBtn);
            this.mainbar.Controls.Add(this.additionBtn);
            this.mainbar.Controls.Add(this.minmizeBtn);
            this.mainbar.Controls.Add(this.inputTxt);
            this.mainbar.Controls.Add(this.logo);
            this.mainbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainbar.Location = new System.Drawing.Point(0, 0);
            this.mainbar.Margin = new System.Windows.Forms.Padding(0);
            this.mainbar.Name = "mainbar";
            this.mainbar.Size = new System.Drawing.Size(450, 55);
            this.mainbar.TabIndex = 7;
            // 
            // dragdrop_panel
            // 
            this.dragdrop_panel.AllowDrop = true;
            this.dragdrop_panel.BackColor = System.Drawing.Color.Transparent;
            this.dragdrop_panel.Controls.Add(this.label1);
            this.dragdrop_panel.Location = new System.Drawing.Point(67, 7);
            this.dragdrop_panel.Name = "dragdrop_panel";
            this.dragdrop_panel.Size = new System.Drawing.Size(261, 41);
            this.dragdrop_panel.TabIndex = 5;
            this.dragdrop_panel.TabStop = true;
            this.dragdrop_panel.Visible = false;
            this.dragdrop_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragdrop_panel_DragDrop);
            this.dragdrop_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragdrop_panel_DragEnter);
            this.dragdrop_panel.DragLeave += new System.EventHandler(this.dragdrop_panel_DragLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drag and Drop here.....";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = global::Shorty.Properties.Resources.exitbtn_default;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ImageKey = "(none)";
            this.closeBtn.Location = new System.Drawing.Point(411, 16);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(27, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // additionBtn
            // 
            this.additionBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionBtn.BackColor = System.Drawing.Color.Transparent;
            this.additionBtn.BackgroundImage = global::Shorty.Properties.Resources.addbtn_default;
            this.additionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.additionBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.additionBtn.FlatAppearance.BorderSize = 0;
            this.additionBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.additionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.additionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.additionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additionBtn.ImageKey = "(none)";
            this.additionBtn.Location = new System.Drawing.Point(345, 16);
            this.additionBtn.Name = "additionBtn";
            this.additionBtn.Size = new System.Drawing.Size(27, 23);
            this.additionBtn.TabIndex = 0;
            this.additionBtn.TabStop = false;
            this.additionBtn.UseVisualStyleBackColor = false;
            this.additionBtn.Click += new System.EventHandler(this.additionBtn_Click);
            // 
            // minmizeBtn
            // 
            this.minmizeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minmizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.BackgroundImage = global::Shorty.Properties.Resources.minimizebtn_default;
            this.minmizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minmizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minmizeBtn.FlatAppearance.BorderSize = 0;
            this.minmizeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.minmizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmizeBtn.ImageKey = "(none)";
            this.minmizeBtn.Location = new System.Drawing.Point(378, 16);
            this.minmizeBtn.Name = "minmizeBtn";
            this.minmizeBtn.Size = new System.Drawing.Size(27, 23);
            this.minmizeBtn.TabIndex = 0;
            this.minmizeBtn.TabStop = false;
            this.minmizeBtn.UseVisualStyleBackColor = false;
            this.minmizeBtn.Click += new System.EventHandler(this.minmizeBtn_Click);
            // 
            // inputTxt
            // 
            this.inputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTxt.Location = new System.Drawing.Point(75, 17);
            this.inputTxt.MaxLength = 25;
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.PlaceholderText = "What are you looking for ?";
            this.inputTxt.Size = new System.Drawing.Size(252, 22);
            this.inputTxt.TabIndex = 1;
            this.inputTxt.TextChanged += new System.EventHandler(this.inputTxt_TextChanged);
            this.inputTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inputTxt_PreviewKeyDown);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Shorty.Properties.Resources.logo_default;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 55);
            this.logo.TabIndex = 9;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // _flowLayoutPanel
            // 
            this._flowLayoutPanel.AutoSize = true;
            this._flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this._flowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowLayoutPanel.Location = new System.Drawing.Point(0, 55);
            this._flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            this._flowLayoutPanel.Size = new System.Drawing.Size(450, 218);
            this._flowLayoutPanel.TabIndex = 6;
            this._flowLayoutPanel.TabStop = true;
            this._flowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this._flowLayoutPanel_ControlRemoved);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Shorty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(450, 273);
            this.Controls.Add(this._flowLayoutPanel);
            this.Controls.Add(this.mainbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shorty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.Load += new System.EventHandler(this.Shorty_Load);
            this.Resize += new System.EventHandler(this.Shorty_Resize);
            this.mainbar.ResumeLayout(false);
            this.mainbar.PerformLayout();
            this.dragdrop_panel.ResumeLayout(false);
            this.dragdrop_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainbar;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button additionBtn;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel dragdrop_panel;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button minmizeBtn;
    }
}

