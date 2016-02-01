namespace EvergreenDesktopReporter
{
    partial class OculusSettings
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
            this.chk_RememberMe = new System.Windows.Forms.CheckBox();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.txtb_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.chk_AutoConnect = new System.Windows.Forms.CheckBox();
            this.txtb_ServerIP = new System.Windows.Forms.TextBox();
            this.lbl_SetIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_RememberMe
            // 
            this.chk_RememberMe.AutoSize = true;
            this.chk_RememberMe.Location = new System.Drawing.Point(62, 234);
            this.chk_RememberMe.Name = "chk_RememberMe";
            this.chk_RememberMe.Size = new System.Drawing.Size(95, 17);
            this.chk_RememberMe.TabIndex = 39;
            this.chk_RememberMe.Text = "Remember Me";
            this.chk_RememberMe.UseVisualStyleBackColor = true;
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(147, 195);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.PasswordChar = '*';
            this.txtb_Password.Size = new System.Drawing.Size(341, 20);
            this.txtb_Password.TabIndex = 38;
            // 
            // txtb_UserName
            // 
            this.txtb_UserName.Location = new System.Drawing.Point(147, 169);
            this.txtb_UserName.Name = "txtb_UserName";
            this.txtb_UserName.Size = new System.Drawing.Size(341, 20);
            this.txtb_UserName.TabIndex = 37;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(59, 193);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 36;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(59, 169);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(63, 13);
            this.lbl_UserName.TabIndex = 35;
            this.lbl_UserName.Text = "User Name:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(236, 234);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(123, 48);
            this.btn_Connect.TabIndex = 34;
            this.btn_Connect.Text = "Test Connection";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // chk_AutoConnect
            // 
            this.chk_AutoConnect.AutoSize = true;
            this.chk_AutoConnect.Location = new System.Drawing.Point(62, 140);
            this.chk_AutoConnect.Name = "chk_AutoConnect";
            this.chk_AutoConnect.Size = new System.Drawing.Size(91, 17);
            this.chk_AutoConnect.TabIndex = 33;
            this.chk_AutoConnect.Text = "Auto Connect";
            this.chk_AutoConnect.UseVisualStyleBackColor = true;
            // 
            // txtb_ServerIP
            // 
            this.txtb_ServerIP.Location = new System.Drawing.Point(147, 106);
            this.txtb_ServerIP.Name = "txtb_ServerIP";
            this.txtb_ServerIP.Size = new System.Drawing.Size(341, 20);
            this.txtb_ServerIP.TabIndex = 32;
            // 
            // lbl_SetIP
            // 
            this.lbl_SetIP.AutoSize = true;
            this.lbl_SetIP.Location = new System.Drawing.Point(59, 109);
            this.lbl_SetIP.Name = "lbl_SetIP";
            this.lbl_SetIP.Size = new System.Drawing.Size(82, 13);
            this.lbl_SetIP.TabIndex = 31;
            this.lbl_SetIP.Text = "Enter Server IP:";
            // 
            // OculusSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_RememberMe);
            this.Controls.Add(this.txtb_Password);
            this.Controls.Add(this.txtb_UserName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.chk_AutoConnect);
            this.Controls.Add(this.txtb_ServerIP);
            this.Controls.Add(this.lbl_SetIP);
            this.Name = "OculusSettings";
            this.Size = new System.Drawing.Size(578, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_RememberMe;
        private System.Windows.Forms.TextBox txtb_Password;
        private System.Windows.Forms.TextBox txtb_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.CheckBox chk_AutoConnect;
        private System.Windows.Forms.TextBox txtb_ServerIP;
        private System.Windows.Forms.Label lbl_SetIP;
    }
}
