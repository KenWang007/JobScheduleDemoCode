using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule.Entity
{
    public class StatusEnum
    {
        public enum OrderStatus
        {
            /// <summary>
            ///     待支付
            /// </summary>
            [Description("待支付")]
            Created = 1,

            /// <summary>
            ///     待审核
            /// </summary>
            [Description("待审核")]
            Auditing = 4,

            /// <summary>
            ///     支付成功等待处理
            /// </summary>
            [Description("支付成功等待处理")]
            WaitHandle = 3,

            /// <summary>
            ///     即将发货
            /// </summary>
            [Description("即将发货")]
            Picking = 5,

            /// <summary>
            ///     已发货
            /// </summary>
            [Description("已发货")]
            Deliveries = 7,

            /// <summary>
            /// 已到达自提点
            /// </summary>
            [Description("已到达自提点")]
            Arrive = 10,

            /// <summary>
            ///     交易成功
            /// </summary>
            [Description("交易成功")]
            Completed = 8,

            /// <summary>
            ///     交易未成功
            /// </summary>
            [Description("交易取消")]
            Void = 9,


            /// <summary>
            /// 超时支付自动作废
            /// </summary>
            [Description("超时支付自动作废")]
            AutoVoid = -10
        }

        public enum ActionType
        {
            /// <summary>
            /// 创建订单
            /// </summary>
            [Description("创建订单")]
            CreateOrder = 1,

            /// <summary>
            /// 作废订单
            /// </summary>
            [Description("作废订单")]
            VoidOrder = 2,

            /// <summary>
            /// 超时自动作废
            /// </summary>
            [Description("超时自动作废")]
            AutoVoidOrder = 3

        }

        /// <summary>
        /// 抢购活动状态枚举定义
        /// </summary>
        public enum FlashSaleStatusType
        {
            /// <summary>
            /// 初始
            /// </summary>
            [Description("初始")]
            Initial = 1,
            /// <summary>
            /// 就绪
            /// </summary>
            [Description("就绪")]
            BeReady = 2,
            /// <summary>
            /// 运行
            /// </summary>
            [Description("运行")]
            Processing = 3,
            /// <summary>
            /// 终止
            /// </summary>
            [Description("终止")]
            Termination = 4,
            /// <summary>
            /// 结束
            /// </summary>
            [Description("结束")]
            Finished = 5,
        }
    }
}
