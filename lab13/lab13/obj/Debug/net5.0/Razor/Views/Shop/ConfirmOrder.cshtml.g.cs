#pragma checksum "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d6959e7d316ab18dc724b4c4f520da97409b44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ConfirmOrder), @"mvc.1.0.view", @"/Views/Shop/ConfirmOrder.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\_ViewImports.cshtml"
using lab13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\_ViewImports.cshtml"
using lab13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d6959e7d316ab18dc724b4c4f520da97409b44", @"/Views/Shop/ConfirmOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc51a650a05aa2db8ba265ba455884a0fbfd156", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_ConfirmOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lab13.ViewModels.OrderViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
  
    ViewData["Title"] = "ConfirmOrder";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ConfirmOrder</h1>\r\n\r\n<div>\r\n    <h4>OrderViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.Payment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
       Write(Html.DisplayFor(model => model.Payment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"text-align: center\">\r\n                ");
#nullable restore
#line 62 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Items.First().Article.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Items.First().Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"text-align: right\">\r\n                ");
#nullable restore
#line 68 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Items.First().Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Items.First().Article.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th style=\"text-align: right\">\r\n                ");
#nullable restore
#line 75 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Items.First().Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 83 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"text-align: center\">\r\n                    <img class=\"img-thumbnail my-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 2644, "\"", 2699, 1);
#nullable restore
#line 87 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
WriteAttributeValue("", 2650, Html.DisplayFor(modelItem => item.Article.Image), 2650, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
               Write(Html.DisplayFor(modelItem => item.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: right\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
               Write(Html.DisplayFor(modelItem => item.Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
               Write(Html.DisplayFor(modelItem => item.Article.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                </td>\r\n                <td style=\"text-align: center\">\r\n                    ");
#nullable restore
#line 101 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 104 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"row\">\r\n    <h3 style=\"text-align: right; margin: 0 45px\">Total: ");
#nullable restore
#line 108 "C:\Users\Lenovo\source\repos\lab13\lab13\Views\Shop\ConfirmOrder.cshtml"
                                                    Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12d6959e7d316ab18dc724b4c4f520da97409b4412877", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lab13.ViewModels.OrderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
