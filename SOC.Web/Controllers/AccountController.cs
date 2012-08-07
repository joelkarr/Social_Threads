using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OpenId;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using DotNetOpenAuth.OpenId.RelyingParty;
using PerceptiveMCAPI;
using PerceptiveMCAPI.Methods;
using PerceptiveMCAPI.Types;

namespace SOC.Web.Controllers
{
    public partial class AccountController : Controller
    {

        public virtual ActionResult LogOn()
        {
            var openid = new OpenIdRelyingParty();
            var response = openid.GetResponse();

            if (response != null)
            {
                switch (response.Status)
                {
                    case AuthenticationStatus.Authenticated:
                        FormsAuthentication.RedirectFromLoginPage(
                            response.ClaimedIdentifier, false);
                        break;
                    case AuthenticationStatus.Canceled:
                        ModelState.AddModelError("loginIdentifier",
                            "Login was cancelled at the provider");
                        break;
                    case AuthenticationStatus.Failed:
                        ModelState.AddModelError("loginIdentifier",
                            "Login failed using the provided OpenID identifier");
                        break;
                }
            }

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public virtual ActionResult LogOn(string loginIdentifier)
        {
            if (!Identifier.IsValid(loginIdentifier))
            {
                ModelState.AddModelError("loginIdentifier",
                            "The specified login identifier is invalid");
                return View();
            }

            var openid = new OpenIdRelyingParty();
            var request = openid.CreateRequest(
                Identifier.Parse(loginIdentifier));

            // Require some additional data
            request.AddExtension(new ClaimsRequest
                                     {
                                         BirthDate = DemandLevel.NoRequest,
                                         Email = DemandLevel.Require,
                                         FullName = DemandLevel.Require
                                     });

            return request.RedirectingResponse.AsActionResult();
        }


        [Authorize]
        public virtual ActionResult MyAccount()
        {
            return View(string.Empty);
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
