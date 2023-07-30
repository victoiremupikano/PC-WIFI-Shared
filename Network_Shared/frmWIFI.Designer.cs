namespace Network_Shared
{
    partial class frmWIFI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWIFI));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPWD = new System.Windows.Forms.Label();
            this.tabControlNet = new System.Windows.Forms.TabControl();
            this.tabPageSet = new System.Windows.Forms.TabPage();
            this.btnStart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBlocInterface = new System.Windows.Forms.RadioButton();
            this.chkVisual = new System.Windows.Forms.CheckBox();
            this.rbSetConfig = new System.Windows.Forms.RadioButton();
            this.tabPagePartager = new System.Windows.Forms.TabPage();
            this.lblIpv6 = new System.Windows.Forms.Label();
            this.tblocalip6 = new System.Windows.Forms.TextBox();
            this.lblIpv4 = new System.Windows.Forms.Label();
            this.lblSssid = new System.Windows.Forms.Label();
            this.chkPartager = new System.Windows.Forms.CheckBox();
            this.tblocalip = new System.Windows.Forms.TextBox();
            this.tblocalhost = new System.Windows.Forms.TextBox();
            this.cbListNetwork = new System.Windows.Forms.ComboBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.pnlEthiquete = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabControlNet.SuspendLayout();
            this.tabPageSet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPagePartager.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlEthiquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(10, 54);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(251, 27);
            this.txtNom.TabIndex = 0;
            // 
            // txtPWD
            // 
            this.txtPWD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWD.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWD.Location = new System.Drawing.Point(10, 115);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(251, 27);
            this.txtPWD.TabIndex = 1;
            this.txtPWD.UseSystemPasswordChar = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNom.Location = new System.Drawing.Point(10, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(116, 18);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom du wifi [SSID]";
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.BackColor = System.Drawing.Color.Transparent;
            this.lblPWD.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPWD.Location = new System.Drawing.Point(10, 90);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(193, 18);
            this.lblPWD.TabIndex = 6;
            this.lblPWD.Text = "Mot de passe (minimum 8 char)";
            // 
            // tabControlNet
            // 
            this.tabControlNet.Controls.Add(this.tabPageSet);
            this.tabControlNet.Controls.Add(this.tabPagePartager);
            this.tabControlNet.Controls.Add(this.tabPageAbout);
            this.tabControlNet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlNet.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlNet.Location = new System.Drawing.Point(0, 82);
            this.tabControlNet.Name = "tabControlNet";
            this.tabControlNet.SelectedIndex = 0;
            this.tabControlNet.Size = new System.Drawing.Size(291, 371);
            this.tabControlNet.TabIndex = 21;
            this.tabControlNet.SelectedIndexChanged += new System.EventHandler(this.tabControlNet_SelectedIndexChanged);
            // 
            // tabPageSet
            // 
            this.tabPageSet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageSet.Controls.Add(this.btnStart);
            this.tabPageSet.Controls.Add(this.groupBox1);
            this.tabPageSet.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSet.Location = new System.Drawing.Point(4, 26);
            this.tabPageSet.Name = "tabPageSet";
            this.tabPageSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSet.Size = new System.Drawing.Size(283, 341);
            this.tabPageSet.TabIndex = 0;
            this.tabPageSet.Text = "Publier";
            // 
            // btnStart
            // 
            this.btnStart.ActiveBorderThickness = 1;
            this.btnStart.ActiveCornerRadius = 20;
            this.btnStart.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStart.ActiveForecolor = System.Drawing.Color.White;
            this.btnStart.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.ButtonText = "START";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnStart.IdleBorderThickness = 1;
            this.btnStart.IdleCornerRadius = 20;
            this.btnStart.IdleFillColor = System.Drawing.Color.White;
            this.btnStart.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnStart.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnStart.Location = new System.Drawing.Point(18, 252);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(242, 41);
            this.btnStart.TabIndex = 24;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBlocInterface);
            this.groupBox1.Controls.Add(this.chkVisual);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblPWD);
            this.groupBox1.Controls.Add(this.rbSetConfig);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtPWD);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 209);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // rbBlocInterface
            // 
            this.rbBlocInterface.AutoSize = true;
            this.rbBlocInterface.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlocInterface.Location = new System.Drawing.Point(10, 175);
            this.rbBlocInterface.Name = "rbBlocInterface";
            this.rbBlocInterface.Size = new System.Drawing.Size(89, 20);
            this.rbBlocInterface.TabIndex = 27;
            this.rbBlocInterface.TabStop = true;
            this.rbBlocInterface.Text = "Desactiver";
            this.rbBlocInterface.UseVisualStyleBackColor = true;
            // 
            // chkVisual
            // 
            this.chkVisual.AutoSize = true;
            this.chkVisual.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisual.Location = new System.Drawing.Point(206, 94);
            this.chkVisual.Name = "chkVisual";
            this.chkVisual.Size = new System.Drawing.Size(15, 14);
            this.chkVisual.TabIndex = 23;
            this.chkVisual.UseVisualStyleBackColor = true;
            this.chkVisual.CheckedChanged += new System.EventHandler(this.chkVisual_CheckedChanged);
            // 
            // rbSetConfig
            // 
            this.rbSetConfig.AutoSize = true;
            this.rbSetConfig.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSetConfig.Location = new System.Drawing.Point(10, 150);
            this.rbSetConfig.Name = "rbSetConfig";
            this.rbSetConfig.Size = new System.Drawing.Size(88, 20);
            this.rbSetConfig.TabIndex = 26;
            this.rbSetConfig.TabStop = true;
            this.rbSetConfig.Text = "Configurer";
            this.rbSetConfig.UseVisualStyleBackColor = true;
            this.rbSetConfig.CheckedChanged += new System.EventHandler(this.rbSetConfig_CheckedChanged);
            // 
            // tabPagePartager
            // 
            this.tabPagePartager.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePartager.Controls.Add(this.lblIpv6);
            this.tabPagePartager.Controls.Add(this.tblocalip6);
            this.tabPagePartager.Controls.Add(this.lblIpv4);
            this.tabPagePartager.Controls.Add(this.lblSssid);
            this.tabPagePartager.Controls.Add(this.chkPartager);
            this.tabPagePartager.Controls.Add(this.tblocalip);
            this.tabPagePartager.Controls.Add(this.tblocalhost);
            this.tabPagePartager.Controls.Add(this.cbListNetwork);
            this.tabPagePartager.Location = new System.Drawing.Point(4, 26);
            this.tabPagePartager.Name = "tabPagePartager";
            this.tabPagePartager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePartager.Size = new System.Drawing.Size(283, 341);
            this.tabPagePartager.TabIndex = 3;
            this.tabPagePartager.Text = "Partager";
            // 
            // lblIpv6
            // 
            this.lblIpv6.AutoSize = true;
            this.lblIpv6.BackColor = System.Drawing.Color.Transparent;
            this.lblIpv6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpv6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIpv6.Location = new System.Drawing.Point(13, 177);
            this.lblIpv6.Name = "lblIpv6";
            this.lblIpv6.Size = new System.Drawing.Size(40, 18);
            this.lblIpv6.TabIndex = 42;
            this.lblIpv6.Text = "IPv6 :";
            // 
            // tblocalip6
            // 
            this.tblocalip6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblocalip6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblocalip6.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblocalip6.Location = new System.Drawing.Point(13, 198);
            this.tblocalip6.Name = "tblocalip6";
            this.tblocalip6.ReadOnly = true;
            this.tblocalip6.Size = new System.Drawing.Size(258, 27);
            this.tblocalip6.TabIndex = 41;
            // 
            // lblIpv4
            // 
            this.lblIpv4.AutoSize = true;
            this.lblIpv4.BackColor = System.Drawing.Color.Transparent;
            this.lblIpv4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpv4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIpv4.Location = new System.Drawing.Point(13, 119);
            this.lblIpv4.Name = "lblIpv4";
            this.lblIpv4.Size = new System.Drawing.Size(41, 18);
            this.lblIpv4.TabIndex = 40;
            this.lblIpv4.Text = "IPv4 :";
            // 
            // lblSssid
            // 
            this.lblSssid.AutoSize = true;
            this.lblSssid.BackColor = System.Drawing.Color.Transparent;
            this.lblSssid.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSssid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSssid.Location = new System.Drawing.Point(13, 67);
            this.lblSssid.Name = "lblSssid";
            this.lblSssid.Size = new System.Drawing.Size(42, 18);
            this.lblSssid.TabIndex = 39;
            this.lblSssid.Text = "Nom :";
            // 
            // chkPartager
            // 
            this.chkPartager.AutoSize = true;
            this.chkPartager.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPartager.Location = new System.Drawing.Point(13, 18);
            this.chkPartager.Name = "chkPartager";
            this.chkPartager.Size = new System.Drawing.Size(167, 20);
            this.chkPartager.TabIndex = 38;
            this.chkPartager.Text = "Cliquer pour activer le partager :";
            this.chkPartager.UseVisualStyleBackColor = true;
            // 
            // tblocalip
            // 
            this.tblocalip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblocalip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblocalip.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblocalip.Location = new System.Drawing.Point(13, 143);
            this.tblocalip.Name = "tblocalip";
            this.tblocalip.ReadOnly = true;
            this.tblocalip.Size = new System.Drawing.Size(258, 27);
            this.tblocalip.TabIndex = 37;
            // 
            // tblocalhost
            // 
            this.tblocalhost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblocalhost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblocalhost.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblocalhost.Location = new System.Drawing.Point(13, 88);
            this.tblocalhost.Name = "tblocalhost";
            this.tblocalhost.ReadOnly = true;
            this.tblocalhost.Size = new System.Drawing.Size(258, 27);
            this.tblocalhost.TabIndex = 36;
            // 
            // cbListNetwork
            // 
            this.cbListNetwork.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListNetwork.FormattingEnabled = true;
            this.cbListNetwork.Location = new System.Drawing.Point(13, 41);
            this.cbListNetwork.Name = "cbListNetwork";
            this.cbListNetwork.Size = new System.Drawing.Size(258, 23);
            this.cbListNetwork.TabIndex = 35;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAbout.Controls.Add(this.picLogo);
            this.tabPageAbout.Controls.Add(this.Label3);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 26);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(283, 341);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "Apropos ?";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = global::Network_Shared.Properties.Resources._1421309735_33657;
            this.picLogo.Location = new System.Drawing.Point(93, 257);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(93, 72);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 23;
            this.picLogo.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label3.Location = new System.Drawing.Point(6, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(274, 254);
            this.Label3.TabIndex = 22;
            this.Label3.Text = resources.GetString("Label3.Text");
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEthiquete
            // 
            this.pnlEthiquete.Controls.Add(this.Label1);
            this.pnlEthiquete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEthiquete.Location = new System.Drawing.Point(0, 0);
            this.pnlEthiquete.Name = "pnlEthiquete";
            this.pnlEthiquete.Size = new System.Drawing.Size(291, 66);
            this.pnlEthiquete.TabIndex = 22;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Teal;
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(267, 43);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Shared Wifi";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmWIFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(291, 453);
            this.Controls.Add(this.pnlEthiquete);
            this.Controls.Add(this.tabControlNet);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWIFI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shared Wifi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWIFI_FormClosing);
            this.Load += new System.EventHandler(this.frmWIFI_Load);
            this.tabControlNet.ResumeLayout(false);
            this.tabPageSet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagePartager.ResumeLayout(false);
            this.tabPagePartager.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlEthiquete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.TabControl tabControlNet;
        private System.Windows.Forms.TabPage tabPageSet;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Panel pnlEthiquete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSetConfig;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox chkVisual;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabPage tabPagePartager;
        private System.Windows.Forms.RadioButton rbBlocInterface;
        private System.Windows.Forms.Label lblIpv6;
        private System.Windows.Forms.TextBox tblocalip6;
        private System.Windows.Forms.Label lblIpv4;
        private System.Windows.Forms.Label lblSssid;
        private System.Windows.Forms.CheckBox chkPartager;
        private System.Windows.Forms.TextBox tblocalip;
        private System.Windows.Forms.TextBox tblocalhost;
        private System.Windows.Forms.ComboBox cbListNetwork;
    }
}

