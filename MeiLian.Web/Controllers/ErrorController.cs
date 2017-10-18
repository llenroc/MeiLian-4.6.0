using System.Web.Mvc;
using Abp.Auditing;

namespace MeiLian.Web.Controllers
{
    public class ErrorController : MeiLianControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}
