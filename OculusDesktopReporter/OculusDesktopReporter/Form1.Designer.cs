namespace EvergreenDesktopReporter
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ntfy_Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntxt_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEvergreenDesktopReporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_VolumeControl = new System.Windows.Forms.Label();
            this.lbl_MonitorControl = new System.Windows.Forms.Label();
            this.chkb_VolumeControl = new System.Windows.Forms.CheckBox();
            this.chkb_MonitorControl = new System.Windows.Forms.CheckBox();
            this.chkb_StatusReadEnable = new System.Windows.Forms.CheckBox();
            this.lbl_StatusReadEnable = new System.Windows.Forms.Label();
            this.chkb_RemoteLock = new System.Windows.Forms.CheckBox();
            this.lbl_RemoteLock = new System.Windows.Forms.Label();
            this.chkb_WebCamFeedEnable = new System.Windows.Forms.CheckBox();
            this.lbl_WebcamFeedEnable = new System.Windows.Forms.Label();
            this.chkb_ShareScreenEnable = new System.Windows.Forms.CheckBox();
            this.lbl_ScreenShareEnable = new System.Windows.Forms.Label();
            this.muteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxt_Menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntfy_Tray
            // 
            this.ntfy_Tray.ContextMenuStrip = this.cntxt_Menu;
            this.ntfy_Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfy_Tray.Icon")));
            this.ntfy_Tray.Text = "Evergreen Desktop Reporter";
            this.ntfy_Tray.Visible = true;
            this.ntfy_Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfy_Tray_MouseDoubleClick);
            // 
            // cntxt_Menu
            // 
            this.cntxt_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muteModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cntxt_Menu.Name = "cntxt_Menu";
            this.cntxt_Menu.Size = new System.Drawing.Size(153, 70);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEvergreenDesktopReporterToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutEvergreenDesktopReporterToolStripMenuItem
            // 
            this.aboutEvergreenDesktopReporterToolStripMenuItem.Name = "aboutEvergreenDesktopReporterToolStripMenuItem";
            this.aboutEvergreenDesktopReporterToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.aboutEvergreenDesktopReporterToolStripMenuItem.Text = "&About Oculus Desktop Reporter";
            this.aboutEvergreenDesktopReporterToolStripMenuItem.Click += new System.EventHandler(this.aboutEvergreenDesktopReporterToolStripMenuItem_Click);
            // 
            // lbl_VolumeControl
            // 
            this.lbl_VolumeControl.AutoSize = true;
            this.lbl_VolumeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VolumeControl.Location = new System.Drawing.Point(12, 37);
            this.lbl_VolumeControl.Name = "lbl_VolumeControl";
            this.lbl_VolumeControl.Size = new System.Drawing.Size(118, 20);
            this.lbl_VolumeControl.TabIndex = 2;
            this.lbl_VolumeControl.Text = "Volume Control";
            // 
            // lbl_MonitorControl
            // 
            this.lbl_MonitorControl.AutoSize = true;
            this.lbl_MonitorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MonitorControl.Location = new System.Drawing.Point(12, 69);
            this.lbl_MonitorControl.Name = "lbl_MonitorControl";
            this.lbl_MonitorControl.Size = new System.Drawing.Size(117, 20);
            this.lbl_MonitorControl.TabIndex = 3;
            this.lbl_MonitorControl.Text = "Monitor Control";
            // 
            // chkb_VolumeControl
            // 
            this.chkb_VolumeControl.AutoSize = true;
            this.chkb_VolumeControl.Location = new System.Drawing.Point(324, 43);
            this.chkb_VolumeControl.Name = "chkb_VolumeControl";
            this.chkb_VolumeControl.Size = new System.Drawing.Size(15, 14);
            this.chkb_VolumeControl.TabIndex = 4;
            this.chkb_VolumeControl.UseVisualStyleBackColor = true;
            // 
            // chkb_MonitorControl
            // 
            this.chkb_MonitorControl.AutoSize = true;
            this.chkb_MonitorControl.Location = new System.Drawing.Point(324, 75);
            this.chkb_MonitorControl.Name = "chkb_MonitorControl";
            this.chkb_MonitorControl.Size = new System.Drawing.Size(15, 14);
            this.chkb_MonitorControl.TabIndex = 5;
            this.chkb_MonitorControl.UseVisualStyleBackColor = true;
            // 
            // chkb_StatusReadEnable
            // 
            this.chkb_StatusReadEnable.AutoSize = true;
            this.chkb_StatusReadEnable.Location = new System.Drawing.Point(324, 106);
            this.chkb_StatusReadEnable.Name = "chkb_StatusReadEnable";
            this.chkb_StatusReadEnable.Size = new System.Drawing.Size(15, 14);
            this.chkb_StatusReadEnable.TabIndex = 7;
            this.chkb_StatusReadEnable.UseVisualStyleBackColor = true;
            // 
            // lbl_StatusReadEnable
            // 
            this.lbl_StatusReadEnable.AutoSize = true;
            this.lbl_StatusReadEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusReadEnable.Location = new System.Drawing.Point(12, 100);
            this.lbl_StatusReadEnable.Name = "lbl_StatusReadEnable";
            this.lbl_StatusReadEnable.Size = new System.Drawing.Size(153, 20);
            this.lbl_StatusReadEnable.TabIndex = 6;
            this.lbl_StatusReadEnable.Text = "Status Read Enable";
            // 
            // chkb_RemoteLock
            // 
            this.chkb_RemoteLock.AutoSize = true;
            this.chkb_RemoteLock.Location = new System.Drawing.Point(324, 139);
            this.chkb_RemoteLock.Name = "chkb_RemoteLock";
            this.chkb_RemoteLock.Size = new System.Drawing.Size(15, 14);
            this.chkb_RemoteLock.TabIndex = 9;
            this.chkb_RemoteLock.UseVisualStyleBackColor = true;
            // 
            // lbl_RemoteLock
            // 
            this.lbl_RemoteLock.AutoSize = true;
            this.lbl_RemoteLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RemoteLock.Location = new System.Drawing.Point(12, 133);
            this.lbl_RemoteLock.Name = "lbl_RemoteLock";
            this.lbl_RemoteLock.Size = new System.Drawing.Size(104, 20);
            this.lbl_RemoteLock.TabIndex = 8;
            this.lbl_RemoteLock.Text = "Remote Lock";
            // 
            // chkb_WebCamFeedEnable
            // 
            this.chkb_WebCamFeedEnable.AutoSize = true;
            this.chkb_WebCamFeedEnable.Location = new System.Drawing.Point(324, 205);
            this.chkb_WebCamFeedEnable.Name = "chkb_WebCamFeedEnable";
            this.chkb_WebCamFeedEnable.Size = new System.Drawing.Size(15, 14);
            this.chkb_WebCamFeedEnable.TabIndex = 13;
            this.chkb_WebCamFeedEnable.UseVisualStyleBackColor = true;
            // 
            // lbl_WebcamFeedEnable
            // 
            this.lbl_WebcamFeedEnable.AutoSize = true;
            this.lbl_WebcamFeedEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WebcamFeedEnable.Location = new System.Drawing.Point(12, 199);
            this.lbl_WebcamFeedEnable.Name = "lbl_WebcamFeedEnable";
            this.lbl_WebcamFeedEnable.Size = new System.Drawing.Size(167, 20);
            this.lbl_WebcamFeedEnable.TabIndex = 12;
            this.lbl_WebcamFeedEnable.Text = "Webcam Feed Enable";
            // 
            // chkb_ShareScreenEnable
            // 
            this.chkb_ShareScreenEnable.AutoSize = true;
            this.chkb_ShareScreenEnable.Location = new System.Drawing.Point(324, 172);
            this.chkb_ShareScreenEnable.Name = "chkb_ShareScreenEnable";
            this.chkb_ShareScreenEnable.Size = new System.Drawing.Size(15, 14);
            this.chkb_ShareScreenEnable.TabIndex = 11;
            this.chkb_ShareScreenEnable.UseVisualStyleBackColor = true;
            // 
            // lbl_ScreenShareEnable
            // 
            this.lbl_ScreenShareEnable.AutoSize = true;
            this.lbl_ScreenShareEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScreenShareEnable.Location = new System.Drawing.Point(12, 166);
            this.lbl_ScreenShareEnable.Name = "lbl_ScreenShareEnable";
            this.lbl_ScreenShareEnable.Size = new System.Drawing.Size(161, 20);
            this.lbl_ScreenShareEnable.TabIndex = 10;
            this.lbl_ScreenShareEnable.Text = "Screen Share Enable";
            // 
            // muteModeToolStripMenuItem
            // 
            this.muteModeToolStripMenuItem.Name = "muteModeToolStripMenuItem";
            this.muteModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.muteModeToolStripMenuItem.Text = "Mute Mode";
            this.muteModeToolStripMenuItem.Click += new System.EventHandler(this.muteModeToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 416);
            this.ControlBox = false;
            this.Controls.Add(this.chkb_WebCamFeedEnable);
            this.Controls.Add(this.lbl_WebcamFeedEnable);
            this.Controls.Add(this.chkb_ShareScreenEnable);
            this.Controls.Add(this.lbl_ScreenShareEnable);
            this.Controls.Add(this.chkb_RemoteLock);
            this.Controls.Add(this.lbl_RemoteLock);
            this.Controls.Add(this.chkb_StatusReadEnable);
            this.Controls.Add(this.lbl_StatusReadEnable);
            this.Controls.Add(this.chkb_MonitorControl);
            this.Controls.Add(this.chkb_VolumeControl);
            this.Controls.Add(this.lbl_MonitorControl);
            this.Controls.Add(this.lbl_VolumeControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Evergreen Desktop Reporter (Offline)";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.cntxt_Menu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntfy_Tray;
        private System.Windows.Forms.ContextMenuStrip cntxt_Menu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEvergreenDesktopReporterToolStripMenuItem;
        private System.Windows.Forms.Label lbl_VolumeControl;
        private System.Windows.Forms.Label lbl_MonitorControl;
        private System.Windows.Forms.CheckBox chkb_VolumeControl;
        private System.Windows.Forms.CheckBox chkb_MonitorControl;
        private System.Windows.Forms.CheckBox chkb_StatusReadEnable;
        private System.Windows.Forms.Label lbl_StatusReadEnable;
        private System.Windows.Forms.CheckBox chkb_RemoteLock;
        private System.Windows.Forms.Label lbl_RemoteLock;
        private System.Windows.Forms.CheckBox chkb_WebCamFeedEnable;
        private System.Windows.Forms.Label lbl_WebcamFeedEnable;
        private System.Windows.Forms.CheckBox chkb_ShareScreenEnable;
        private System.Windows.Forms.Label lbl_ScreenShareEnable;
        private System.Windows.Forms.ToolStripMenuItem muteModeToolStripMenuItem;
    }
}

