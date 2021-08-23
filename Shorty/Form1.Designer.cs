
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
            this.mainbar = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.cancle_Adding = new System.Windows.Forms.Button();
            this.additionBtn = new System.Windows.Forms.Button();
            this.minmizeBtn = new System.Windows.Forms.Button();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Panel();
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainbar
            // 
            this.mainbar.BackgroundImage = global::Shorty.Properties.Resources.formbg;
            this.mainbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainbar.Controls.Add(this.closeBtn);
            this.mainbar.Controls.Add(this.cancle_Adding);
            this.mainbar.Controls.Add(this.additionBtn);
            this.mainbar.Controls.Add(this.minmizeBtn);
            this.mainbar.Controls.Add(this.inputTxt);
            this.mainbar.Controls.Add(this.logo);
            this.mainbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainbar.Location = new System.Drawing.Point(0, 0);
            this.mainbar.Margin = new System.Windows.Forms.Padding(0);
            this.mainbar.Name = "mainbar";
            this.mainbar.Size = new System.Drawing.Size(450, 55);
            this.mainbar.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = global::Shorty.Properties.Resources.exitbtn;
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
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // cancle_Adding
            // 
            this.cancle_Adding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancle_Adding.BackColor = System.Drawing.Color.Transparent;
            this.cancle_Adding.BackgroundImage = global::Shorty.Properties.Resources.addpressed;
            this.cancle_Adding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancle_Adding.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancle_Adding.FlatAppearance.BorderSize = 0;
            this.cancle_Adding.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cancle_Adding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cancle_Adding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancle_Adding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancle_Adding.ImageKey = "(none)";
            this.cancle_Adding.Location = new System.Drawing.Point(345, 16);
            this.cancle_Adding.Name = "cancle_Adding";
            this.cancle_Adding.Size = new System.Drawing.Size(27, 23);
            this.cancle_Adding.TabIndex = 1;
            this.cancle_Adding.UseVisualStyleBackColor = false;
            this.cancle_Adding.Visible = false;
            this.cancle_Adding.Click += new System.EventHandler(this.cancle_Adding_Click);
            // 
            // additionBtn
            // 
            this.additionBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionBtn.BackColor = System.Drawing.Color.Transparent;
            this.additionBtn.BackgroundImage = global::Shorty.Properties.Resources.addbtn;
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
            this.additionBtn.TabIndex = 1;
            this.additionBtn.UseVisualStyleBackColor = false;
            this.additionBtn.Click += new System.EventHandler(this.additionBtn_Click);
            // 
            // minmizeBtn
            // 
            this.minmizeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minmizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minmizeBtn.BackgroundImage = global::Shorty.Properties.Resources.minimizebtn;
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
            this.minmizeBtn.TabIndex = 1;
            this.minmizeBtn.UseVisualStyleBackColor = false;
            this.minmizeBtn.Click += new System.EventHandler(this.minmizeBtn_Click);
            // 
            // inputTxt
            // 
            this.inputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTxt.Location = new System.Drawing.Point(75, 17);
            this.inputTxt.MaxLength = 25;
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.PlaceholderText = "What are you looking for ?";
            this.inputTxt.Size = new System.Drawing.Size(252, 22);
            this.inputTxt.TabIndex = 0;
            this.inputTxt.TextChanged += new System.EventHandler(this.inputTxt_TextChanged);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Shorty.Properties.Resources.Group_1;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 55);
            this.logo.TabIndex = 0;
            // 
            // _flowLayoutPanel
            // 
            this._flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowLayoutPanel.Location = new System.Drawing.Point(0, 55);
            this._flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            this._flowLayoutPanel.Size = new System.Drawing.Size(450, 218);
            this._flowLayoutPanel.TabIndex = 0;
            // 
            // Shorty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(450, 273);
            this.Controls.Add(this._flowLayoutPanel);
            this.Controls.Add(this.mainbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shorty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Shorty_Load);
            this.mainbar.ResumeLayout(false);
            this.mainbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainbar;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minmizeBtn;
        private System.Windows.Forms.Button additionBtn;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;
        private System.Windows.Forms.Button cancle_Adding;
    }
}

