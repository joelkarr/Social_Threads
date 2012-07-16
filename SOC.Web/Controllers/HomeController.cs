using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View("ComingSoon");
        }
        public ActionResult About()
        {
            return ThemeView("About");
        }
    }
}
