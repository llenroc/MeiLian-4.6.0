using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MeiLian.Web.Areas.Mpa.Models.Common.Modals;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : MeiLianControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}
