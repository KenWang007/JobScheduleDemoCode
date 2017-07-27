using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule.Entity.VoidUnPaidOrderJob
{
    public class SalesOrder
    {

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
		public int CustomerId { get; set; }

        /// <summary>
        /// 商家
        /// </summary>
		public int MerchantId { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
		public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 隐藏
        /// </summary>
		public bool Hidden { get; set; }

        /// <summary>
        /// 有效
        /// </summary>
		public bool Valid { get; set; }

        /// <summary>
        /// 送货时间
        /// </summary>
		public int DeliveryTimeId { get; set; }

        /// <summary>
        /// 商品金额
        /// </summary>
		public decimal ItemAmount { get; set; }

        /// <summary>
        /// 需支付金额
        /// </summary>
		public decimal NeedPayAmount { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
		public decimal PayAmount { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
		public decimal Freight { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
		public decimal OrderAmount { get; set; }

        /// <summary>
        /// 优惠券
        /// </summary>
		public string CouponCode { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
		public decimal CouponAmount { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
		public string CardCode { get; set; }

        /// <summary>
        /// 卡金额
        /// </summary>
		public decimal CardAmount { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
		public int Integral { get; set; }

        /// <summary>
        /// 
        /// </summary>
		public decimal Balance { get; set; }

        /// <summary>
        /// 积分金额
        /// </summary>
		public decimal IntegralAmount { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
		public string PayWayCode { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
		public int OrderType { get; set; }

        /// <summary>
        /// 已支付
        /// </summary>
		public bool Paid { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
		public int OrderStatus { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
		public int ChannelId { get; set; }

        /// <summary>
        /// 下单Ip地址
        /// </summary>
		public string IpAddress { get; set; }

        /// <summary>
        /// 评论状态
        /// </summary>
		public int CommentStatus { get; set; }
    }
}
