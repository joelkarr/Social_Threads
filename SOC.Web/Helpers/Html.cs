using System;
using SOC.Util;

namespace SOC.Web.Helpers
{
    public class Html
    {
        #region Base
        public static string BaseScript(string fileName)
        {
            return StaticFile(StaticContentType.Scripts, fileName);
        }
        public static string BaseStyle(string fileName)
        {
            return StaticFile(StaticContentType.Styles, fileName);
        }
        public static string BaseImage(string fileName)
        {
            return StaticFile(StaticContentType.Images, fileName);
        }
        #endregion

        #region Themes
        public static string ThemeScript(string fileName, string theme)
        {
            return StaticFile(StaticContentType.Scripts, fileName, theme);
        }
        public static string ThemeStyle(string fileName, string theme)
        {
            return StaticFile(StaticContentType.Images, fileName, theme);
        }
        public static string ThemeImage(string fileName, string theme)
        {
            return StaticFile(StaticContentType.Images, fileName, theme);
        }
        #endregion

        public static string StaticFile(StaticContentType type, string fileName, string theme = "Base")
        {
            SiteTheme currentTheme;
            Enum.TryParse(theme, true, out currentTheme);
            var rootPath = currentTheme == SiteTheme.Base
                               ? EnvironmentHelper.GetEnvironmentValue("Urls", "CDNPath")
                               : EnvironmentHelper.GetEnvironmentValue("Urls", "CDNThemePath");

                return string.Format("{0}/{1}/{2}/{3}",
                                     rootPath, currentTheme, type,
                                     fileName);
          
        }

    }
}