using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;
using SOC.Web.Models.ViewModels.Base.Partial;
using SOC.Web.Models.ViewModels.Order;
using SOC.Web.Models.ViewModels.Order.Object;
using SOC.Web.Models.ViewModels.Shared;


namespace SOC.Web.Controllers
{
    public partial class OrderController : BaseController
    {
        //
        // GET: /Order/

        public virtual ActionResult Form(string id)
        {
            var model = new FormViewModel(ViewData.Model as BaseViewModel);
            var product1 = new ProductViewModel
                               {
                                   Title = "Karrbros Official Shirt",
                                   Price = 19.99,
                                   MaxOrderQuantity = 10,
                                   DescriptionLine1 = "50/50  Cotton Jerzee",
                                   DescriptionLine2 = "White Shirt - Blue/Orange Ink",
                                   AvailableSizes = new List<string> {"Small", "Medium", "Large", "X-Large"}
                               };
            var images = new List<ImageViewModel>();
            var image = new ImageViewModel
                            {
                                AltText = "Karrbros Official Shirt",
                                Path =string.Format("{0}/{1}/officialshirt.png", model.URLs.CDNOrders, id),
                                Title = "Karrbros Official Shirt"
                            };
            images.Add(image);
            product1.Images = images;
            model.Order.Products.Add(product1);
            model.Order.Title = "Karrbros Official";
            var crumb = new BreadCrumbViewModel { Display = "Order Search", Title = "order search", Url = "/Order/Search" };
            var crumb2 = new BreadCrumbViewModel { Display = model.Order.Title, Title = model.Order.Title, Url = "/Order/Form/" + model.Order.Id };
            model.BreadCrumbs.Add(crumb);
            model.BreadCrumbs.Add(crumb2);

           return View("Form", model);
        }

        public virtual  JsonResult GetDefault()
        {
            var model = new ItemViewModel {Sku = "test", Price = 10.00, Size = "Small", Quantity = 0};
            return Json(model);
        }

        public virtual ActionResult Search()
        {
            var model = new SearchViewModel(ViewData.Model as BaseViewModel);
            var order = new OrderViewModel
                            {Id = 100, Deadline = DateTime.Now, Title = "Karrbros Official", Group = "Best Group Evar"};
            var order2 = new OrderViewModel {Id = 101, Deadline = DateTime.Now.AddDays(15), Title = "Clinton Wrestling", Group = "Time To Get Live" };
            model.Orders.Add(order);
            model.Orders.Add(order2);
            var crumb = new BreadCrumbViewModel
                            {Display = "Order Search", Title = "order search", Url = "/Order/Search"};
            model.BreadCrumbs.Add(crumb);
            return View("Search", model);
        }

    }
}
