using System.Web.Mvc;

namespace SOC.Web.Controllers
{
    public partial class PricingController : Controller
    {
        //
        // GET: /Pricing/

        public virtual ActionResult Quote()
        {
            return View();
        }

    }
}
