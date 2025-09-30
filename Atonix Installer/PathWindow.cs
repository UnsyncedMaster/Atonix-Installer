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
    public partial class PathWindow : Form
    {
        public PathWindow()
        {
            InitializeComponent();
        }

        public static string AtonixPath = Environment.CurrentDirectory + "\\Atonix";

        private void Path_Load(object sender, EventArgs e)
        {
            PathTb.Text = AtonixPath;
        }

        private void DefaultPathBtn_Click(object sender, EventArgs e)
        {
            AtonixPath = Environment.CurrentDirectory + "\\Atonix";
            PathTb.Text = AtonixPath;
        }

        private void PathSelectBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.UserProfile;
                folderBrowserDialog.ShowDialog();
                string selectedPath = folderBrowserDialog.SelectedPath;
                PathTb.Text = selectedPath;
                AtonixPath = selectedPath;
            }
        }
    }
}
