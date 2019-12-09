using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Viewtance.ERP.Controllers;

namespace Viewtance.ERP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ERPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
