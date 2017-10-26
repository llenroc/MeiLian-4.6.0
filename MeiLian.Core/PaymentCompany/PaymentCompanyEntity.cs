using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiLian.PaymentCompany
{
    [Table("PaymentCompany")]
    /// <summary>
    /// 发薪公司实体
    /// </summary>
    public class PaymentCompanyEntity: FullAuditedEntity
    {
        [Required]
        [MaxLength(50)]
        /// <summary>
        /// 发薪公司名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 发薪公司限额
        /// </summary>
        public decimal LimitAmount { get; set; }
    }
}
