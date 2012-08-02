using System.Linq;
using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;
using SOC.Web.Models.ViewModels.Base.Partial;

namespace SOC.Web.Controllers
{
    public partial class CartController : BaseController
    {

        public virtual ActionResult Current()
        {

            return View("Current",new BaseViewModel(ViewData.Model as BaseViewModel));
        }

        public virtual ActionResult Checkout()
        {


            return View("Checkout", new BaseViewModel(ViewData.Model as BaseViewModel));
        }

        public virtual ActionResult Add(ItemViewModel item)
        {
            var model = Session["cart"] as CartViewModel ?? new CartViewModel();
            //Check if Item already in cart.
            var existingItem = (from i in model.Items where i.Sku == item.Sku select i).FirstOrDefault();
            if(existingItem == null)
            {
                model.Items.Add(item);
            }
            else
            {
                existingItem.Quantity += item.Quantity;
            }
            model.TotalPrice += item.Price * item.Quantity;
            Session["cart"] = model;
            return View(MVC.Shared.Views.Partial.QuickCart, model);

        }
    }
}