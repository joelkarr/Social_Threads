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
    public partial class CartController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CartController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CartController(Dummy d) { }

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
        public System.Web.Mvc.ActionResult Add() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Add);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CartController Actions { get { return MVC.Cart; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Cart";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Cart";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Current = "Current";
            public readonly string Checkout = "Checkout";
            public readonly string Add = "Add";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Current = "Current";
            public const string Checkout = "Checkout";
            public const string Add = "Add";
        }


        static readonly ActionParamsClass_Add s_params_Add = new ActionParamsClass_Add();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Add AddParams { get { return s_params_Add; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Add {
            public readonly string item = "item";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Checkout = "~/Views/Cart/Checkout.cshtml";
            public readonly string Current = "~/Views/Cart/Current.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_CartController: SOC.Web.Controllers.CartController {
        public T4MVC_CartController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Current() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Current);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Checkout() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Checkout);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Add(SOC.Web.Models.ViewModels.Base.Partial.ItemViewModel item) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Add);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "item", item);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
