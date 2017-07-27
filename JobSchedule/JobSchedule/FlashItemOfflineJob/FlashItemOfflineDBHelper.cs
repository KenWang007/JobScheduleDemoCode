using JobSchedule.DBHelper;
using JobSchedule.Entity.FlashItemOfflineJob;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule.FlashItemOffline
{
    public class FlashItemOfflineDBHelper
    {
        internal static List<FlashSalePromotion> GetOfflineFlashPromotion()
        {
            using (IDbConnection conn = DBConnection.CreateConnection())
            {
                //查找就绪和运行中的活动
                string sql = @"SELECT * FROM flashsalepromotion WHERE Status IN(2,3)";
                var result = Dapper.SqlMapper.Query<FlashSalePromotion>(conn, sql).ToList();
                return result;
            }
        }

        /// <summary>
        /// 上线/下线活动
        /// </summary>
        /// <param name="item"></param>
        internal static void UpdatePromotionStatus(int sysNo, int status)
        {
            using (IDbConnection conn = DBConnection.CreateConnection())   
            {
                string sql = @"UPDATE flashsalepromotion
                                      SET Status = {0},EditUser = 99999,EditDate=now()
                                      where sysNo = {1}";
                Dapper.SqlMapper.Execute(conn, string.Format(sql, status, sysNo));
            }
        }
    }
}
