using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using MeiLian.Authorization;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : MeiLianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
