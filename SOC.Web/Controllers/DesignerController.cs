﻿using System.Web.Mvc;

namespace SOC.Web.Controllers
{
    public class DesignerController : Controller
    {
        //
        // GET: /Designer/

        public ActionResult Studio()
        {
            return View();
        }

        #region Web API

        #region Graphics
        public JsonResult GetGraphicsFromGroup(int groupId)
        {
            return new JsonResult();
        }

        public JsonResult GetGraphcisFromKeyword(string keyword)
        {
            return new JsonResult();
        }
        #endregion

        public JsonResult GetAutoCompleteKeywords(string input)
        {
            return new JsonResult();
        }

        #region Products
        public JsonResult GetColorOptionsFromProductId(int productId)
        {
            return new JsonResult();
        }

        public JsonResult GetAvailableSizesFromProductId(int productId)
        {
            return new JsonResult();
        }
        #endregion

        public JsonResult GetPrintersAvailableInkColors()
        {
            //use baseModel Printer
            return new JsonResult();
        }

        #region Fonts
        public JsonResult GetFontsFromGroup(int groupId)
        {
            return new JsonResult();
        }
        public JsonResult GetFontsFromKeyword(string keyword)
        {
            return new JsonResult();
        }
        #endregion
        #endregion


    }
}
