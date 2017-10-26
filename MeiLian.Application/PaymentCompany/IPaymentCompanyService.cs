using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeiLian.Dto;
using MeiLian.PaymentCompany.DTOs;
using Abp.Application.Services.Dto;

namespace MeiLian.PaymentCompany
{
    public interface IPaymentCompanyService: IApplicationService
    {
        PaymentCompanyOutput Create(CreatePaymentCompanyInput input);

        PaymentCompanyEntity GetById(int id);

        ListResultDto<PaymentCompanyOutput> Query(QueryPaymentCompanyInput input);

        void DeleteById(int id);

        void Update(UpdatePaymentCompanyInput input);
    }
}
