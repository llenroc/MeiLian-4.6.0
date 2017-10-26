using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace MeiLian.PaymentCompany.DTOs
{
    [AutoMapFrom(typeof(PaymentCompanyEntity))]
    /// <summary>
    /// 发薪公司显示实体
    /// </summary>
    public class PaymentCompanyOutput : FullAuditedEntityDto
    {
        /// <summary>
        /// 发薪公司名称
        /// </summary>
        public string Name { get; set; }

    }
}
