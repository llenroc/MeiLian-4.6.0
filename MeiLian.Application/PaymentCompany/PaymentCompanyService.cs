using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MeiLian.PaymentCompany.DTOs;
using Abp.Domain.Repositories;
using Abp.AutoMapper;
using AutoMapper;
using Abp.Extensions;
using Abp.Linq.Extensions;

namespace MeiLian.PaymentCompany
{
    public class PaymentCompanyService : MeiLianAppServiceBase, IPaymentCompanyService
    {
        private readonly IRepository<PaymentCompanyEntity> _paymentCompanyRep;

        public PaymentCompanyService(IRepository<PaymentCompanyEntity> paymentCompanyRep)
        {
            _paymentCompanyRep = paymentCompanyRep;
        }

        public PaymentCompanyOutput Create(CreatePaymentCompanyInput input)
        {
            Logger.Info("创建发薪公司:" + input.ToString());
            return _paymentCompanyRep.Insert(Mapper.Map<PaymentCompanyEntity>(input)).MapTo<PaymentCompanyOutput>();
        }

        public void DeleteById(int id)
        {
            Logger.Info("删除发薪公司：" + id);
            _paymentCompanyRep.Delete(id);
        }

        public PaymentCompanyEntity GetById(int id)
        {
            return _paymentCompanyRep.Get(id);
        }

        public ListResultDto<PaymentCompanyOutput> Query(QueryPaymentCompanyInput input)
        {
            var query = _paymentCompanyRep.GetAll()
                .WhereIf(
                    input.Name.IsNullOrEmpty() == false,
                    p => p.Name.Contains(input.Name)
                )
                .OrderBy(p => p.CreationTime);

            return new ListResultDto<PaymentCompanyOutput>(query.MapTo<List<PaymentCompanyOutput>>());
        }

        public void Update(UpdatePaymentCompanyInput input)
        {
            var model = _paymentCompanyRep.Get(input.Id);

            model.Name = input.Name;
            model.LimitAmount = input.LimitAmount;

            //不需要手动触发保存动作，在Unit of Work的作用下会自动保存。

            Logger.Info("更新发薪公司:" + model.Id);
        }
    }
}
