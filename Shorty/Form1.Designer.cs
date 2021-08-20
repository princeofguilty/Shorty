
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainbar
            // 
            this.mainbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainbar.BackgroundImage")));
            this.mainbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainbar.Controls.Add(this.textBox1);
            this.mainbar.Controls.Add(this.logo);
            this.mainbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainbar.Location = new System.Drawing.Point(0, 0);
            this.mainbar.Name = "mainbar";
            this.mainbar.Size = new System.Drawing.Size(450, 55);
            this.mainbar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 218);
            this.panel1.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(79, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "What are you looking for ? :)";
            this.textBox1.Size = new System.Drawing.Size(254, 16);
            this.textBox1.TabIndex = 0;
            // 
            // Shorty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(450, 273);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel1;
    }
}

