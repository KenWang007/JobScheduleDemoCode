using Quartz;
using System;

namespace JobSchedule.VoidUnPaidOrderJob
{
    public class AutoVoidUnPaidOrderJob : IJob
    {
        NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        public void Execute(IJobExecutionContext context)
        {
            log.Info("超时自动作废订单Job开启--------------"); 
            try
            {
                var processData = VoidUnPaidOrderDBHelper.GetUnPaidOrder();

                log.Info(string.Format("超时自动作废订单Job：本次共获取待处理的数据{0}条--------------", processData.Count));

                if (processData != null && processData.Count > 0)
                {
                    foreach (var item in processData)
                    {
                        if (item.CreatedAt.AddMinutes(ConstValue.VoidMinute) <= DateTime.Now)
                        {
                            //作废订单
                            VoidUnPaidOrderDBHelper.VoidUnPaidOrder(item);
                            //纪录订单日志
                            VoidUnPaidOrderDBHelper.InsertOrderLog(item);

                            log.Info(string.Format("超时自动作废订单Job：订单 {0}作废成功--------------", item.OrderCode));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("超时自动作废订单Job：执行出错，错误信息：" + ex.InnerException);
            }
        }
    }
}
