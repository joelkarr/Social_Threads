using System.Collections.Generic;

namespace SOC.Web.Models.ViewModels.Base.Partial
{
    public class CartViewModel
    {
        public int ItemCount { get; set; }
        public double TotalPrice { get; set; }
        public List<ItemViewModel> Items { get; set; } 

        public CartViewModel()
        {
            Items = new List<ItemViewModel>();
        }
    }
}