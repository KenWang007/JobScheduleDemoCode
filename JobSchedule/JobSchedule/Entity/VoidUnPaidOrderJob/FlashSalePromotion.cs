using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule.Entity.VoidUnPaidOrderJob
{
    public class FlashSalePromotion
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public int SysNo { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public string PromotionName { get; set; }
        /// <summary>
        /// 活动描述
        /// </summary>
        public string PromotionDescription { get; set; }
        /// <summary>
        /// 活动规则
        /// </summary>
        public string PromotionRules { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime PromotionStartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime PromotionEndTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int InUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime InDate { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        public int? EditUser { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? EditDate { get; set; }
        /// <summary>
        /// 国家编码
        /// </summary>
        public string CompanyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StoreCompanyCode { get; set; }
        /// <summary>
        /// 语言
        /// </summary>
        public string Language { get; set; }
    }
}
