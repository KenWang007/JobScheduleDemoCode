using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace JobSchedule.VoidUnPaidOrderJob
{
    public class AutoVoidUnPaidOrderService : JobService<AutoVoidUnPaidOrderJob>
    {
        protected override string GroupName
        {
            get
            {
                return "订单逾期未支付自动作废作业处理";
            }
        }

        protected override string JobName
        {
            get
            {
                return "订单逾期未支付自动作废";
            }
        }

        protected override ITrigger GetTrigger()
        {
            var trigger = TriggerBuilder.Create()
              .WithIdentity("订单逾期未支付自动作废", "作业触发器") 
               .WithSimpleSchedule(x => x
                   .WithIntervalInSeconds(ConstValue.AutoVoidOrderIntervalInSeconds)
                  .RepeatForever())
              .Build();
            return trigger;
        }
    }
}
