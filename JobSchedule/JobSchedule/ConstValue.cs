using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule
{
    public class ConstValue
    {
        public static double VoidMinute
        {
            get
            {
                var minuteConfig = ConfigurationManager.AppSettings["VoidMinute"];
                if (!string.IsNullOrWhiteSpace(minuteConfig))
                {
                    return Convert.ToDouble(minuteConfig);
                }
                return 15;  //如果没有配置，默认返回15分钟
            }
        }

        public static string DBConnectionString
        {
            get
            {
                var connstr = ConfigurationManager.AppSettings[" connectionString"];
                if (!string.IsNullOrWhiteSpace(connstr))
                {
                    return connstr;
                }
                return "server= ;port = ;user id= ;password= ;database= "; 
            }
        }

        public static int OffineIntervalInSeconds
        {
            get
            {
                var seconds = ConfigurationManager.AppSettings["OffineIntervalInSeconds"];
                if (!string.IsNullOrWhiteSpace(seconds))
                {
                    return Convert.ToInt32(seconds);
                }
                return 60; //如果没有配置默认触发器一分钟触发一次
            }
        }

        public static int AutoVoidOrderIntervalInSeconds
        {
            get
            {
                var seconds = ConfigurationManager.AppSettings["AutoVoidOrderIntervalInSeconds"];
                if (!string.IsNullOrWhiteSpace(seconds))
                {
                    return Convert.ToInt32(seconds);
                }
                return 60; //如果没有配置默认触发器一分钟触发一次
            }
        }
        
    }
}
