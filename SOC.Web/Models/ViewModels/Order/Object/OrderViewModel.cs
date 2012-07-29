using System;
using System.Collections.Generic;
using SOC.Web.Models.ViewModels.Shared;

namespace SOC.Web.Models.ViewModels.Order.Object
{
    public class OrderViewModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Group { get; set; }
        public DateTime Deadline { get; set; }
        public List<ProductViewModel> Products { get; set; }

        public OrderViewModel()
        {
            Products = new List<ProductViewModel>();
        }
    }
}