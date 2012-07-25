using System.Collections.Generic;
using System.Configuration;

namespace SOC.Web.Models.ViewModels.Base
{
    public class BaseViewModel
    {
        #region Cart
        public int CartItemCount { get; set; }
        public decimal CartTotal { get; set; }
        public List<Item> CartItems { get; set; }
        #endregion

        public string PageTitle { get; set; }
        public URLCollection URLs { get; set; }
        public Theme Theme { get; set; }
        public BaseViewModel()
        {
            URLs = new URLCollection();
            CartItems= new List<Item>();
            Theme = new Theme {Name = "Default", BaseURL = "localhost", TagLine = "Online Order Forms"};
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string ThumbnailPath { get; set; }
    }
    public class Theme
    {
        public string Name { get; set; }
        public string TagLine { get; set; }
        public string BaseURL { get; set; }


    }
    public class URLCollection
    {
        public string CDN
        {
            get { return ConfigurationManager.AppSettings["CDNPath"]; }
        }

        public string CDNThemes
        {
            get { return ConfigurationManager.AppSettings["CDNThemePath"]; }
        }

    }
    
}