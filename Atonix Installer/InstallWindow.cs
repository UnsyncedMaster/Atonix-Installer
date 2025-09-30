using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Atonix_Installer
{
    public partial class InstallWindow : Form
    {
        FinishWindow finish = new FinishWindow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public InstallWindow()
        {
            InitializeComponent();
        }

        async void Install()
        {
            // Check For Internet
            bool Internet = NetworkInterface.GetIsNetworkAvailable();
            if (Internet == false)
            {
                MessageBox.Show("Atonix Installer requires an internet connection, Press OK To Close.", "No Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else // Internet Connection Is Available 
            {
                string link = "https://github.com/Atonix-Techworks-INC/Atonix/raw/main/Atonix.zip";
                string path = PathWindow.AtonixPath;

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(link, "./Atonix.zip");

                    wc.Dispose();
                }

                await Task.Delay(500);

                try
                {
                    if (Directory.Exists(path + "\\Atonix"))
                    {
                        Directory.Delete(path + "\\Atonix", true);
                    }
                }
                catch
                {
                    MessageBox.Show("Atonix is open in the background and cannot redownload, please close it and try again", "Close Atonix To Continue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                try
                {
                    ZipFile.ExtractToDirectory("./Atonix.zip", path);
                }
                catch
                {
                    MessageBox.Show("The patch you selected is invalid, please check your path and try again", "Close Atonix To Continue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                File.Delete("./Atonix.zip");
            }
        }

        private async void InstallWindow_Load(object sender, EventArgs e)
        {
            Install();
            await Task.Delay(4000);
            Main.instance.panel.Controls.Clear();
            Main.instance.panel.Controls.Add(finish);
            finish.Show();
        }
    }
}
