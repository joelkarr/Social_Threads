using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DotNetOpenAuth.OpenId.RelyingParty;
using PerceptiveMCAPI;
using PerceptiveMCAPI.Methods;
using PerceptiveMCAPI.Types;
using SOC.Web.Models.ViewModels;

namespace SOC.Web.Controllers
{
    public partial class AccountController : Controller
    {

        public IFormsAuthenticationService FormsService { get; set; }
        public OpenIdRelyingParty OpenId { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            if (OpenId == null) { OpenId = new OpenIdRelyingParty(); }

            base.Initialize(requestContext);
        }

        public virtual ActionResult LogOn(string returnUrl)
        {
            if (!string.IsNullOrEmpty(returnUrl))
                Response.Cookies.Add(new HttpCookie("returnUrl", returnUrl));

            if (TempData["auth_error"] != null)
                ModelState.AddModelError("", TempData["auth_error"].ToString());

            return View();
        }

        // **************************************
        // URL: /Account/LogOff
        // **************************************

        public virtual ActionResult LogOff()
        {
            FormsService.SignOut();

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public virtual ActionResult MyAccount()
        {
            return View();
        }


        public virtual ActionResult Subscribe(string email)
        {
            var cmd = new listSubscribe();
            var newlistSubscribeParms = new listSubscribeParms
            {
                apikey = "5e61834e9ebfdefb991a32f48264f354-us5",
                id = "dae87a1909",
                email_address = email,
                double_optin = false,
                email_type = EnumValues.emailType.html,
                replace_interests = true,
                send_welcome = false,
                update_existing = true
            };
            var newlistSubscribeInput = new listSubscribeInput(newlistSubscribeParms);
            var subscribeSuccess = cmd.Execute(newlistSubscribeInput);
            return Json("successful");
        }

        public virtual ActionResult Contact(string email, string text)
        {
            return Json("successful");
        }
    }

}
