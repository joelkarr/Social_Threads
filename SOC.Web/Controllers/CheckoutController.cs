using System.Web.Mvc;

namespace SOC.Web.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /Checkout/

        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Result()
        {
            return View();
        }

    }
}
