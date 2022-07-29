using System;

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
    }
}