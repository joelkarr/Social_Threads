using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOC.Web.Areas.Admin.Controllers
{
    public class AnalyticsController : Controller
    {
        //
        // GET: /Admin/Analytics/

        public ActionResult Dashboard()
        {
            return View();
        }

    }
}
