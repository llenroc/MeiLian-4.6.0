using Abp.Application.Services;
using MeiLian.Tenants.Dashboard.Dto;

namespace MeiLian.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}

