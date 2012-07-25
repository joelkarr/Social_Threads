using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return ComingSoon();
        }

        public ActionResult ComingSoon()
        {
            var model = new BaseViewModel();
            return View("ComingSoon", model);
        }
    }
}
