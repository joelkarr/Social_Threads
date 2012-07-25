using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOC.Entities;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.Web.Controllers
{
    public class OrderController : BaseController
    {
        //
        // GET: /Order/

        public ActionResult Form()
        {
            var model = new BaseViewModel();
            return View("Form", model);
        }

    }
}
