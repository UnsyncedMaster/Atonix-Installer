using Atonix_Installer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix_Installer
{
    public partial class Main : Form
    {
        PathWindow path = new PathWindow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        InstallWindow install = new InstallWindow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FinishWindow finish = new FinishWindow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        public static Main instance;
        public Panel panel;

        void SwitchWindow(string Window)
        {
            if (Window == "Path")
            {
                install.Hide();
                finish.Hide();
                WindowPnl.Controls.Clear();
                WindowPnl.Controls.Add(path);
                path.Show();
            }
            if (Window == "Install")
            {
                path.Hide();
                finish.Hide();
                WindowPnl.Controls.Clear();
                WindowPnl.Controls.Add(install);
                install.Show();
            }
            else if (Window == "Finish")
            {
                path.Hide();
                install.Hide();
                WindowPnl.Controls.Clear();
                WindowPnl.Controls.Add(finish);
                finish.Show();
            }
        }

        public Main()
        {
            InitializeComponent();
            panel = WindowPnl;
            instance = this;
            SwitchWindow("Path");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void NextBtn_Click(object sender, EventArgs e)
        {
            if (WindowPnl.Contains(path))
            {
                path.Dispose();
                SwitchWindow("Install");
            }
            else if (WindowPnl.Contains(install))
            {

            }
            else
            {
                if (Settings.Default.StartAfterFinished == true)
                {
                    Process.Start(PathWindow.AtonixPath + "\\Atonix");
                }

                if (Settings.Default.JoinDiscord == true)
                {
                    Process.Start("https://discord.gg/ksCRKSCeJb");
                }

                await Task.Delay(2000);
                Environment.Exit(0);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                label1.Text = $"Atonix Version: {wc.DownloadString("https://pastebin.com/raw/YtREaMrW")}";
                wc.Dispose();
            }
        }
    }
}
