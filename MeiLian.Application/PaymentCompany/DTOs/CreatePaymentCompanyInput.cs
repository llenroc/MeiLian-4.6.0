using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace MeiLian.PaymentCompany.DTOs
{
    [AutoMapTo(typeof(PaymentCompanyEntity))]
    public class CreatePaymentCompanyInput
    {
        [Required]
        [MaxLength(50, ErrorMessage = "发薪公司名称不能大于50个字符")]
        public string Name { get; set; }

        [Required]
        [Range(typeof(decimal), "0", "9999999999", ErrorMessage = "请正常填写限制数值")]
        public decimal LimitAmount { get; set; }
    }
}
