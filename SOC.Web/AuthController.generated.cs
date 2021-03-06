// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace SOC.Web.Controllers {
    public partial class AuthController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AuthController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AuthController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Callback() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Callback);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AuthController Actions { get { return MVC.Auth; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Auth";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Auth";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string OpenId = "OpenId";
            public readonly string Facebook = "Facebook";
            public readonly string Google = "Google";
            public readonly string Yahoo = "Yahoo";
            public readonly string Twitter = "Twitter";
            public readonly string Callback = "Callback";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string OpenId = "OpenId";
            public const string Facebook = "Facebook";
            public const string Google = "Google";
            public const string Yahoo = "Yahoo";
            public const string Twitter = "Twitter";
            public const string Callback = "Callback";
        }


        static readonly ActionParamsClass_Callback s_params_Callback = new ActionParamsClass_Callback();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Callback CallbackParams { get { return s_params_Callback; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Callback {
            public readonly string type = "type";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_AuthController: SOC.Web.Controllers.AuthController {
        public T4MVC_AuthController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult OpenId() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.OpenId);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Facebook() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Facebook);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Google() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Google);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Yahoo() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Yahoo);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Twitter() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Twitter);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Callback(string type) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Callback);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "type", type);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
