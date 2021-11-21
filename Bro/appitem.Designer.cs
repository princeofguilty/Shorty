
namespace Bro
{
    partial class appitem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelitem = new System.Windows.Forms.Panel();
            this.shortcutLbl = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.remBtn = new System.Windows.Forms.Button();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemIcon = new System.Windows.Forms.PictureBox();
            this.panelitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelitem
            // 
            this.panelitem.BackColor = System.Drawing.Color.Transparent;
            this.panelitem.BackgroundImage = global::Bro.Properties.Resources.appitem_default;
            this.panelitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelitem.Controls.Add(this.shortcutLbl);
            this.panelitem.Controls.Add(this.openBtn);
            this.panelitem.Controls.Add(this.remBtn);
            this.panelitem.Controls.Add(this.itemLabel);
            this.panelitem.Controls.Add(this.itemIcon);
            this.panelitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelitem.Location = new System.Drawing.Point(0, 0);
            this.panelitem.Margin = new System.Windows.Forms.Padding(0);
            this.panelitem.Name = "panelitem";
            this.panelitem.Size = new System.Drawing.Size(450, 55);
            this.panelitem.TabIndex = 0;
            // 
            // shortcutLbl
            // 
            this.shortcutLbl.AutoSize = true;
            this.shortcutLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shortcutLbl.ForeColor = System.Drawing.Color.White;
            this.shortcutLbl.Location = new System.Drawing.Point(220, 21);
            this.shortcutLbl.Name = "shortcutLbl";
            this.shortcutLbl.Size = new System.Drawing.Size(78, 13);
            this.shortcutLbl.TabIndex = 4;
            this.shortcutLbl.Text = "AppShortkeys";
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.Transparent;
            this.openBtn.BackgroundImage = global::Bro.Properties.Resources.openbtn_default;
            this.openBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.Location = new System.Drawing.Point(317, 15);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 25);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // remBtn
            // 
            this.remBtn.BackColor = System.Drawing.Color.Transparent;
            this.remBtn.BackgroundImage = global::Bro.Properties.Resources.minimizebtn_default;
            this.remBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.remBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.remBtn.FlatAppearance.BorderSize = 0;
            this.remBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.remBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.remBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remBtn.Location = new System.Drawing.Point(406, 16);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(26, 23);
            this.remBtn.TabIndex = 2;
            this.remBtn.UseVisualStyleBackColor = false;
            this.remBtn.Click += new System.EventHandler(this.remBtn_Click);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemLabel.ForeColor = System.Drawing.Color.White;
            this.itemLabel.Location = new System.Drawing.Point(80, 15);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(80, 21);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "AppName";
            // 
            // itemIcon
            // 
            this.itemIcon.BackColor = System.Drawing.Color.Transparent;
            this.itemIcon.Location = new System.Drawing.Point(13, 11);
            this.itemIcon.Name = "itemIcon";
            this.itemIcon.Size = new System.Drawing.Size(32, 32);
            this.itemIcon.TabIndex = 0;
            this.itemIcon.TabStop = false;
            // 
            // appitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelitem);
            this.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.Name = "appitem";
            this.Size = new System.Drawing.Size(450, 55);
            this.panelitem.ResumeLayout(false);
            this.panelitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelitem;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.PictureBox itemIcon;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label shortcutLbl;
    }
}
