#pragma checksum "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0da3d683990ef0a48acfacad578897d1035a6d54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FeelGoodStories), @"mvc.1.0.view", @"/Views/Home/FeelGoodStories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0da3d683990ef0a48acfacad578897d1035a6d54", @"/Views/Home/FeelGoodStories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0171832334975a92c9258e3bd135b84983a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FeelGoodStories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<DeVeeraApp.ViewModels.FeelGoodStoryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
  
    ViewData["Title"] = "Feel Good Stories";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""intro-y flex flex-col sm:flex-row items-center mt-8"">
    <h2 class=""text-lg font-medium mr-auto"">
        Feel Good Stories
    </h2>
</div>
<div class=""border-t border-theme-25"">

    <div class=""intro-y grid grid-cols-12 gap-6 mt-5"">

");
#nullable restore
#line 17 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
         if (Model.Count != 0)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- BEGIN: Blog Layout -->\r\n                <div class=\"intro-y blog col-span-12 md:col-span-6 box\">\r\n                    <div class=\"blog__preview image-fit\">\r\n");
#nullable restore
#line 25 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
                          var smallImg = (item.Image?.ImageUrl == null) ? "/dist/images/profile-14.jpg" : item.Image.ImageUrl;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"rounded-t-md\"");
            BeginWriteAttribute("src", " src=\"", 832, "\"", 847, 1);
#nullable restore
#line 26 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
WriteAttributeValue("", 838, smallImg, 838, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"absolute w-full flex items-center px-5 pt-6 z-10\">\r\n                            <div class=\"w-10 h-10 flex-none image-fit\">\r\n");
#nullable restore
#line 29 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
                                  var largeImg = (item.Image?.ImageUrl == null) ? "/dist/images/preview-4.jpg" : item.Image.ImageUrl;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img class=\"rounded-full\"");
            BeginWriteAttribute("src", " src=\"", 1205, "\"", 1220, 1);
#nullable restore
#line 30 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
WriteAttributeValue("", 1211, largeImg, 1211, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"ml-3 text-white mr-auto\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1361, "\"", 1368, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"font-medium\">");
#nullable restore
#line 33 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
                                                          Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                <div class=""text-xs mt-0.5"">29 minutes ago</div>
                            </div>

                        </div>
                        <div class=""absolute bottom-0 text-white px-5 pb-6 z-10"">

                            <a");
            BeginWriteAttribute("href", " href=\"", 1675, "\"", 1682, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"block font-medium text-xl mt-3\">");
#nullable restore
#line 40 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"p-5 text-gray-700 dark:text-gray-600\">");
#nullable restore
#line 43 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
                                                                 Write(Html.Raw(item.Story));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
             


        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-lg font-medium mr-auto\">\r\n                There are no stories yet.\r\n            </h2>\r\n");
#nullable restore
#line 55 "C:\Users\lalit\OneDrive\Documents\github\DeVeeraApplication\DeVeeraApp\Views\Home\FeelGoodStories.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<DeVeeraApp.ViewModels.FeelGoodStoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
