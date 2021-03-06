﻿namespace JukeBox
{
    partial class JukeBox_frm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JukeBox_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.GenreList_LstBox = new System.Windows.Forms.ListBox();
            this.GenreTitle_txtBox = new System.Windows.Forms.TextBox();
            this.Playing_txtBox = new System.Windows.Forms.TextBox();
            this.PlayList_LstBox = new System.Windows.Forms.ListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Setup_txtBoxMenu = new System.Windows.Forms.ToolStripTextBox();
            this.About_txtBoxMenu = new System.Windows.Forms.ToolStripTextBox();
            this.ToolBar_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.WinMediaPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.TrackTime_Timer = new System.Windows.Forms.Timer(this.components);
            this.ToolBar_MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright 2018 Ross Claydon";
            // 
            // GenreList_LstBox
            // 
            this.GenreList_LstBox.FormattingEnabled = true;
            this.GenreList_LstBox.ItemHeight = 25;
            this.GenreList_LstBox.Location = new System.Drawing.Point(170, 265);
            this.GenreList_LstBox.Name = "GenreList_LstBox";
            this.GenreList_LstBox.Size = new System.Drawing.Size(369, 129);
            this.GenreList_LstBox.TabIndex = 1;
            this.GenreList_LstBox.DoubleClick += new System.EventHandler(this.GenreList_LstBox_DoubleClick);
            // 
            // GenreTitle_txtBox
            // 
            this.GenreTitle_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GenreTitle_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTitle_txtBox.Location = new System.Drawing.Point(170, 237);
            this.GenreTitle_txtBox.Name = "GenreTitle_txtBox";
            this.GenreTitle_txtBox.ReadOnly = true;
            this.GenreTitle_txtBox.Size = new System.Drawing.Size(369, 31);
            this.GenreTitle_txtBox.TabIndex = 2;
            this.GenreTitle_txtBox.Text = "General";
            // 
            // Playing_txtBox
            // 
            this.Playing_txtBox.BackColor = System.Drawing.Color.Lime;
            this.Playing_txtBox.Location = new System.Drawing.Point(170, 481);
            this.Playing_txtBox.Name = "Playing_txtBox";
            this.Playing_txtBox.ReadOnly = true;
            this.Playing_txtBox.Size = new System.Drawing.Size(369, 31);
            this.Playing_txtBox.TabIndex = 3;
            // 
            // PlayList_LstBox
            // 
            this.PlayList_LstBox.FormattingEnabled = true;
            this.PlayList_LstBox.ItemHeight = 25;
            this.PlayList_LstBox.Location = new System.Drawing.Point(211, 556);
            this.PlayList_LstBox.Name = "PlayList_LstBox";
            this.PlayList_LstBox.Size = new System.Drawing.Size(287, 204);
            this.PlayList_LstBox.TabIndex = 4;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(170, 388);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(369, 34);
            this.hScrollBar1.TabIndex = 7;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // Setup_txtBoxMenu
            // 
            this.Setup_txtBoxMenu.Name = "Setup_txtBoxMenu";
            this.Setup_txtBoxMenu.ReadOnly = true;
            this.Setup_txtBoxMenu.Size = new System.Drawing.Size(100, 39);
            this.Setup_txtBoxMenu.Text = "Setup";
            this.Setup_txtBoxMenu.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // About_txtBoxMenu
            // 
            this.About_txtBoxMenu.Name = "About_txtBoxMenu";
            this.About_txtBoxMenu.ReadOnly = true;
            this.About_txtBoxMenu.Size = new System.Drawing.Size(100, 39);
            this.About_txtBoxMenu.Text = "About";
            this.About_txtBoxMenu.Click += new System.EventHandler(this.About_txtBoxMenu_Click);
            // 
            // ToolBar_MenuStrip
            // 
            this.ToolBar_MenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolBar_MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolBar_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setup_txtBoxMenu,
            this.About_txtBoxMenu});
            this.ToolBar_MenuStrip.Location = new System.Drawing.Point(0, 916);
            this.ToolBar_MenuStrip.Name = "ToolBar_MenuStrip";
            this.ToolBar_MenuStrip.Size = new System.Drawing.Size(701, 43);
            this.ToolBar_MenuStrip.TabIndex = 5;
            this.ToolBar_MenuStrip.Text = "menuStrip1";
            // 
            // WinMediaPlay
            // 
            this.WinMediaPlay.Enabled = true;
            this.WinMediaPlay.Location = new System.Drawing.Point(12, 23);
            this.WinMediaPlay.Name = "WinMediaPlay";
            this.WinMediaPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMediaPlay.OcxState")));
            this.WinMediaPlay.Size = new System.Drawing.Size(263, 69);
            this.WinMediaPlay.TabIndex = 8;
            this.WinMediaPlay.Visible = false;
            this.WinMediaPlay.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WinMediaPlay_PlayStateChange);
            // 
            // TrackTime_Timer
            // 
            this.TrackTime_Timer.Tick += new System.EventHandler(this.TrackTime_Timer_Tick);
            // 
            // JukeBox_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(701, 959);
            this.Controls.Add(this.WinMediaPlay);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.PlayList_LstBox);
            this.Controls.Add(this.Playing_txtBox);
            this.Controls.Add(this.GenreTitle_txtBox);
            this.Controls.Add(this.GenreList_LstBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToolBar_MenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.ToolBar_MenuStrip;
            this.Name = "JukeBox_frm";
            this.Text = "My Juke Box v1.0";
            this.Load += new System.EventHandler(this.JukeBox_frm_Load);
            this.ToolBar_MenuStrip.ResumeLayout(false);
            this.ToolBar_MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox GenreList_LstBox;
        private System.Windows.Forms.TextBox GenreTitle_txtBox;
        private System.Windows.Forms.TextBox Playing_txtBox;
        private System.Windows.Forms.ListBox PlayList_LstBox;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ToolStripTextBox Setup_txtBoxMenu;
        private System.Windows.Forms.ToolStripTextBox About_txtBoxMenu;
        private System.Windows.Forms.MenuStrip ToolBar_MenuStrip;
        private AxWMPLib.AxWindowsMediaPlayer WinMediaPlay;
        private System.Windows.Forms.Timer TrackTime_Timer;
    }
}

