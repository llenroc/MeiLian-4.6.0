using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace MeiLian.Web.Views
{
    public abstract class MeiLianWebViewPageBase : MeiLianWebViewPageBase<dynamic>
    {
       
    }

    public abstract class MeiLianWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected MeiLianWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = MeiLianConsts.LocalizationSourceName;
        }
    }
}
