#pragma checksum "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2465b5df9a21e068a8fedb6e650d4d55460bd174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Szczegoly), @"mvc.1.0.view", @"/Views/Home/Szczegoly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Szczegoly.cshtml", typeof(AspNetCore.Views_Home_Szczegoly))]
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
#line 2 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\_ViewImports.cshtml"
using Komis.Models;

#line default
#line hidden
#line 3 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\_ViewImports.cshtml"
using Komis.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2465b5df9a21e068a8fedb6e650d4d55460bd174", @"/Views/Home/Szczegoly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069efed5a9c7a03732d81c214679573ccaef1387", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Szczegoly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Samochod>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Szczegoly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(17, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(24, 11, false);
#line 3 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
Write(Model.Marka);

#line default
#line hidden
            EndContext();
            BeginContext(35, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(39, 11, false);
#line 3 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
              Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(50, 40, true);
            WriteLiteral("</h2>\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 90, "\"", 108, 1);
#line 5 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
WriteAttributeValue("", 96, Model.Marka, 96, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 109, "\"", 132, 1);
#line 5 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
WriteAttributeValue("", 115, Model.ZdjecieUrl, 115, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(133, 69, true);
            WriteLiteral(" />\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\"> ");
            EndContext();
            BeginContext(203, 24, false);
#line 7 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
                           Write(Model.Cena.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(227, 33, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            ");
            EndContext();
            BeginContext(260, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718ccbd99c8d4814989234af0783d3f1", async() => {
                BeginContext(334, 11, false);
#line 9 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
                                                                                Write(Model.Marka);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
                                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(349, 2, true);
            WriteLiteral(" -");
            EndContext();
            BeginContext(352, 11, false);
#line 9 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
                                                                                                  Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(363, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(367, 18, false);
#line 9 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
                                                                                                                 Write(Model.RokProdukcji);

#line default
#line hidden
            EndContext();
            BeginContext(385, 29, true);
            WriteLiteral("\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(415, 18, false);
#line 11 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
       Write(Model.RokProdukcji);

#line default
#line hidden
            EndContext();
            BeginContext(433, 19, true);
            WriteLiteral("</h4>\r\n        <h4>");
            EndContext();
            BeginContext(453, 14, false);
#line 12 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
       Write(Model.Przebieg);

#line default
#line hidden
            EndContext();
            BeginContext(467, 19, true);
            WriteLiteral("</h4>\r\n        <h4>");
            EndContext();
            BeginContext(487, 5, false);
#line 13 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
       Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(492, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(511, 10, false);
#line 14 "C:\Users\Len\Desktop\ASP.Net Core\Komis\Views\Home\Szczegoly.cshtml"
      Write(Model.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(521, 26, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Samochod> Html { get; private set; }
    }
}
#pragma warning restore 1591
