namespace EvergreenDesktopReporter
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lstb_settings = new System.Windows.Forms.ListBox();
            this.grpb_settings = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lstb_settings
            // 
            this.lstb_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstb_settings.FormattingEnabled = true;
            this.lstb_settings.Items.AddRange(new object[] {
            "Application Settings",
            "Evergreen Server Settings"});
            this.lstb_settings.Location = new System.Drawing.Point(7, 15);
            this.lstb_settings.Name = "lstb_settings";
            this.lstb_settings.Size = new System.Drawing.Size(212, 511);
            this.lstb_settings.TabIndex = 4;
            this.lstb_settings.SelectedValueChanged += new System.EventHandler(this.lstb_settings_SelectedValueChanged);
            // 
            // grpb_settings
            // 
            this.grpb_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpb_settings.Location = new System.Drawing.Point(225, 12);
            this.grpb_settings.Name = "grpb_settings";
            this.grpb_settings.Size = new System.Drawing.Size(582, 519);
            this.grpb_settings.TabIndex = 3;
            this.grpb_settings.TabStop = false;
            this.grpb_settings.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 543);
            this.Controls.Add(this.lstb_settings);
            this.Controls.Add(this.grpb_settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_settings;
        private System.Windows.Forms.GroupBox grpb_settings;
    }
}