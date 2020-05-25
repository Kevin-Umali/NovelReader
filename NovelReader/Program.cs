using System;
using System.Windows.Forms;

namespace NovelReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (new AppSingleInstance(1000)) //1000ms timeout on global lock
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormsLibrary.MainForm());
            }
        }
    }
}
