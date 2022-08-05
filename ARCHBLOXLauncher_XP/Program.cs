using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ARCHBLOXLauncher_XP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                foreach (string s in args)
                {
                    ARCHBLOXProtocol.SharedVariables.Arguments = s;
                }
            }
            Application.Run(new Form1());
        }
    }
}
