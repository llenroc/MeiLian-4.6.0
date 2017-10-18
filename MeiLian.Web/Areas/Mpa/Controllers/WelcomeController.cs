using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : MeiLianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
