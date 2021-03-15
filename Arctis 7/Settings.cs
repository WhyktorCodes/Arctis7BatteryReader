using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arctis_7
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var lowColor = Properties.Settings.Default.lowColor;
            var mediumLowColor = Properties.Settings.Default.mediumLowColor;
            var mediumHighColor = Properties.Settings.Default.mediumHighColor;
            var highColor = Properties.Settings.Default.highColor;
            var percColor = Properties.Settings.Default.PercentageColor;

            checkBoxUseBG.Checked = Properties.Settings.Default.UseBackground;
            checkBoxUsePerc.Checked = Properties.Settings.Default.ShowPercentage;
            checkBoxRunOnStartup.Checked = Properties.Settings.Default.RunOnStartup;

            boxColorLow.BackColor = lowColor;
            boxColorMedLow.BackColor = mediumLowColor;
            boxColorMedHigh.BackColor = mediumHighColor;
            boxColorHigh.BackColor = highColor;
            boxColorPerc.BackColor = percColor;

            textBoxLow.Text = lowColor.R.ToString("X2") + lowColor.G.ToString("X2") + lowColor.B.ToString("X2");
            textBoxMedLow.Text = mediumLowColor.R.ToString("X2") + mediumLowColor.G.ToString("X2") + mediumLowColor.B.ToString("X2");
            textBoxMedHigh.Text = mediumHighColor.R.ToString("X2") + mediumHighColor.G.ToString("X2") + mediumHighColor.B.ToString("X2");
            textBoxHigh.Text = highColor.R.ToString("X2") + highColor.G.ToString("X2") + highColor.B.ToString("X2");
            textBoxPerc.Text = percColor.R.ToString("X2") + percColor.G.ToString("X2") + percColor.B.ToString("X2");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lowColor = boxColorLow.BackColor;
            Properties.Settings.Default.mediumLowColor = boxColorMedLow.BackColor;
            Properties.Settings.Default.mediumHighColor = boxColorMedHigh.BackColor;
            Properties.Settings.Default.highColor = boxColorHigh.BackColor;
            Properties.Settings.Default.PercentageColor = boxColorPerc.BackColor;

            Properties.Settings.Default.UseBackground = checkBoxUseBG.Checked;
            Properties.Settings.Default.ShowPercentage = checkBoxUsePerc.Checked;

            if(checkBoxRunOnStartup.Checked && !Properties.Settings.Default.RunOnStartup)
            {
                AddToStartup();
                Properties.Settings.Default.RunOnStartup = true;
            }
            else if (!checkBoxRunOnStartup.Checked && Properties.Settings.Default.RunOnStartup)
            {
                RemoveFromStartup();
                Properties.Settings.Default.RunOnStartup = false;
            }
               

            Properties.Settings.Default.Save();
        }

        private void RemoveFromStartup()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.DeleteValue("Arctis 7 BatteryReader", false);
        }

        private void AddToStartup()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Arctis 7 BatteryReader", Application.ExecutablePath.ToString());
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lowColor = Color.FromArgb(230, 57, 70);
            Properties.Settings.Default.mediumLowColor = Color.FromArgb(244, 162, 97);
            Properties.Settings.Default.mediumHighColor = Color.FromArgb(233, 196, 106);
            Properties.Settings.Default.highColor = Color.FromArgb(42, 157, 143);
            Properties.Settings.Default.UseBackground = true;
            Properties.Settings.Default.ShowPercentage = true;

            Properties.Settings.Default.Save();

            checkBoxUseBG.Checked = Properties.Settings.Default.UseBackground;
            Properties.Settings.Default.ShowPercentage = checkBoxUsePerc.Checked;
            boxColorLow.BackColor = Properties.Settings.Default.lowColor;
            boxColorMedLow.BackColor = Properties.Settings.Default.mediumLowColor;
            boxColorMedHigh.BackColor = Properties.Settings.Default.mediumHighColor;
            boxColorHigh.BackColor = Properties.Settings.Default.highColor;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (IsHexColor(textBox.Text))
            {
                switch (textBox.Name)
                {
                    case "textBoxLow":
                        boxColorLow.BackColor = ColorTranslator.FromHtml("#" + textBox.Text);
                        break;
                    case "textBoxMedLow":
                        textBoxMedLow.BackColor = ColorTranslator.FromHtml("#" + textBox.Text);
                        break;
                    case "textBoxMedHigh":
                        boxColorMedHigh.BackColor = ColorTranslator.FromHtml("#" + textBox.Text);
                        break;
                    case "textBoxHigh":
                        boxColorHigh.BackColor = ColorTranslator.FromHtml("#" + textBox.Text);
                        break;
                    case "textBoxPerc":
                        boxColorPerc.BackColor = ColorTranslator.FromHtml("#" + textBox.Text);
                        break;
                }
            }
            else
            {
                MessageBox.Show("HEX Value isn't valid");
            }
        }

        public bool IsHexColor(string hexText)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(hexText, @"(?:[0-9a-fA-F]{3}){1,2}$");
        }
    }
}
