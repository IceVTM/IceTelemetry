namespace ICE.VTC.TELEMETRY
{
    partial class SetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pluginStatusImage = new System.Windows.Forms.PictureBox();
            this.pluginStatusLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginStatusImage)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(257, 116);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(127, 42);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Install";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pluginStatusImage);
            this.groupBox.Controls.Add(this.pluginStatusLabel);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(8, 8);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(376, 100);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "First Time Setup";
            // 
            // pluginStatusImage
            // 
            this.pluginStatusImage.Image = global::ICE.VTC.TELEMETRY.Properties.Resources.StatusIcon;
            this.pluginStatusImage.InitialImage = null;
            this.pluginStatusImage.Location = new System.Drawing.Point(23, 38);
            this.pluginStatusImage.Name = "pluginStatusImage";
            this.pluginStatusImage.Size = new System.Drawing.Size(40, 40);
            this.pluginStatusImage.TabIndex = 3;
            this.pluginStatusImage.TabStop = false;
            // 
            // pluginStatusLabel
            // 
            this.pluginStatusLabel.AutoSize = true;
            this.pluginStatusLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginStatusLabel.Location = new System.Drawing.Point(78, 48);
            this.pluginStatusLabel.Name = "pluginStatusLabel";
            this.pluginStatusLabel.Size = new System.Drawing.Size(204, 17);
            this.pluginStatusLabel.TabIndex = 2;
            this.pluginStatusLabel.Text = "Install Euro Truck Simulator 2 plugin";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 167);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ice Telemetry";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupForm_FormClosing);
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginStatusImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pluginStatusImage;
        private System.Windows.Forms.Label pluginStatusLabel;
    }
}