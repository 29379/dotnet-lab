#pragma checksum "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d02a842def7d48651eec305380a5e64bdcf286fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_IndexList), @"mvc.1.0.view", @"/Views/Shop/IndexList.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\_ViewImports.cshtml"
using lab10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\_ViewImports.cshtml"
using lab10.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d02a842def7d48651eec305380a5e64bdcf286fd", @"/Views/Shop/IndexList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881a211080d561204938f710ff642dc021a1d8a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_IndexList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<lab10.Models.Article>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
  
    ViewData["Title"] = "IndexList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>IndexList</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
Write(ViewBag.myCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img class=\"img-thumbnail my-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 816, "\"", 863, 1);
#nullable restore
#line 36 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
WriteAttributeValue("", 822, Html.DisplayFor(modelItem => item.Image), 822, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Lenovo\source\repos\lab10\lab10\Views\Shop\IndexList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<lab10.Models.Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591