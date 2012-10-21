using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SkypeCallingBot.SkypeEngine;

namespace SkypeCallingBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkypeProxy proxy = new SkypeProxy(20);
            proxy.callTo("sansherbina").waitForResponse(15);
            Application.Run(new Form1());
        }
    }
}
