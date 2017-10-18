using Abp.WebApi.Controllers;

namespace MeiLian.WebApi
{
    public abstract class MeiLianApiControllerBase : AbpApiController
    {
        protected MeiLianApiControllerBase()
        {
            LocalizationSourceName = MeiLianConsts.LocalizationSourceName;
        }
    }
}
