namespace Arctis_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMedHigh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMedLow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLow = new System.Windows.Forms.TextBox();
            this.boxColorHigh = new System.Windows.Forms.PictureBox();
            this.boxColorMedHigh = new System.Windows.Forms.PictureBox();
            this.boxColorMedLow = new System.Windows.Forms.PictureBox();
            this.boxColorLow = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUseBG = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPerc = new System.Windows.Forms.TextBox();
            this.boxColorPerc = new System.Windows.Forms.PictureBox();
            this.checkBoxUsePerc = new System.Windows.Forms.CheckBox();
            this.checkBoxRunOnStartup = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorMedHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorMedLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorLow)).BeginInit();
            this.groupBoxFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorPerc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "V.0.0.2";
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.label9);
            this.groupBoxColors.Controls.Add(this.textBoxHigh);
            this.groupBoxColors.Controls.Add(this.label8);
            this.groupBoxColors.Controls.Add(this.textBoxMedHigh);
            this.groupBoxColors.Controls.Add(this.label7);
            this.groupBoxColors.Controls.Add(this.textBoxMedLow);
            this.groupBoxColors.Controls.Add(this.label6);
            this.groupBoxColors.Controls.Add(this.textBoxLow);
            this.groupBoxColors.Controls.Add(this.boxColorHigh);
            this.groupBoxColors.Controls.Add(this.boxColorMedHigh);
            this.groupBoxColors.Controls.Add(this.boxColorMedLow);
            this.groupBoxColors.Controls.Add(this.boxColorLow);
            this.groupBoxColors.Controls.Add(this.label5);
            this.groupBoxColors.Controls.Add(this.label4);
            this.groupBoxColors.Controls.Add(this.label3);
            this.groupBoxColors.Controls.Add(this.label2);
            this.groupBoxColors.Location = new System.Drawing.Point(213, 13);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(183, 131);
            this.groupBoxColors.TabIndex = 1;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Background Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(94, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "#";
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(110, 95);
            this.textBoxHigh.MaxLength = 6;
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(62, 20);
            this.textBoxHigh.TabIndex = 18;
            this.textBoxHigh.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(94, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "#";
            // 
            // textBoxMedHigh
            // 
            this.textBoxMedHigh.Location = new System.Drawing.Point(110, 71);
            this.textBoxMedHigh.MaxLength = 6;
            this.textBoxMedHigh.Name = "textBoxMedHigh";
            this.textBoxMedHigh.Size = new System.Drawing.Size(62, 20);
            this.textBoxMedHigh.TabIndex = 16;
            this.textBoxMedHigh.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(94, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "#";
            // 
            // textBoxMedLow
            // 
            this.textBoxMedLow.Location = new System.Drawing.Point(110, 47);
            this.textBoxMedLow.MaxLength = 6;
            this.textBoxMedLow.Name = "textBoxMedLow";
            this.textBoxMedLow.Size = new System.Drawing.Size(62, 20);
            this.textBoxMedLow.TabIndex = 14;
            this.textBoxMedLow.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(94, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "#";
            // 
            // textBoxLow
            // 
            this.textBoxLow.Location = new System.Drawing.Point(110, 23);
            this.textBoxLow.MaxLength = 6;
            this.textBoxLow.Name = "textBoxLow";
            this.textBoxLow.Size = new System.Drawing.Size(62, 20);
            this.textBoxLow.TabIndex = 12;
            this.textBoxLow.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // boxColorHigh
            // 
            this.boxColorHigh.Location = new System.Drawing.Point(68, 95);
            this.boxColorHigh.Name = "boxColorHigh";
            this.boxColorHigh.Size = new System.Drawing.Size(20, 20);
            this.boxColorHigh.TabIndex = 11;
            this.boxColorHigh.TabStop = false;
            // 
            // boxColorMedHigh
            // 
            this.boxColorMedHigh.Location = new System.Drawing.Point(68, 71);
            this.boxColorMedHigh.Name = "boxColorMedHigh";
            this.boxColorMedHigh.Size = new System.Drawing.Size(20, 20);
            this.boxColorMedHigh.TabIndex = 10;
            this.boxColorMedHigh.TabStop = false;
            // 
            // boxColorMedLow
            // 
            this.boxColorMedLow.Location = new System.Drawing.Point(68, 47);
            this.boxColorMedLow.Name = "boxColorMedLow";
            this.boxColorMedLow.Size = new System.Drawing.Size(20, 20);
            this.boxColorMedLow.TabIndex = 9;
            this.boxColorMedLow.TabStop = false;
            // 
            // boxColorLow
            // 
            this.boxColorLow.Location = new System.Drawing.Point(68, 23);
            this.boxColorLow.Name = "boxColorLow";
            this.boxColorLow.Size = new System.Drawing.Size(20, 20);
            this.boxColorLow.TabIndex = 8;
            this.boxColorLow.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "% 75-100:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "% 50-74:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "% 25-49:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "% 0-24:";
            // 
            // checkBoxUseBG
            // 
            this.checkBoxUseBG.AutoSize = true;
            this.checkBoxUseBG.Location = new System.Drawing.Point(13, 13);
            this.checkBoxUseBG.Name = "checkBoxUseBG";
            this.checkBoxUseBG.Size = new System.Drawing.Size(106, 17);
            this.checkBoxUseBG.TabIndex = 20;
            this.checkBoxUseBG.Text = "Use Background";
            this.checkBoxUseBG.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(214, 150);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(132, 150);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.label10);
            this.groupBoxFont.Controls.Add(this.label11);
            this.groupBoxFont.Controls.Add(this.textBoxPerc);
            this.groupBoxFont.Controls.Add(this.boxColorPerc);
            this.groupBoxFont.Location = new System.Drawing.Point(13, 79);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(194, 65);
            this.groupBoxFont.TabIndex = 4;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "Percentage Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(93, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Color: ";
            // 
            // textBoxPerc
            // 
            this.textBoxPerc.Location = new System.Drawing.Point(109, 31);
            this.textBoxPerc.MaxLength = 6;
            this.textBoxPerc.Name = "textBoxPerc";
            this.textBoxPerc.Size = new System.Drawing.Size(62, 20);
            this.textBoxPerc.TabIndex = 23;
            this.textBoxPerc.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // boxColorPerc
            // 
            this.boxColorPerc.Location = new System.Drawing.Point(67, 31);
            this.boxColorPerc.Name = "boxColorPerc";
            this.boxColorPerc.Size = new System.Drawing.Size(20, 20);
            this.boxColorPerc.TabIndex = 22;
            this.boxColorPerc.TabStop = false;
            // 
            // checkBoxUsePerc
            // 
            this.checkBoxUsePerc.AutoSize = true;
            this.checkBoxUsePerc.Location = new System.Drawing.Point(13, 36);
            this.checkBoxUsePerc.Name = "checkBoxUsePerc";
            this.checkBoxUsePerc.Size = new System.Drawing.Size(135, 17);
            this.checkBoxUsePerc.TabIndex = 21;
            this.checkBoxUsePerc.Text = "Show Percentage Text";
            this.checkBoxUsePerc.UseVisualStyleBackColor = true;
            // 
            // checkBoxRunOnStartup
            // 
            this.checkBoxRunOnStartup.AutoSize = true;
            this.checkBoxRunOnStartup.Location = new System.Drawing.Point(13, 59);
            this.checkBoxRunOnStartup.Name = "checkBoxRunOnStartup";
            this.checkBoxRunOnStartup.Size = new System.Drawing.Size(98, 17);
            this.checkBoxRunOnStartup.TabIndex = 22;
            this.checkBoxRunOnStartup.Text = "Run on Startup";
            this.checkBoxRunOnStartup.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "By: Virre1337";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 182);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBoxRunOnStartup);
            this.Controls.Add(this.checkBoxUsePerc);
            this.Controls.Add(this.checkBoxUseBG);
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorMedHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorMedLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorLow)).EndInit();
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxColorPerc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxHigh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMedHigh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMedLow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLow;
        private System.Windows.Forms.PictureBox boxColorHigh;
        private System.Windows.Forms.PictureBox boxColorMedHigh;
        private System.Windows.Forms.PictureBox boxColorMedLow;
        private System.Windows.Forms.PictureBox boxColorLow;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.CheckBox checkBoxUseBG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPerc;
        private System.Windows.Forms.PictureBox boxColorPerc;
        private System.Windows.Forms.CheckBox checkBoxUsePerc;
        private System.Windows.Forms.CheckBox checkBoxRunOnStartup;
        private System.Windows.Forms.Label label12;
    }
}