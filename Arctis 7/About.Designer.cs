namespace Arctis_7
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelcrazyklatsch = new System.Windows.Forms.LinkLabel();
            this.linkLabelMightyDevices = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Made by Viheiser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Couldn\'t have made this if it wasn\'t for                       and\r\n";
            // 
            // linkLabelcrazyklatsch
            // 
            this.linkLabelcrazyklatsch.AutoSize = true;
            this.linkLabelcrazyklatsch.Location = new System.Drawing.Point(201, 29);
            this.linkLabelcrazyklatsch.Name = "linkLabelcrazyklatsch";
            this.linkLabelcrazyklatsch.Size = new System.Drawing.Size(66, 13);
            this.linkLabelcrazyklatsch.TabIndex = 2;
            this.linkLabelcrazyklatsch.TabStop = true;
            this.linkLabelcrazyklatsch.Text = "crazyklatsch";
            this.linkLabelcrazyklatsch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelcrazyklatsch_LinkClicked);
            // 
            // linkLabelMightyDevices
            // 
            this.linkLabelMightyDevices.AutoSize = true;
            this.linkLabelMightyDevices.Location = new System.Drawing.Point(287, 29);
            this.linkLabelMightyDevices.Name = "linkLabelMightyDevices";
            this.linkLabelMightyDevices.Size = new System.Drawing.Size(77, 13);
            this.linkLabelMightyDevices.TabIndex = 3;
            this.linkLabelMightyDevices.TabStop = true;
            this.linkLabelMightyDevices.Text = "MightyDevices";
            this.linkLabelMightyDevices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMightyDevices_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SHOUT OUT TO THEIR FAMILIES!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Also Thanks                       for testing this and reporting bugs!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(116, 43);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SamWendel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(1, 76);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(385, 19);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "Current Version: ";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 103);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelMightyDevices);
            this.Controls.Add(this.linkLabelcrazyklatsch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About Arctis7BatteryReader";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelcrazyklatsch;
        private System.Windows.Forms.LinkLabel linkLabelMightyDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelVersion;
    }
}