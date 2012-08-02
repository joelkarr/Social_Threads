namespace SOC.Web.Models.ViewModels.Base.Partial
{
    public class ItemViewModel
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string ThumbnailPath { get; set; }
    }
}