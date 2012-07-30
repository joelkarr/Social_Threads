using System.Web.Mvc;

namespace SOC.Web.Controllers
{
    public partial class DesignerController : Controller
    {
        //
        // GET: /Designer/

        public virtual ActionResult Studio()
        {
            return View();
        }

        #region Web API

        #region Graphics
        public virtual JsonResult GetGraphicsFromGroup(int groupId)
        {
            return new JsonResult();
        }

        public virtual JsonResult GetGraphcisFromKeyword(string keyword)
        {
            return new JsonResult();
        }
        #endregion

        public virtual JsonResult GetAutoCompleteKeywords(string input)
        {
            return new JsonResult();
        }

        #region Products
        public virtual JsonResult GetColorOptionsFromProductId(int productId)
        {
            return new JsonResult();
        }

        public virtual JsonResult GetAvailableSizesFromProductId(int productId)
        {
            return new JsonResult();
        }
        #endregion

        public virtual JsonResult GetPrintersAvailableInkColors()
        {
            //use baseModel Printer
            return new JsonResult();
        }

        #region Fonts
        public virtual JsonResult GetFontsFromGroup(int groupId)
        {
            return new JsonResult();
        }
        public virtual JsonResult GetFontsFromKeyword(string keyword)
        {
            return new JsonResult();
        }
        #endregion
        #endregion


    }
}
