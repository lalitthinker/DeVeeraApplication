#pragma checksum "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "972fe374b25190cc82e01e2990e7ee114b65b4d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardQuote_Index), @"mvc.1.0.view", @"/Views/DashboardQuote/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972fe374b25190cc82e01e2990e7ee114b65b4d4", @"/Views/DashboardQuote/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0171832334975a92c9258e3bd135b84983a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardQuote_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\DashboardQuote\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""px-5 mt-10"">
    <div class=""font-medium text-center text-lg"">Feel-Good-Stories</div>
    <div class=""text-gray-600 text-center mt-2"">Below are the list of stories</div>

</div>
<div class=""p-5"" id=""basic-table"">
    <div class=""preview"">
        <div class=""overflow-x-auto"">
            <div class=""intro-y box"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th class=""border-b-2 dark:border-dark-5 whitespace-nowrap"">#</th>
                            <th class=""border-b-2 dark:border-dark-5 whitespace-nowrap"">Title</th>
                            <th class=""border-b-2 dark:border-dark-5 whitespace-nowrap"">Story</th>
                            <th class=""border-b-2 dark:border-dark-5 whitespace-nowrap"">Author</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class=""border-b dark:border-dark-5"">1</");
            WriteLiteral(@"td>
                            <td class=""border-b dark:border-dark-5"">Angelina</td>
                            <td class=""border-b dark:border-dark-5"">Jolie</td>
                            <td class=""border-b dark:border-dark-5"">angelinajolie</td>
                        </tr>
                        <tr>
                            <td class=""border-b dark:border-dark-5"">2</td>
                            <td class=""border-b dark:border-dark-5"">Brad</td>
                            <td class=""border-b dark:border-dark-5"">Pitt</td>
                            <td class=""border-b dark:border-dark-5"">bradpitt</td>
                        </tr>
                        <tr>
                            <td class=""border-b dark:border-dark-5"">3</td>
                            <td class=""border-b dark:border-dark-5"">Charlie</td>
                            <td class=""border-b dark:border-dark-5"">Hunnam</td>
                            <td class=""border-b dark:border-dark-5"">charliehunnam</td>
  ");
            WriteLiteral("                      </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591