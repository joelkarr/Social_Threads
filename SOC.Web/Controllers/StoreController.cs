using System.Web.Mvc;

namespace SOC.Web.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult OrderForm()
        {
            return View();
        }

    }
}
