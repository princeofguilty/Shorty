
namespace Shorty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appitem));
            this.panelitem = new System.Windows.Forms.Panel();
            this.remBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemIcon = new System.Windows.Forms.PictureBox();
            this.panelitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelitem
            // 
            this.panelitem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelitem.BackgroundImage")));
            this.panelitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelitem.Controls.Add(this.remBtn);
            this.panelitem.Controls.Add(this.editBtn);
            this.panelitem.Controls.Add(this.itemLabel);
            this.panelitem.Controls.Add(this.itemIcon);
            this.panelitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelitem.Location = new System.Drawing.Point(0, 0);
            this.panelitem.Name = "panelitem";
            this.panelitem.Size = new System.Drawing.Size(450, 55);
            this.panelitem.TabIndex = 0;
            // 
            // remBtn
            // 
            this.remBtn.BackColor = System.Drawing.Color.Transparent;
            this.remBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remBtn.BackgroundImage")));
            this.remBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.remBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.remBtn.FlatAppearance.BorderSize = 0;
            this.remBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.remBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.remBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remBtn.Location = new System.Drawing.Point(402, 16);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(26, 23);
            this.remBtn.TabIndex = 2;
            this.remBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(360, 16);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(26, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(66, 20);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(0, 15);
            this.itemLabel.TabIndex = 1;
            // 
            // itemIcon
            // 
            this.itemIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemIcon.Location = new System.Drawing.Point(0, 0);
            this.itemIcon.Name = "itemIcon";
            this.itemIcon.Size = new System.Drawing.Size(60, 55);
            this.itemIcon.TabIndex = 0;
            this.itemIcon.TabStop = false;
            // 
            // appitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelitem);
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
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.PictureBox itemIcon;
    }
}
