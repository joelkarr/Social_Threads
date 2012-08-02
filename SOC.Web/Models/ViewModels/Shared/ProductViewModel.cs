using System.Collections.Generic;

namespace SOC.Web.Models.ViewModels.Shared
{
    public class ProductViewModel
    {
        public string Sku { get; set; }
        public string Title { get; set; }
        public string DescriptionLine1 { get; set; }
        public string DescriptionLine2 { get; set; }
        public double Price { get; set; }
        public int MaxOrderQuantity { get; set; }
        public List<ImageViewModel> Images { get; set; } 
        public List<string> AvailableSizes { get; set; }

        public ProductViewModel()
        {
            Images = new List<ImageViewModel>();
            AvailableSizes = new List<string>();
        }
    }
}
