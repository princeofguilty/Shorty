﻿
namespace Shorty
{
    partial class uc_Edit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.locBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.scut_Label = new System.Windows.Forms.Label();
            this.loc_Label = new System.Windows.Forms.Label();
            this.name_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Shorty.Properties.Resources.downpanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.iconBox);
            this.panel1.Controls.Add(this.locBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.scut_Label);
            this.panel1.Controls.Add(this.loc_Label);
            this.panel1.Controls.Add(this.name_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 218);
            this.panel1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(188, 177);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.comboBox3.Location = new System.Drawing.Point(224, 128);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(52, 23);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ALT",
            "SHIFT"});
            this.comboBox2.Location = new System.Drawing.Point(166, 128);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CTRL"});
            this.comboBox1.Location = new System.Drawing.Point(108, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox.Location = new System.Drawing.Point(342, 26);
            this.iconBox.Margin = new System.Windows.Forms.Padding(0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(60, 60);
            this.iconBox.TabIndex = 2;
            this.iconBox.TabStop = false;
            // 
            // locBox
            // 
            this.locBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locBox.Location = new System.Drawing.Point(112, 68);
            this.locBox.MaxLength = 25;
            this.locBox.Name = "locBox";
            this.locBox.Size = new System.Drawing.Size(194, 25);
            this.locBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(112, 29);
            this.nameBox.MaxLength = 25;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(194, 25);
            this.nameBox.TabIndex = 1;
            // 
            // scut_Label
            // 
            this.scut_Label.AutoSize = true;
            this.scut_Label.BackColor = System.Drawing.Color.Transparent;
            this.scut_Label.Location = new System.Drawing.Point(24, 136);
            this.scut_Label.Name = "scut_Label";
            this.scut_Label.Size = new System.Drawing.Size(57, 15);
            this.scut_Label.TabIndex = 0;
            this.scut_Label.Text = "Short Key";
            // 
            // loc_Label
            // 
            this.loc_Label.AutoSize = true;
            this.loc_Label.BackColor = System.Drawing.Color.Transparent;
            this.loc_Label.Location = new System.Drawing.Point(24, 71);
            this.loc_Label.Name = "loc_Label";
            this.loc_Label.Size = new System.Drawing.Size(75, 15);
            this.loc_Label.TabIndex = 0;
            this.loc_Label.Text = "App location";
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.BackColor = System.Drawing.Color.Transparent;
            this.name_Label.Location = new System.Drawing.Point(24, 32);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(62, 15);
            this.name_Label.TabIndex = 0;
            this.name_Label.Text = "App name";
            // 
            // uc_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_Edit";
            this.Size = new System.Drawing.Size(450, 218);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.TextBox locBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label loc_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label scut_Label;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addBtn;
    }
}
