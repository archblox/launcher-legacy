﻿namespace ARCHBLOXLauncher_XP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.JoinBox = new System.Windows.Forms.GroupBox();
            this.serverip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HostBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BackBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.JoinBTN = new System.Windows.Forms.Button();
            this.HostBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.JoinBox.SuspendLayout();
            this.HostBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JoinBox
            // 
            this.JoinBox.BackColor = System.Drawing.Color.Black;
            this.JoinBox.Controls.Add(this.serverip);
            this.JoinBox.Controls.Add(this.label4);
            this.JoinBox.Controls.Add(this.serverport);
            this.JoinBox.Controls.Add(this.label7);
            this.JoinBox.Controls.Add(this.button2);
            this.JoinBox.Location = new System.Drawing.Point(6, 44);
            this.JoinBox.Name = "JoinBox";
            this.JoinBox.Size = new System.Drawing.Size(245, 130);
            this.JoinBox.TabIndex = 26;
            this.JoinBox.TabStop = false;
            this.JoinBox.Visible = false;
            // 
            // serverip
            // 
            this.serverip.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.serverip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serverip.Location = new System.Drawing.Point(5, 35);
            this.serverip.MaxLength = 15;
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(237, 20);
            this.serverip.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Server IP (Use localhost if joining your own server)";
            // 
            // serverport
            // 
            this.serverport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serverport.Location = new System.Drawing.Point(5, 73);
            this.serverport.MaxLength = 5;
            this.serverport.Name = "serverport";
            this.serverport.Size = new System.Drawing.Size(235, 20);
            this.serverport.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(5, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Server Port";
            // 
            // HostBox
            // 
            this.HostBox.BackColor = System.Drawing.Color.Black;
            this.HostBox.Controls.Add(this.label2);
            this.HostBox.Controls.Add(this.textBox1);
            this.HostBox.Controls.Add(this.label3);
            this.HostBox.Controls.Add(this.button3);
            this.HostBox.Controls.Add(this.textBox2);
            this.HostBox.Controls.Add(this.button1);
            this.HostBox.Location = new System.Drawing.Point(6, 44);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(247, 121);
            this.HostBox.TabIndex = 27;
            this.HostBox.TabStop = false;
            this.HostBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Port (53640 is recommended)";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(5, 33);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Filename (use temp.rbxl if unsure)";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(5, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 25;
            // 
            // BackBTN
            // 
            this.BackBTN.BackgroundImage = global::ARCHBLOXLauncher_XP.Properties.Resources.buttonblue;
            this.BackBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBTN.Location = new System.Drawing.Point(197, 12);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(57, 24);
            this.BackBTN.TabIndex = 31;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Visible = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackgroundImage = global::ARCHBLOXLauncher_XP.Properties.Resources.buttonblue;
            this.UpdateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBTN.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F);
            this.UpdateBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBTN.Location = new System.Drawing.Point(10, 62);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(237, 46);
            this.UpdateBTN.TabIndex = 30;
            this.UpdateBTN.Text = "Install";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // JoinBTN
            // 
            this.JoinBTN.BackgroundImage = global::ARCHBLOXLauncher_XP.Properties.Resources.buttonblue;
            this.JoinBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JoinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JoinBTN.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.JoinBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JoinBTN.Location = new System.Drawing.Point(133, 113);
            this.JoinBTN.Name = "JoinBTN";
            this.JoinBTN.Size = new System.Drawing.Size(116, 45);
            this.JoinBTN.TabIndex = 29;
            this.JoinBTN.Text = "Join a Game";
            this.JoinBTN.UseVisualStyleBackColor = true;
            this.JoinBTN.Click += new System.EventHandler(this.JoinBTN_Click);
            // 
            // HostBTN
            // 
            this.HostBTN.BackgroundImage = global::ARCHBLOXLauncher_XP.Properties.Resources.buttonblue;
            this.HostBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HostBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HostBTN.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.HostBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HostBTN.Location = new System.Drawing.Point(10, 113);
            this.HostBTN.Name = "HostBTN";
            this.HostBTN.Size = new System.Drawing.Size(117, 45);
            this.HostBTN.TabIndex = 28;
            this.HostBTN.Text = "Host a Game";
            this.HostBTN.UseVisualStyleBackColor = true;
            this.HostBTN.Click += new System.EventHandler(this.HostBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ARCHBLOXLauncher_XP.Properties.Resources.unknown;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = global::ARCHBLOXLauncher_XP.Properties.Resources.buttongreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(5, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 19);
            this.button2.TabIndex = 24;
            this.button2.Text = "Join";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ARCHBLOXLauncher_XP.Properties.Resources.buttonblue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(177, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 19);
            this.button3.TabIndex = 26;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::ARCHBLOXLauncher_XP.Properties.Resources.buttongreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(5, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 19);
            this.button1.TabIndex = 28;
            this.button1.Text = "Host";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Legacy Edition for Windows XP/Vista";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(259, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.JoinBTN);
            this.Controls.Add(this.HostBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JoinBox);
            this.Controls.Add(this.HostBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ARCHBLOX";
            this.JoinBox.ResumeLayout(false);
            this.JoinBox.PerformLayout();
            this.HostBox.ResumeLayout(false);
            this.HostBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox JoinBox;
        private System.Windows.Forms.TextBox serverip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox HostBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HostBTN;
        private System.Windows.Forms.Button JoinBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Label label1;
    }
}
