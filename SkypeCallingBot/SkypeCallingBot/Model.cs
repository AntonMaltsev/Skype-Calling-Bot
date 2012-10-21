using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;
using log4net;

namespace SkypeCallingBot
{
    public class Model
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Model)); 
        private static ISessionFactory sessions;

        public static ISession getSession()
        {
            if (sessions == null)
            {
                Configuration config = new Configuration();
                config.Configure();
                Console.WriteLine("Assembly=" + Assembly.GetCallingAssembly());
                //config.AddFile("Simple.hbm.xml");
                sessions = config.BuildSessionFactory();
                //cfg.AddFile("Phone.hbm.xml");
            }
            return sessions.OpenSession();
        }

        public static void check()
        {
            log.Debug("Check is logger correct");
        }
    }
}
