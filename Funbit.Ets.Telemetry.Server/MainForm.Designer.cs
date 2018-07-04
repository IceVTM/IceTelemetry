namespace ICE.VTC.TELEMETRY
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.driverTokenTextBox = new System.Windows.Forms.TextBox();
            this.interfacesDropDown = new System.Windows.Forms.ComboBox();
            this.networkInterfaceTitleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTitleLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.broadcastTimer = new System.Windows.Forms.Timer(this.components);
            this.serverToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipTitle = "Ice Telemetry";
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Ice Telemetry";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // statusUpdateTimer
            // 
            this.statusUpdateTimer.Interval = 1000;
            this.statusUpdateTimer.Tick += new System.EventHandler(this.statusUpdateTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.driverTokenTextBox);
            this.groupBox1.Controls.Add(this.interfacesDropDown);
            this.groupBox1.Controls.Add(this.networkInterfaceTitleLabel);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.statusTitleLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 176);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tracker Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Driver Token:";
            // 
            // driverTokenTextBox
            // 
            this.driverTokenTextBox.Location = new System.Drawing.Point(137, 94);
            this.driverTokenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driverTokenTextBox.Name = "driverTokenTextBox";
            this.driverTokenTextBox.Size = new System.Drawing.Size(371, 25);
            this.driverTokenTextBox.TabIndex = 21;
            // 
            // interfacesDropDown
            // 
            this.interfacesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interfacesDropDown.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interfacesDropDown.FormattingEnabled = true;
            this.interfacesDropDown.Location = new System.Drawing.Point(139, 51);
            this.interfacesDropDown.Name = "interfacesDropDown";
            this.interfacesDropDown.Size = new System.Drawing.Size(369, 25);
            this.interfacesDropDown.TabIndex = 20;
            this.interfacesDropDown.TabStop = false;
            this.interfacesDropDown.SelectedIndexChanged += new System.EventHandler(this.interfaceDropDown_SelectedIndexChanged);
            // 
            // networkInterfaceTitleLabel
            // 
            this.networkInterfaceTitleLabel.AutoSize = true;
            this.networkInterfaceTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkInterfaceTitleLabel.Location = new System.Drawing.Point(23, 53);
            this.networkInterfaceTitleLabel.Name = "networkInterfaceTitleLabel";
            this.networkInterfaceTitleLabel.Size = new System.Drawing.Size(114, 17);
            this.networkInterfaceTitleLabel.TabIndex = 19;
            this.networkInterfaceTitleLabel.Text = "Network Interface:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusLabel.Location = new System.Drawing.Point(139, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 17);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Checking...";
            // 
            // statusTitleLabel
            // 
            this.statusTitleLabel.AutoSize = true;
            this.statusTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTitleLabel.Location = new System.Drawing.Point(88, 20);
            this.statusTitleLabel.Name = "statusTitleLabel";
            this.statusTitleLabel.Size = new System.Drawing.Size(46, 17);
            this.statusTitleLabel.TabIndex = 11;
            this.statusTitleLabel.Text = "Status:";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 6000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 50;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // broadcastTimer
            // 
            this.broadcastTimer.Interval = 1000;
            this.broadcastTimer.Tick += new System.EventHandler(this.broadcastTimer_Tick);
            // 
            // serverToolStripMenu
            // 
            this.serverToolStripMenu.Name = "serverToolStripMenu";
            this.serverToolStripMenu.Size = new System.Drawing.Size(32, 19);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // helpToolStripMenu
            // 
            this.helpToolStripMenu.Name = "helpToolStripMenu";
            this.helpToolStripMenu.Size = new System.Drawing.Size(32, 19);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "You can obtain a driver token from here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(265, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "http://62.31.252.107/";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 192);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ice Telemetry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer statusUpdateTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusTitleLabel;
        private System.Windows.Forms.ComboBox interfacesDropDown;
        private System.Windows.Forms.Label networkInterfaceTitleLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer broadcastTimer;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox driverTokenTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

