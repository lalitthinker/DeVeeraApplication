#pragma checksum "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8d1610b85ae44a5f6823432473097a58771299f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ExistingUser), @"mvc.1.0.view", @"/Views/Home/ExistingUser.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\_ViewImports.cshtml"
using DeVeeraApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\_ViewImports.cshtml"
using DeVeeraApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\_ViewImports.cshtml"
using DeVeeraApp.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\_ViewImports.cshtml"
using CRM.Core.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8d1610b85ae44a5f6823432473097a58771299f", @"/Views/Home/ExistingUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0171832334975a92c9258e3bd135b84983a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ExistingUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeVeeraApp.ViewModels.WeeklyUpdateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/css/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("intro-x btn py-3 px-4 text-white border-white dark:border-dark-5 dark:text-gray-300 mt-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
  
    ViewData["Title"] = "ExistingUser";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\" class=\"light\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8d1610b85ae44a5f6823432473097a58771299f6968", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <link href=""dist/images/logo.svg"" rel=""shortcut icon"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content=""Midone admin is super flexible, powerful, clean & modern responsive tailwind admin template with unlimited possibilities."">
    <meta name=""keywords"" content=""admin template, Midone admin template, dashboard template, flat admin template, responsive admin template, web app"">
    <meta name=""author"" content=""LEFT4CODE"">
    <title>Existing User</title>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8d1610b85ae44a5f6823432473097a58771299f7809", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8d1610b85ae44a5f6823432473097a58771299f9695", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"error-page flex flex-col lg:flex-row items-center justify-center h-screen text-center lg:text-left\">\r\n            <div class=\"-intro-x \">\r\n");
#nullable restore
#line 25 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"grid grid-cols-12 gap-6 mt-5\">\r\n                        <div class=\"intro-y col-span-12 lg:col-span-6\">\r\n");
#nullable restore
#line 29 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                              string src = Model.VideoUrl;

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <video");
                BeginWriteAttribute("src", " src=\"", 1302, "\"", 1325, 1);
#nullable restore
#line 31 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
WriteAttributeValue("", 1308, Url.Content(src), 1308, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" controls style=""width:100%; height:400px"" loop />
                        </div>
                        <div class=""intro-y col-span-12 lg:col-span-6"">
                            <div class=""text-white mt-10 lg:mt-0"">
                                <div class=""intro-x text-xl lg:text-3xl font-medium mt-5""> ");
#nullable restore
#line 35 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                                                                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n                                <div class=\"intro-x text-xl lg:text-3xl font-medium mt-5\">Let\'s continue </div>\r\n                                <div class=\"intro-x text-lg mt-3\">");
#nullable restore
#line 37 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                                                             Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 38 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                                 if (ViewBag.SrNo != 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8d1610b85ae44a5f6823432473097a58771299f12794", async() => {
                    WriteLiteral("Let\'s Start");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-srno", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                                                                                      WriteLiteral(ViewBag.SrNo);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["srno"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-srno", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["srno"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                                                                                                                   WriteLiteral(Model.LastLevel);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                                                                                                                                                                 WriteLiteral(ViewBag.LastLoginDateUtc);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lastLoginDateUtc"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lastLoginDateUtc", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lastLoginDateUtc"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8d1610b85ae44a5f6823432473097a58771299f17528", async() => {
                    WriteLiteral("Dashboard");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 52 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""intro-y col-span-12 lg:col-span-6"">
                        <div class=""text-white mt-10 lg:mt-0"">
                            <div class=""intro-x text-xl lg:text-3xl font-medium mt-5"">Sorry, There is no data. </div>
                        </div>
                    </div>
");
#nullable restore
#line 61 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\ExistingUser.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <script src=""https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/markerclusterer.js""></script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBG7gNHAhDzgYmq4-EHvM4bqW1DNj2UCuk&amp;libraries=places""></script>
    <script src=""dist/js/app.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CRM.Core.IWorkContext _workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeVeeraApp.ViewModels.WeeklyUpdateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
