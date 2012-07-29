using System.Collections.Generic;

namespace SOC.Web.Models.ViewModels.Order.Object
{
    public class ItemViewModel
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public List<string> ImagePaths { get; set; }
        public decimal Price { get; set; }

    }
}