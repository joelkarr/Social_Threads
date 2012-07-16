using System.Web.Mvc;
using SOC.Web.Helpers;

namespace SOC.Web.Controllers
{
    public class BaseController : Controller
    {
        protected ViewResult BaseView(IView view, object model = null)
        {
            return ThemeView(view, model, SiteTheme.Base);
        }

        protected ViewResult BaseView(string viewName, object model = null)
        {
            return ThemeView(viewName, model, SiteTheme.Base);
        }

        protected ViewResult ThemeView(string viewName, object model = null, SiteTheme theme = SiteTheme.None)
        {
            switch (theme)
            {
                case SiteTheme.None:
                    theme = GetTheme();
                    return View(string.Format("~/Themes/{0}/Views/{1}/{2}.cshtml", theme, RouteData.Values["controller"], viewName), model);
                default:
                    return View(string.Format("~/BaseViews/{0}", viewName), model);
            }
        }

        protected ViewResult ThemeView(IView view, object model = null, SiteTheme theme = SiteTheme.None)
        {
            switch (theme)
            {
                case SiteTheme.None:
                    theme = GetTheme();
                    return View(string.Format("~/App_Themes/{0}/Views/{1}/{2}", theme, RouteData.Values["controller"], view), model);
                default:
                    return View(string.Format("~/BaseViews/{0}", view), model);
            }
        }

        private SiteTheme GetTheme()
        {
            return SiteTheme.Classic;
        }
    }
}
