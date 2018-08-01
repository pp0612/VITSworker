﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace VITSworker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            #if DEBUG

            VitsDBupdate Myservice = new VitsDBupdate();
                Myservice.Ondebug();
                System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

            #else


                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new VitsDBupdate()
                };
                ServiceBase.Run(ServicesToRun);
            #endif
        }
    }
}
