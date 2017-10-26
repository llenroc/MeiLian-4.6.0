using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Extensions;

namespace MeiLian.PaymentCompany.DTOs
{
    public class UpdatePaymentCompanyInput : CreatePaymentCompanyInput, ICustomValidate
    {
        public int Id { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (Id == 0)
                context.Results.Add(new System.ComponentModel.DataAnnotations.ValidationResult("编码不能为空"));
        }
    }
}
