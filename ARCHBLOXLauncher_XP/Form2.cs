using System;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
namespace ARCHBLOXLauncher_XP
{
    public partial class Form2 : Form
    {
        // setup variables
        public bool Uri_Installed = false;
        public bool IsCompleted = false;
        public bool DontEvenBother = false;
        private static WebClient wc = new WebClient();
        private static ManualResetEvent handle = new ManualResetEvent(true);

        private static long GetDirectorySize(string folderPath)
        {
            // get size of a directory
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length) / 1000000;
        }

        public Form2()
        {
            InitializeComponent();
            // setup other variables
            try {
                wc.DownloadData("https://archblox.com/client/version.txt");
            }
            catch
            {
                MessageBox.Show("Unable to connect to the ARCHBLOX servers!", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Cancelled install.";
                return;
            }
            byte[] raw = wc.DownloadData("https://archblox.com/client/version.txt");
            string webData = Encoding.UTF8.GetString(raw);
            string version_string = webData;
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Archblx\", @"Versions\");
            string clientPath = Path.Combine(folderPath, version_string + @"\");
            string filePath = Path.Combine(clientPath, Path.GetFileName(@"https://archblox.com/client/" + version_string + ".zip"));
            // setup file paths etc
            {
                if (Directory.Exists(folderPath))
                {
                    // since the folder already exists, show size of folder and ask user if they want to delete older versions
                    DialogResult res = MessageBox.Show("Do you want to delete previous installs of ARCHBLOX? Current size of ARCHBLOX folder: " + GetDirectorySize(folderPath) + "MB.", "ARCHBLOX", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        label1.Text = "Removing previous installs...";
                        Directory.Delete(folderPath, true);

                    }
                }
            }
            // setup variables
            wc.DownloadProgressChanged += Client_DownloadProgressChanged;
            wc.DownloadFileCompleted += Client_DownloadFileCompleted;
            progressBar1.Style = ProgressBarStyle.Marquee;
            label1.Text = "Configuring ARCHBLOX...";
            wc.DownloadProgressChanged += Client_DownloadProgressChanged;
            wc.DownloadFileCompleted += Client_DownloadFileCompleted;
            if (Directory.Exists(clientPath))
            {
                // ask user if they want to re-install
                DialogResult res = MessageBox.Show("The latest version of ARCHBLOX is already installed. Do you want to re-install it?", "ARCHBLOX", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    label1.Text = "Removing previous installs...";
                    Directory.Delete(clientPath, true);

                }
                if (res == DialogResult.No)
                {
                    label1.Text = "Cancelled install.";
                    DontEvenBother = true;
                }
            }
            if (DontEvenBother == false)
            {
                // continue with install
                Directory.CreateDirectory(clientPath);
                wc.DownloadFileAsync(new Uri(@"https://archblox.com/client/" + version_string + ".zip"), filePath);
                progressBar1.Style = ProgressBarStyle.Blocks;
                handle.WaitOne();
            }
        }
        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (IsCompleted == false)
            {
                // the download has completed, extract zip, setup URI.
                IsCompleted = true;
                byte[] raw = wc.DownloadData("https://archblox.com/client/version.txt");
                string webData = Encoding.UTF8.GetString(raw);
                string version_string = webData;
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Archblx\", @"Versions\");
                string clientPath = Path.Combine(folderPath, version_string + @"\");
                string filePath = Path.Combine(clientPath, Path.GetFileName(@"https://archblox.com/client/" + version_string + ".zip"));
                // ZipFile(filePath, clientPath);
                File.Delete(filePath);
                label1.Text = "Installing URi...";
                try
                {
                    ARCHBLOXProtocol.ARCHBLOXURIProtocol.Register();
                    Uri_Installed = true;
                }
                catch { Uri_Installed = false; }
                if (Uri_Installed == true)
                {
                    label1.Text = "ARCHBLOX has been installed!";
                }
                else
                {
                    label1.Text = "ARCHBLOX installed without URI.";
                }

            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // update the progress bar
            progressBar1.Minimum = 0;
            double receive = double.Parse(e.BytesReceived.ToString());
            double total = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = receive / total * 100;
            label1.Text = "Installing ARCHBLOX... (" + Math.Truncate(percentage).ToString() + "% Completed)";
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
    }
}
