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
    public partial class DesignerController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DesignerController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected DesignerController(Dummy d) { }

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
        public System.Web.Mvc.JsonResult GetGraphicsFromGroup() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.GetGraphicsFromGroup);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult GetGraphcisFromKeyword() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.GetGraphcisFromKeyword);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult GetAutoCompleteKeywords() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.GetAutoCompleteKeywords);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult GetColorOptionsFromProductId() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.GetColorOptionsFromProductId);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult GetAvailableSizesFromProductId() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.GetAvailableSizesFromProductId);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult GetFontsFromGroup() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.GetFontsFromGroup);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult GetFontsFromKeyword() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.GetFontsFromKeyword);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DesignerController Actions { get { return MVC.Designer; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Designer";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Designer";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Studio = "Studio";
            public readonly string GetGraphicsFromGroup = "GetGraphicsFromGroup";
            public readonly string GetGraphcisFromKeyword = "GetGraphcisFromKeyword";
            public readonly string GetAutoCompleteKeywords = "GetAutoCompleteKeywords";
            public readonly string GetColorOptionsFromProductId = "GetColorOptionsFromProductId";
            public readonly string GetAvailableSizesFromProductId = "GetAvailableSizesFromProductId";
            public readonly string GetPrintersAvailableInkColors = "GetPrintersAvailableInkColors";
            public readonly string GetFontsFromGroup = "GetFontsFromGroup";
            public readonly string GetFontsFromKeyword = "GetFontsFromKeyword";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Studio = "Studio";
            public const string GetGraphicsFromGroup = "GetGraphicsFromGroup";
            public const string GetGraphcisFromKeyword = "GetGraphcisFromKeyword";
            public const string GetAutoCompleteKeywords = "GetAutoCompleteKeywords";
            public const string GetColorOptionsFromProductId = "GetColorOptionsFromProductId";
            public const string GetAvailableSizesFromProductId = "GetAvailableSizesFromProductId";
            public const string GetPrintersAvailableInkColors = "GetPrintersAvailableInkColors";
            public const string GetFontsFromGroup = "GetFontsFromGroup";
            public const string GetFontsFromKeyword = "GetFontsFromKeyword";
        }


        static readonly ActionParamsClass_GetGraphicsFromGroup s_params_GetGraphicsFromGroup = new ActionParamsClass_GetGraphicsFromGroup();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetGraphicsFromGroup GetGraphicsFromGroupParams { get { return s_params_GetGraphicsFromGroup; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetGraphicsFromGroup {
            public readonly string groupId = "groupId";
        }
        static readonly ActionParamsClass_GetGraphcisFromKeyword s_params_GetGraphcisFromKeyword = new ActionParamsClass_GetGraphcisFromKeyword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetGraphcisFromKeyword GetGraphcisFromKeywordParams { get { return s_params_GetGraphcisFromKeyword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetGraphcisFromKeyword {
            public readonly string keyword = "keyword";
        }
        static readonly ActionParamsClass_GetAutoCompleteKeywords s_params_GetAutoCompleteKeywords = new ActionParamsClass_GetAutoCompleteKeywords();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetAutoCompleteKeywords GetAutoCompleteKeywordsParams { get { return s_params_GetAutoCompleteKeywords; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetAutoCompleteKeywords {
            public readonly string input = "input";
        }
        static readonly ActionParamsClass_GetColorOptionsFromProductId s_params_GetColorOptionsFromProductId = new ActionParamsClass_GetColorOptionsFromProductId();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetColorOptionsFromProductId GetColorOptionsFromProductIdParams { get { return s_params_GetColorOptionsFromProductId; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetColorOptionsFromProductId {
            public readonly string productId = "productId";
        }
        static readonly ActionParamsClass_GetAvailableSizesFromProductId s_params_GetAvailableSizesFromProductId = new ActionParamsClass_GetAvailableSizesFromProductId();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetAvailableSizesFromProductId GetAvailableSizesFromProductIdParams { get { return s_params_GetAvailableSizesFromProductId; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetAvailableSizesFromProductId {
            public readonly string productId = "productId";
        }
        static readonly ActionParamsClass_GetFontsFromGroup s_params_GetFontsFromGroup = new ActionParamsClass_GetFontsFromGroup();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetFontsFromGroup GetFontsFromGroupParams { get { return s_params_GetFontsFromGroup; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetFontsFromGroup {
            public readonly string groupId = "groupId";
        }
        static readonly ActionParamsClass_GetFontsFromKeyword s_params_GetFontsFromKeyword = new ActionParamsClass_GetFontsFromKeyword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetFontsFromKeyword GetFontsFromKeywordParams { get { return s_params_GetFontsFromKeyword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetFontsFromKeyword {
            public readonly string keyword = "keyword";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_DesignerController: SOC.Web.Controllers.DesignerController {
        public T4MVC_DesignerController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Studio() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Studio);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetGraphicsFromGroup(int groupId) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetGraphicsFromGroup);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "groupId", groupId);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetGraphcisFromKeyword(string keyword) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetGraphcisFromKeyword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "keyword", keyword);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetAutoCompleteKeywords(string input) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetAutoCompleteKeywords);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "input", input);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetColorOptionsFromProductId(int productId) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetColorOptionsFromProductId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "productId", productId);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetAvailableSizesFromProductId(int productId) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetAvailableSizesFromProductId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "productId", productId);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetPrintersAvailableInkColors() {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetPrintersAvailableInkColors);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetFontsFromGroup(int groupId) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetFontsFromGroup);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "groupId", groupId);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetFontsFromKeyword(string keyword) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetFontsFromKeyword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "keyword", keyword);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
