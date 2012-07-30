using System.Collections.Generic;
using System.Configuration;
using SOC.Web.Models.ViewModels.Base.Partial;

namespace SOC.Web.Models.ViewModels.Base
{
    public class BaseViewModel
    {
        public CartViewModel Cart { get; set; }
        public string PageTitle { get; set; }
        public List<BreadCrumbViewModel> BreadCrumbs { get; set; }
        public string CurrentCrumb { get; set; }
        public URLCollection URLs { get; set; }
        public Theme Theme { get; set; }
        public BaseViewModel()
        {
            Cart = new CartViewModel();
            URLs = new URLCollection();
            BreadCrumbs = new List<BreadCrumbViewModel>();
            Theme = new Theme {Name = "Default", BaseURL = "localhost", TagLine = "Online Order Forms"};
        }
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

        public string CDNOrders
        {
            get { return ConfigurationManager.AppSettings["CDNOrderPath"]; }
        }

    }
    
}