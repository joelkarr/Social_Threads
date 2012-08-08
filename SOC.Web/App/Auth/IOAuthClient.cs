using System;

namespace SOC.Web.App.Auth
{
    interface IOauthClient
    {
        void Authenticate(Uri callback);
        OpenIdentity Verify();
    }
}
