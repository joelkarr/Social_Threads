using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.Web.Controllers
{
    public partial class HomeController : BaseController
    {
        public virtual ActionResult Index()
        {
            return ComingSoon();
        }

        public virtual ActionResult ComingSoon()
        {
            var model = new BaseViewModel();
            return View("ComingSoon", model);
        }
    }
}
