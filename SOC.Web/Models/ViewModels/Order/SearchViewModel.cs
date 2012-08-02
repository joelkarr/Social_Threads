using System;
using System.Collections.Generic;
using SOC.Web.Models.ViewModels.Base;
using SOC.Web.Models.ViewModels.Order.Object;

namespace SOC.Web.Models.ViewModels.Order
{
    public class SearchViewModel : BaseViewModel
    {
        public List<OrderViewModel> Orders { get; set; }

        public SearchViewModel(BaseViewModel model)
        {
            Cart = model.Cart;
            Orders = new List<OrderViewModel>();
        }
    }
}