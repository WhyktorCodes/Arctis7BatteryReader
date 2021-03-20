using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arctis_7
{
    public partial class About : Form
    {
        public About(string version)
        {
            InitializeComponent();
            labelVersion.Text = $"Current Version: {version}";
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelcrazyklatsch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/crazyklatsch");
        }

        private void linkLabelMightyDevices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/MightyDevices");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/samwendel");
        }
    }
}
