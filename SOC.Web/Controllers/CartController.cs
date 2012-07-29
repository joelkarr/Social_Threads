using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.Web.Controllers
{
    public class CartController : Controller
    {

        public ActionResult Current()
        {

            return View("Current", new BaseViewModel());
        }

        public ActionResult Checkout()
        {

            return View("Checkout", new BaseViewModel());
        }

    }
}
