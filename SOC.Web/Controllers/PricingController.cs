using System.Web.Mvc;

namespace SOC.Web.Controllers
{
    public class PricingController : Controller
    {
        //
        // GET: /Pricing/

        public ActionResult Quote()
        {
            return View();
        }

    }
}
