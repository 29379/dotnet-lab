#pragma checksum "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46fc62e83387de8994c28415703198ca04830f4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Guess), @"mvc.1.0.view", @"/Views/Game/Guess.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\_ViewImports.cshtml"
using lab8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\_ViewImports.cshtml"
using lab8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46fc62e83387de8994c28415703198ca04830f4e", @"/Views/Game/Guess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8215e48a0267769b9caf1261e5acbe3b8aba765d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Game_Guess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
  
    ViewData["Title"] = "Guess";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46fc62e83387de8994c28415703198ca04830f4e3239", async() => {
                WriteLiteral("\r\n    <h3>255356 - My guessing game</h3>\r\n    <p>Round: ");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
         Write(ViewBag.round);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>History:</p>\r\n    <ul id=\"history\">\r\n");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
         foreach (var prev in ViewBag.gameHistory)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li> <p>");
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
               Write(prev);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> </li>\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n    <p");
                BeginWriteAttribute("class", " class=\"", 318, "\"", 338, 1);
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
WriteAttributeValue("", 326, ViewBag.cls, 326, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Result: ");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
                               Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\lab8\lab8\Views\Game\Guess.cshtml"
AddHtmlAttributeValue("", 55, ViewBag.cls, 55, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591