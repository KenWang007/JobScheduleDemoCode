using JobSchedule.DBHelper;
using JobSchedule.Entity.VoidUnPaidOrderJob;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSchedule.Entity.StatusEnum;

namespace JobSchedule.VoidUnPaidOrderJob
{
    public class VoidUnPaidOrderDBHelper
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        internal static List<SalesOrder> GetUnPaidOrder()
        {
            using (IDbConnection conn = DBConnection.CreateConnection())
            {
                var sql = @"SELECT * FROM order_salesorder WHERE PromotionId>0 and orderstatus = 1";
                var result = Dapper.SqlMapper.Query<SalesOrder>(conn, sql).ToList();
                return result;
            }
        }

        internal static void VoidUnPaidOrder(SalesOrder item)
        {
            try
            {
                using (IDbConnection conn = DBConnection.CreateConnection())
                {
                    var sql = @"Update order_salesorder
                                  SET OrderStatus = -10,EditUser = 99999,EditDate=now()
                                  WHERE OrderCode='{0}'";
                    var execsql = string.Format(sql, item.OrderCode);
                    var result = Dapper.SqlMapper.Execute(conn, execsql);
                }
            }
            catch (Exception ex)
            {
                log.Error(string.Format("自动作废订单失败，订单号：{0}，错误信息：{1}", item.OrderCode, ex.InnerException));
            }
        }

        /// <summary>
        /// 纪录订单日志
        /// </summary>
        /// <param name="item"></param>
        internal static void InsertOrderLog(SalesOrder item)
        {
            using (IDbConnection conn = DBConnection.CreateConnection())
            {
                var sql = @" INSERT INTO order_orderlog
                                ( 
                                 OrderCode
                                 ,ActionType
                                 ,SourceStatus
                                 ,TargetStatus
                                 ,InDate
                                 ,InUser
                                )
                                VALUES
                                ( 
                                 '{0}'
                                 ,{1}-- ActionType - INT(11)
                                 ,{2}-- SourceStatus - INT(11)
                                 ,{3}-- TargetStatus - INT(11)
                                 ,NOW() -- InDate - DATETIME
                                 ,99999-- InUser - INT(11)
                                );";
                var execSql = string.Format(sql, item.OrderCode, (int)ActionType.AutoVoidOrder, (int)OrderStatus.AutoVoid, item.OrderStatus);
                Dapper.SqlMapper.Execute(conn, execSql);
            }

        }
    }
}
