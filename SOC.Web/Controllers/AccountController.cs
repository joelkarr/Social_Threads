using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DotNetOpenAuth.OpenId.RelyingParty;
using SOC.Web.Models;
using SOC.Web.Models.ViewModels;

namespace SOC.Web.Controllers
{
    public class AccountController : Controller
    {

        public IFormsAuthenticationService FormsService { get; set; }
        public OpenIdRelyingParty OpenId { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            if (OpenId == null) { OpenId = new OpenIdRelyingParty(); }

            base.Initialize(requestContext);
        }

        public ActionResult LogOn(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl))
                Response.Cookies.Add(new HttpCookie("returnUrl", returnUrl));

            if (TempData["auth_error"] != null)
                ModelState.AddModelError("", TempData["auth_error"].ToString());

            return View(string.Empty);
        }

        // **************************************
        // URL: /Account/LogOff
        // **************************************

        public ActionResult LogOff()
        {
            FormsService.SignOut();

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public ActionResult MyAccount()
        {
            return View(string.Empty);
        }

    }

}
