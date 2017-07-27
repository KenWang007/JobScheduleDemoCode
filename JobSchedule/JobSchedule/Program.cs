using JobSchedule.FlashItemOffline;
using JobSchedule.VoidUnPaidOrderJob;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule
{
    static class Program
    {
        static void Main(string[] args)
        {
            var servicesToRun = new ServiceBase[]
           {
                  new JobManager()
           };
            ServiceBase.Run(servicesToRun);

            //test　Code
            //AutoVoidUnPaidOrderJob job = new AutoVoidUnPaidOrderJob();
            //job.Execute(null);

            //FlashItemOfflineJob job1 = new FlashItemOfflineJob();
            //job1.Execute(null);
        }
    }
}
