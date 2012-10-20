using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Skype_Calling_Bot
{
    static class EntryPoint
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
