using System.Web.Mvc;

namespace SOC.Web.Controllers
{
    public partial class StoreController : Controller
    {
        //
        // GET: /Store/

        public virtual ActionResult OrderForm()
        {
            return View();
        }

    }
}
