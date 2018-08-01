using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace VITSworker
{
    public partial class VitsDBupdate : ServiceBase
    {
        public VitsDBupdate()
        {
            InitializeComponent();
        }
        public void Ondebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory +"onstart.txt");
        }

        protected override void OnStop()
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "onstop.txt");
        }
    }
}
