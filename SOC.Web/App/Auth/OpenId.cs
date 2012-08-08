using System;
using DotNetOpenAuth.OpenId;
using DotNetOpenAuth.OpenId.RelyingParty;

namespace SOC.Web.App.Auth
{
    public class OpenId
    {
        private OpenIdRelyingParty OpenIdRelyingParty { get; set; }
        private IAuthenticationResponse Response { get; set; }

        public OpenId()
            : this(null)
        {

        }

        public OpenId(OpenIdRelyingParty relyingParty)
        {
            OpenIdRelyingParty = relyingParty ?? new OpenIdRelyingParty();
        }

        public OpenIdentity ProcessOpenId(string openId)
        {
            Response = OpenIdRelyingParty.GetResponse();

            if (Response == null)
            {
                Authenticate(openId);
                return null;
            }

            return Verify();


        }

        public void Authenticate(string openId)
        {
            Identifier id;
            if (Identifier.TryParse(openId, out id))
            {
                OpenIdRelyingParty.CreateRequest(id).RedirectingResponse.Send();
            }
            else
            {
                throw new ApplicationException("Invalid Identifier");
            }
        }

        public OpenIdentity Verify()
        {
            var oid = new OpenIdentity();

            switch (Response.Status)
            {
                case AuthenticationStatus.Authenticated:
                    oid.Id = Response.ClaimedIdentifier;
                    oid.Username = Response.FriendlyIdentifierForDisplay;
                    break;
                case AuthenticationStatus.Canceled:
                    throw new ApplicationException("Canceled at Provider");
                case AuthenticationStatus.Failed:
                    throw new ApplicationException(Response.Exception.Message);
            }

            return oid;
        }
    }
}