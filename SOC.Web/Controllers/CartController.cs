using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.Web.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Checkout/

        public ActionResult Current()
        {

            return View("Current", new BaseViewModel());
        }


    }
}
