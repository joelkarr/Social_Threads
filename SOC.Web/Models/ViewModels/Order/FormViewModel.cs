using SOC.Web.Models.ViewModels.Base;
using SOC.Web.Models.ViewModels.Order.Object;

namespace SOC.Web.Models.ViewModels.Order
{
    public class FormViewModel : BaseViewModel
    {
        public OrderViewModel Order { get; set; }
        public FormViewModel(BaseViewModel model)
        {
            Cart = model.Cart;
            Order = new OrderViewModel();
        }
    }
}