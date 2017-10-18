using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MeiLian.Authorization;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : MeiLianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
