using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;
using SOC.Web.Models.ViewModels.Base.Partial;

namespace SOC.Web.Controllers
{
    public partial class CartController : Controller
    {

        public virtual ActionResult Current()
        {

            return View("Current", new BaseViewModel());
        }

        public virtual ActionResult Checkout()
        {


            return View("Checkout", new BaseViewModel());
        }

        public virtual ActionResult AddItem(int Id)
        {
            var model = Session["cart"] as CartViewModel ?? new CartViewModel();
            return View(MVC.Shared.Views.Partial.QuickCart, model);

        }
    }
}