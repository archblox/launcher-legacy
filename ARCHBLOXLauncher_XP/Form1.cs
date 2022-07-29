using System;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace ARCHBLOXLauncher_XP
{
    public partial class Form1 : Form
    {
        // variables
        bool rbxl = false;
        bool exitafterarg = false;
        private static WebClient wc = new WebClient();
        static byte[] raw = wc.DownloadData("http://archblox.com/client/version.txt");
        static string webData = Encoding.UTF8.GetString(raw);
        static string version_string = webData;
        static string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Archblx\", @"Versions\");
        static string clientPath = Path.Combine(folderPath, version_string + @"\");
        static string filePath = Path.Combine(clientPath, "ArchbloxPlayerBeta.exe");
        // animations
        public Form1()
        {
            InitializeComponent();
            ARCHBLOXProtocol.ARCHBLOXURIProtocol.Register();
            var lastword = "";
            var info1 = "";
            var info2 = "";
            string[] args = ARCHBLOXProtocol.SharedVariables.Arguments.Split('/');
            // check to see if uri/arguments were used
            foreach (var word in args)
            {
                if (lastword == "host")
                {
                    exitafterarg = true;
                    lastword = "stop";
                    string[] info = word.Split('|');
                    foreach (var word2 in info)
                    {
                        if (info1 == "")
                        {
                            info1 = word2;
                        }
                        else
                        {
                            info2 = word2;
                        }
                    }
                    if (info1 == "" || info2 == "")
                    {
                        MessageBox.Show("Paramaters are invalid. Please try again. (ID: 500)", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                    var pProcess = new Process();
                    pProcess.StartInfo.FileName = filePath;
                    pProcess.StartInfo.Arguments = "-a \"http://www.morblox.us/\" -j \"http://www.morblox.us/game/gameserver.php?port=" + info1 + "&rbxl=" + info2 + "\" -t \"1\"";
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    pProcess.StartInfo.CreateNoWindow = false;
                    pProcess.Start();
                    MessageBox.Show("Starting game server on port " + info1 + " using " + info2, "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (lastword == "join")
                {
                    exitafterarg = true;
                    lastword = "stop";
                    string[] info = word.Split('|');
                    foreach (var word2 in info)
                    {
                        if (info1 == "")
                        {
                            info1 = word2;
                        }
                        else
                        {
                            info2 = word2;
                        }
                    }
                    if (info1 == "" || info2 == "")
                    {
                        MessageBox.Show("Paramaters are invalid. Please try again. (ID: 500)", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                    var pProcess = new Process();
                    pProcess.StartInfo.FileName = filePath;
                    pProcess.StartInfo.Arguments = "-a \"http://www.morblox.us/\" -j \"http://www.morblox.us/game/join.ashx?port=" + info1 + "&ip=" + info2 + "\" -t \"1\"";
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    pProcess.StartInfo.CreateNoWindow = false;
                    pProcess.Start();
                    MessageBox.Show("Joining " + info2 + ":" + info1, "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (word == "install")
                {
                    ARCHBLOXLauncher_XP.Form2 form2 = new ARCHBLOXLauncher_XP.Form2();
                    form2.Show();
                }
                if (word == "") { }
                else
                {
                    lastword = word;
                }
            }
            if (exitafterarg == true)
            {
                // close program
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hosting
            string phrase = textBox2.Text;
            string[] words = phrase.Split('.');
            string sWord = "";
            foreach (var word in words)
            {
                sWord = word.ToLower();
                if (sWord == "rbxl")
                {
                    rbxl = true;
                }
                else
                {
                    rbxl = false;
                }
            }
            if (!System.IO.File.Exists(filePath))
            {
                DialogResult res = MessageBox.Show("You need to install the latest version of ARCHBLOX to host. Would you like to install it?", "ARCHBLOX", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    ARCHBLOXLauncher_XP.Form2 form2 = new ARCHBLOXLauncher_XP.Form2();
                    form2.Show();
                }
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill in all of the text fields.", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbxl == false)
            {
                MessageBox.Show("Please use a valid .RBXL! ." + sWord + " is not a supported file format.", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var pProcess = new Process();
                pProcess.StartInfo.FileName = filePath;
                pProcess.StartInfo.Arguments = "-a \"http://www.morblox.us/\" -j \"http://www.morblox.us/game/gameserver.php?port=" + textBox1.Text + "&rbxl=" + textBox2.Text + "\" -t \"1\"";
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                pProcess.StartInfo.CreateNoWindow = false;
                pProcess.Start();
                pProcess.EnableRaisingEvents = true;
                var random = new Random();
                MessageBox.Show("Starting game server on port " + textBox1.Text + " using " + textBox2.Text, "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // joining
            if (!System.IO.File.Exists(filePath))
            {
                DialogResult res = MessageBox.Show("You need to install the latest version of ARCHBLOX to join " + serverip.Text + ":" + serverport.Text + ". Would you like to install it?", "ARCHBLOX", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    ARCHBLOXLauncher_XP.Form2 form2 = new ARCHBLOXLauncher_XP.Form2();
                    form2.Show();
                }
            }
            else if (serverip.Text == "" || serverport.Text == "")
            {
                MessageBox.Show("Please fill in all of the text fields.", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var pProcess = new Process();
                pProcess.StartInfo.FileName = filePath;
                pProcess.StartInfo.Arguments = "-a \"http://www.morblox.us/\" -j \"http://www.morblox.us/game/join.ashx?port=" + serverport.Text + "&ip=" + serverip.Text + "\" -t \"1\"";
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                pProcess.StartInfo.CreateNoWindow = false;
                pProcess.Start();
                pProcess.EnableRaisingEvents = true;
                MessageBox.Show("Joining " + serverip.Text + ":" + serverport.Text, "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ask user to open dialog
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Choose a RBXL...";
            dialog.AddExtension = true;
            dialog.Filter = "Place File (*.rbxl)| *.rbxl";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                // check if it is a rbxl
                string word = Path.GetExtension(dialog.FileName);
                word = word.ToLower();
                if (word == ".rbxl")
                {
                    // Thanks to ROBLOX LEGACY PLACE CONVERTER by BakonBot for the binary rbxl format detection.
                    string[] file = System.IO.File.ReadAllLines(dialog.FileName);
                    foreach (var line in file)
                    {
                        if (line.Contains("<roblox!"))
                        {
                            // is binary/unsupported format
                            MessageBox.Show("Sorry, binary .RBXL files are not supported. Please convert the RBXL into XML format using a converter, then try again.", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            // it's supported, yay!
                            string destFile = Path.Combine(clientPath, @"Content\", Path.GetFileName(dialog.FileName));
                            System.IO.File.Copy(dialog.FileName, destFile, true);
                            textBox2.Text = Path.GetFileName(dialog.FileName);
                            return;
                        }
                    }
                }
                else if (word == ".rbxlx")
                {
                    // rbxlx, cringe!
                    MessageBox.Show(".RBXLX file formats are not supported, are you sure you converted the .RBXL correctly?", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // wtf this isn't even a place
                    MessageBox.Show(word.ToUpper() + " is not a supported file type!", "ARCHBLOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void JoinBTN_Click(object sender, EventArgs e)
        {
            JoinBTN.Visible = false;
            HostBTN.Visible = false;
            UpdateBTN.Visible = false;
            JoinBox.Visible = true;
            HostBox.Visible = false;
            BackBTN.Visible = true;
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            ARCHBLOXLauncher_XP.Form2 form2 = new ARCHBLOXLauncher_XP.Form2();
            form2.Show();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            JoinBTN.Visible = true;
            HostBTN.Visible = true;
            UpdateBTN.Visible = true;
            JoinBox.Visible = false;
            HostBox.Visible = false;
            BackBTN.Visible = false;
        }

        private void HostBTN_Click(object sender, EventArgs e)
        {
            JoinBTN.Visible = false;
            HostBTN.Visible = false;
            UpdateBTN.Visible = false;
            JoinBox.Visible = false;
            HostBox.Visible = true;
            BackBTN.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}