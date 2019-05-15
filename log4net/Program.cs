using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;

namespace log4net
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log.Info("Entering application......");
            Console.WriteLine("Hello, World!");
            log.Info("Exiting application......");
        }
    }
}
