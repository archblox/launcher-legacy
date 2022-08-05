using System;
using System.IO;
using System.Text;
using System.Net;
namespace ARCHBLOXLauncher_XP
{
    public static class Extensions
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern uint GetModuleFileName(IntPtr hModule, System.Text.StringBuilder lpFilename, int nSize);
        public static string GetExecutablePath()
        {
            return System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        }

        public static void UnZip(string zipFile, string folderPath)
        {
            if (!File.Exists(zipFile))
                throw new FileNotFoundException();

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            Shell32.Shell objShell = new Shell32.Shell();
            Shell32.Folder destinationFolder = objShell.NameSpace(folderPath);
            Shell32.Folder sourceFile = objShell.NameSpace(zipFile);

            foreach (var file in sourceFile.Items())
            {
                destinationFolder.CopyHere(file, 4 | 16);
            }
        }

        public static string GetVersionString()
        {
            WebClient wc = new WebClient();
            try { wc.DownloadData("http://archblox.com/client/version.txt"); }
            catch
            {
                return ("nil");
            }
            byte[] raw = wc.DownloadData("http://archblox.com/client/version.txt");
            string webData = Encoding.UTF8.GetString(raw);
            return(webData);
        }
    }
}