
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shorty));
            this.mainbar = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minmizeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Panel();
            this.multiPnl = new System.Windows.Forms.Panel();
            this.mainbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainbar
            // 
            this.mainbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainbar.BackgroundImage")));
            this.mainbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainbar.Controls.Add(this.closeBtn);
            this.mainbar.Controls.Add(this.minmizeBtn);
            this.mainbar.Controls.Add(this.addBtn);
            this.mainbar.Controls.Add(this.inputTxt);
            this.mainbar.Controls.Add(this.logo);
            this.mainbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainbar.Location = new System.Drawing.Point(0, 0);
            this.mainbar.Name = "mainbar";
            this.mainbar.Size = new System.Drawing.Size(450, 55);
            this.mainbar.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ImageKey = "(none)";
            this.closeBtn.Location = new System.Drawing.Point(411, 16);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(27, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // minmizeBtn
            // 
            this.minmizeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minmizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minmizeBtn.BackgroundImage")));
            this.minmizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minmizeBtn.FlatAppearance.BorderSize = 0;
            this.minmizeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmizeBtn.ImageKey = "(none)";
            this.minmizeBtn.Location = new System.Drawing.Point(378, 16);
            this.minmizeBtn.Name = "minmizeBtn";
            this.minmizeBtn.Size = new System.Drawing.Size(27, 23);
            this.minmizeBtn.TabIndex = 1;
            this.minmizeBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ImageKey = "(none)";
            this.addBtn.Location = new System.Drawing.Point(345, 16);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(27, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // inputTxt
            // 
            this.inputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTxt.Location = new System.Drawing.Point(75, 17);
            this.inputTxt.MaxLength = 25;
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.PlaceholderText = "What are you looking for ? :)";
            this.inputTxt.Size = new System.Drawing.Size(252, 22);
            this.inputTxt.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 55);
            this.logo.TabIndex = 0;
            // 
            // multiPnl
            // 
            this.multiPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiPnl.Location = new System.Drawing.Point(0, 55);
            this.multiPnl.Name = "multiPnl";
            this.multiPnl.Size = new System.Drawing.Size(450, 218);
            this.multiPnl.TabIndex = 1;
            // 
            // Shorty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(450, 273);
            this.Controls.Add(this.multiPnl);
            this.Controls.Add(this.mainbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shorty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "shorty";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.mainbar.ResumeLayout(false);
            this.mainbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainbar;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel multiPnl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minmizeBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

