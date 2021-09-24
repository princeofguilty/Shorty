
namespace Bro
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
            this.Startup_Check = new System.Windows.Forms.CheckBox();
            this.callbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrl_label = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.keyCbox = new System.Windows.Forms.ComboBox();
            this.controlCobox = new System.Windows.Forms.ComboBox();
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
            this.panel1.BackgroundImage = global::Bro.Properties.Resources.addpanel_default;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.Startup_Check);
            this.panel1.Controls.Add(this.callbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ctrl_label);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.keyCbox);
            this.panel1.Controls.Add(this.controlCobox);
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
            // Startup_Check
            // 
            this.Startup_Check.AutoSize = true;
            this.Startup_Check.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Startup_Check.ForeColor = System.Drawing.Color.White;
            this.Startup_Check.Location = new System.Drawing.Point(320, 181);
            this.Startup_Check.Name = "Startup_Check";
            this.Startup_Check.Size = new System.Drawing.Size(125, 19);
            this.Startup_Check.TabIndex = 7;
            this.Startup_Check.Text = "Run Bro on startup";
            this.Startup_Check.UseVisualStyleBackColor = true;
            this.Startup_Check.CheckStateChanged += new System.EventHandler(this.Startup_Check_CheckStateChanged);
            // 
            // callbox
            // 
            this.callbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.callbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callbox.ForeColor = System.Drawing.Color.White;
            this.callbox.Location = new System.Drawing.Point(112, 103);
            this.callbox.MaxLength = 25;
            this.callbox.Name = "callbox";
            this.callbox.Size = new System.Drawing.Size(194, 25);
            this.callbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shortcut Call";
            // 
            // ctrl_label
            // 
            this.ctrl_label.AutoSize = true;
            this.ctrl_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctrl_label.ForeColor = System.Drawing.Color.White;
            this.ctrl_label.Location = new System.Drawing.Point(112, 142);
            this.ctrl_label.Name = "ctrl_label";
            this.ctrl_label.Size = new System.Drawing.Size(46, 21);
            this.ctrl_label.TabIndex = 4;
            this.ctrl_label.Text = "CTRL";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(239, 177);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(137, 177);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // keyCbox
            // 
            this.keyCbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.keyCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyCbox.ForeColor = System.Drawing.Color.White;
            this.keyCbox.FormattingEnabled = true;
            this.keyCbox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.keyCbox.Location = new System.Drawing.Point(239, 142);
            this.keyCbox.Name = "keyCbox";
            this.keyCbox.Size = new System.Drawing.Size(67, 23);
            this.keyCbox.TabIndex = 3;
            // 
            // controlCobox
            // 
            this.controlCobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.controlCobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlCobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.controlCobox.ForeColor = System.Drawing.Color.White;
            this.controlCobox.FormattingEnabled = true;
            this.controlCobox.Items.AddRange(new object[] {
            "ALT",
            "SHIFT"});
            this.controlCobox.Location = new System.Drawing.Point(171, 142);
            this.controlCobox.Name = "controlCobox";
            this.controlCobox.Size = new System.Drawing.Size(62, 23);
            this.controlCobox.TabIndex = 3;
            this.controlCobox.SelectionChangeCommitted += new System.EventHandler(this.controlCobox_SelectionChangeCommitted);
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBox.Location = new System.Drawing.Point(361, 29);
            this.iconBox.Margin = new System.Windows.Forms.Padding(0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(32, 32);
            this.iconBox.TabIndex = 2;
            this.iconBox.TabStop = false;
            // 
            // locBox
            // 
            this.locBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.locBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locBox.ForeColor = System.Drawing.Color.White;
            this.locBox.Location = new System.Drawing.Point(112, 68);
            this.locBox.MaxLength = 25;
            this.locBox.Name = "locBox";
            this.locBox.ReadOnly = true;
            this.locBox.Size = new System.Drawing.Size(194, 25);
            this.locBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(182)))));
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(112, 29);
            this.nameBox.MaxLength = 25;
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(194, 25);
            this.nameBox.TabIndex = 1;
            // 
            // scut_Label
            // 
            this.scut_Label.AutoSize = true;
            this.scut_Label.BackColor = System.Drawing.Color.Transparent;
            this.scut_Label.ForeColor = System.Drawing.Color.White;
            this.scut_Label.Location = new System.Drawing.Point(24, 147);
            this.scut_Label.Name = "scut_Label";
            this.scut_Label.Size = new System.Drawing.Size(57, 15);
            this.scut_Label.TabIndex = 0;
            this.scut_Label.Text = "Short Key";
            // 
            // loc_Label
            // 
            this.loc_Label.AutoSize = true;
            this.loc_Label.BackColor = System.Drawing.Color.Transparent;
            this.loc_Label.ForeColor = System.Drawing.Color.White;
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
            this.name_Label.ForeColor = System.Drawing.Color.White;
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
            this.Load += new System.EventHandler(this.uc_Edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox locBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label loc_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label scut_Label;
        private System.Windows.Forms.ComboBox keyCbox;
        private System.Windows.Forms.ComboBox controlCobox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label ctrl_label;
        private System.Windows.Forms.TextBox callbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Startup_Check;
    }
}
