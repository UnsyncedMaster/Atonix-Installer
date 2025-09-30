using Atonix_Installer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix_Installer
{
    public partial class FinishWindow : Form
    {
        public FinishWindow()
        {
            InitializeComponent();
        }

        private void StartAfterFinishedCb_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.StartAfterFinished = StartAfterFinishedCb.Checked;
            Settings.Default.Save();
        }

        private void JoinDiscordCb_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.JoinDiscord = JoinDiscordCb.Checked;
            Settings.Default.Save();
        }
    }
}
