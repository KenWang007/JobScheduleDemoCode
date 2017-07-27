using JobSchedule.FlashItemOffline;
using JobSchedule.VoidUnPaidOrderJob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule
{
    public partial class JobManager : ServiceBase
    {
        public JobManager()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //开启调度器
             ScheduleBase.Scheduler.Start();

            //把作业，触发器加入调度器
            ScheduleBase.AddSchedule(new AutoVoidUnPaidOrderService());

            ScheduleBase.AddSchedule(new FlashItemOfflineJobService());
        }

        protected override void OnStop()
        {
            ScheduleBase.Scheduler.Shutdown(true);
        }
    }
}
