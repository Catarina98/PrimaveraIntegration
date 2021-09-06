using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Integrator
{
    public partial class Service1 : ServiceBase
    {

        Thread Worker;
        AutoResetEvent StopRequest = new AutoResetEvent(false);

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Worker = new Thread(ThreadWorker);
            Worker.Start();

        }

        protected override void OnStop()
        {
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        private void ThreadWorker(object arg)
        {
            Job cjob = new Job();
            cjob.Start();
            
        }
    }
}
