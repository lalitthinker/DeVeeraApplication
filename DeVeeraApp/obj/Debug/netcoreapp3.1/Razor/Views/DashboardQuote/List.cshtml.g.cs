#pragma checksum "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f93ebe8a64c9046fd852e0e0fc07b387b72ba65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardQuote_List), @"mvc.1.0.view", @"/Views/DashboardQuote/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f93ebe8a64c9046fd852e0e0fc07b387b72ba65", @"/Views/DashboardQuote/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0171832334975a92c9258e3bd135b84983a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardQuote_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DeVeeraApp.ViewModels.DashboardQuoteModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DashboardQuote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary w-40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SampleExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-theme-21 w-40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/js/Quote.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/js/CustomJs/Delete.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\List.cshtml"
 if (@ViewBag.QuoteTable != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""intro-y  py-5 sm:py-5 "">

        <div class=""px-5 "">
            <div class=""font-medium text-center text-lg"">Quote List</div>
            <div class=""text-gray-600 text-center mt-2"">Below are the list of Quotes</div>

        </div>

        <div class="" border-t border-gray-200 dark:border-dark-5"">
            <div class=""intro-y col-span-12 mt-6"">
                <div class=""intro-y col-span-12 flex items-center justify-center sm:justify-end "">
                    <div class=""grid grid-cols-12 gap-4 gap-y-5 "">
                        <div class=""intro-y col-span-6 sm:col-span-12  text-right"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f93ebe8a64c9046fd852e0e0fc07b387b72ba657462", async() => {
                WriteLiteral("<i data-feather=\"file-plus\" class=\"mr-2\"></i>Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                        <div class=""intro-y col-span-6 sm:col-span-12 pr-5 text-right"">
                            <a data-toggle=""modal"" data-target=""#ImportExcel"" class=""btn btn-primary w-40""><i data-feather=""file-plus"" class=""mr-2""></i>Import Excel</a>

                        </div>

                    </div>
                </div>
            </div>
            <!-- BEGIN: HTML Table Data -->

");
            WriteLiteral("\r\n            <div class=\"intro-y box p-5 mt-6\">\r\n                <div class=\"overflow-x-auto scrollbar-hidden\">\r\n                    <input id=\"QuoteTable\"");
            BeginWriteAttribute("value", " value=\"", 2035, "\"", 2062, 1);
#nullable restore
#line 47 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\List.cshtml"
WriteAttributeValue("", 2043, ViewBag.QuoteTable, 2043, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n                    <div id=\"tabulator1\"></div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\List.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"intro-y  py-10 sm:py-20 \">\r\n        <div class=\"px-5 \">\r\n            <div class=\"font-medium text-center text-lg\"> There is no data to show</div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- BEGIN: Modal Content -->
<div id=""ImportExcel"" class=""modal"" tabindex=""-1"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <!-- BEGIN: Modal Header -->
            <div class=""modal-header grid grid-cols-12"">

                <div class=""col-span-6 sm:col-span-6"">
                    <h2 class=""font-medium text-base mr-auto"">
                        Import
                    </h2>
                </div>
                <div class=""col-span-6 sm:col-span-6 text-right"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f93ebe8a64c9046fd852e0e0fc07b387b72ba6511408", async() => {
                WriteLiteral("<u>Download Sample File</u>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral(@"
                </div>
            </div>

            <!-- END: Modal Header -->
            <!-- BEGIN: Modal Body -->
            <div class=""modal-body grid grid-cols-12 gap-4 gap-y-3"">
                <div class=""col-span-12 sm:col-span-12"">
");
            WriteLiteral(@"                    <div id=""single-file-upload"" class=""p-5"">
                        <div class=""preview"">
                            <div data-single=""true"" fallback=""true"" action=""/DashboardQuote/UploadExcel"" class=""dropzone"" id=""dropzoneExcel"">
                                <div class=""fallback"">

                                </div>
                                <div class=""dz-message"" data-dz-message>
                                    <div class=""text-lg font-medium"">Drop files here or click to upload.</div>
                                    <div class=""text-gray-600""> This is just a demo dropzone. Selected files are <span class=""font-medium"">not</span> actually uploaded. </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- END: Modal Body -->
            <!-- BEGIN: Modal Footer -->
            <div class=""modal-footer text-right"">");
            WriteLiteral("\n");
            WriteLiteral(@"                <button type=""submit"" class=""btn btn-primary w-20"" onclick=""ImportExcel();"">Import</button>
            </div>
            <!-- END: Modal Footer -->
        </div>
    </div>
</div>
<!-- END: Modal Content -->
<script src=""../../lib/jquery/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://unpkg.com/tabulator-tables/dist/js/tabulator.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f93ebe8a64c9046fd852e0e0fc07b387b72ba6514690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f93ebe8a64c9046fd852e0e0fc07b387b72ba6515730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DeVeeraApp.ViewModels.DashboardQuoteModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
