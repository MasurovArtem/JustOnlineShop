#pragma checksum "C:\Users\MaZuR\source\repos\JustOnlineShop\JustOnlineShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e83ff84a26a72273248b110dd3b75ff10e6ab3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MaZuR\source\repos\JustOnlineShop\JustOnlineShop\Views\_ViewImports.cshtml"
using JustOnlineShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MaZuR\source\repos\JustOnlineShop\JustOnlineShop\Views\_ViewImports.cshtml"
using JustOnlineShop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e83ff84a26a72273248b110dd3b75ff10e6ab3c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3349f8e2cbbdddf3d9c0e8942e2631b407bf6b13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MaZuR\source\repos\JustOnlineShop\JustOnlineShop\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Preferred items of the week</h2>\r\n<hr/>\r\n\r\n<div class=\"row marginTop float-left\">\r\n");
#nullable restore
#line 9 "C:\Users\MaZuR\source\repos\JustOnlineShop\JustOnlineShop\Views\Home\Index.cshtml"
     foreach (var item in Model.PreferredItems)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MaZuR\source\repos\JustOnlineShop\JustOnlineShop\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("ItemSummary", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MaZuR\source\repos\JustOnlineShop\JustOnlineShop\Views\Home\Index.cshtml"
                                                     ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
