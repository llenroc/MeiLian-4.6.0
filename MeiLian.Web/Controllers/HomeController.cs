using System.Web.Mvc;

namespace MeiLian.Web.Controllers
{
    public class HomeController : MeiLianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
