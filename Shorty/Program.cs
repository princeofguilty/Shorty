using System;
using System.Windows.Forms;

namespace Shorty
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Control.CheckForIllegalCrossThreadCalls = false;
            Application.Run(new Shorty());
        }
    }
}
