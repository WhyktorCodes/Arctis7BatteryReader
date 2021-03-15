using Arctis_7.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Windows.Forms;

namespace Arctis_7
{
    public partial class Form1 : Form
    {
        private Arctis7Reader reader;

        private string batteryPercentage;
        private bool muted = false;
        public Form1()
        {
            InitializeComponent();
            reader = new Arctis7Reader();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SetIcon(byte percentage)
        {
            ResourceManager rm = Resources.ResourceManager;
            notifyIconArtics7.Icon = GenerateIcon(percentage);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte batCharge = 0;
            if (reader.ReadBattery(out batCharge) && batCharge != 0)
            {
                reader.ReadBattery(out batCharge);
                batteryPercentage = batCharge.ToString();
                reader.ReadMute(out byte muteState);
                muted = (muteState == 1 ? true : false);
                SetIcon(batCharge);
                SetBalloonText(batCharge);
            }
            else
            {
                SetNotFoundIcon();
                SetNotFoundBalloonText();
            }
        }

        private void SetNotFoundBalloonText()
        {
            notifyIconArtics7.Text = "No Arctis 7 Device Found!";
        }

        private void SetNotFoundIcon()
        {
            Bitmap flag = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(flag);

            RectangleF rectf = new RectangleF(5, 0, 60, 60);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, 32, 32);
            g.DrawString("x", new Font("Tahoma", 18, FontStyle.Bold), new SolidBrush(Color.Black), rectf);

            g.Flush();

            notifyIconArtics7.Icon = Icon.FromHandle(flag.GetHicon());
        }

        private void SetBalloonText(byte bt)
        {
            string mutedStr = (muted ? "Yes \n" : "No \n");
            string battPerc = (bt >= 100 ? "99" : bt.ToString());

            notifyIconArtics7.Text = "Arctis 7 Info \n" +
                "Muted: " + mutedStr +
                "Battery: " + battPerc + "%";
        }

        private Icon GenerateIcon(byte perc)
        {
            if (perc >= 100)
                perc = 99;

            Bitmap flag = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(flag);
            Color color = Color.White;

            if (perc <= 24)
                color = Properties.Settings.Default.lowColor;
            else if (perc >= 25 && perc <= 49)
                color = Properties.Settings.Default.mediumLowColor;
            else if (perc >= 50 && perc <= 74)
                color = Properties.Settings.Default.mediumHighColor;
            else if (perc >= 75)
                color = Properties.Settings.Default.highColor;

            if (Properties.Settings.Default.UseBackground)
            {
                g.FillRectangle(new SolidBrush(color), 0, 0, 32, 32);
            }

            RectangleF rectf = new RectangleF(-2, 0, 60, 60);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            if (Properties.Settings.Default.ShowPercentage)
            {
                g.DrawString(perc.ToString(), new Font("Tahoma", 18, FontStyle.Bold), new SolidBrush(Properties.Settings.Default.PercentageColor), rectf);
            }

            g.Flush();

            return Icon.FromHandle(flag.GetHicon());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sett = new Settings();
            sett.Show();
        }
    }
}
