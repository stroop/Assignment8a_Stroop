using System;
using System.Windows.Forms;

/*
Jacob Stroop
CIS353 - Assignment 8a
2/7/16
*/

namespace Assignment8a_Stroop
{
    static class Assignment8a_Stroop
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
