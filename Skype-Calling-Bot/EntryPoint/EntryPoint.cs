using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Skype_Calling_Bot
{
    static class EntryPoint
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
