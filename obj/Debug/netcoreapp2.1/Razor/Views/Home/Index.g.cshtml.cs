#pragma checksum "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7a6e887a1dda4ee5b7c0cf12531d64c9f1695a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\brovk\source\repos\API_Notification\Views\_ViewImports.cshtml"
using API_Notification;

#line default
#line hidden
#line 2 "C:\Users\brovk\source\repos\API_Notification\Views\_ViewImports.cshtml"
using API_Notification.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7a6e887a1dda4ee5b7c0cf12531d64c9f1695a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0937746a505d034bf655bcb9b77770529a62344e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<API_Notification.Models.Notification>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(103, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(113, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e8f90eb5674750a9e6c20bd24bdbbd", async() => {
                BeginContext(119, 34, true);
                WriteLiteral("\r\n    <title>Напоминашки</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(162, 714, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b962d9d750184ec5861ab096b384fbca", async() => {
                BeginContext(168, 266, true);
                WriteLiteral(@"
    <h3>Напоминания</h3>
    <table>
        <tr>
            <td>Id</td>
            <td>Name</td>
            <td>Text</td>
            <td>Date</td>
            <td>State</td>
            <td>PhoneNumber</td>
            <td>Email</td>
        </tr>
");
                EndContext();
#line 22 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
         foreach (var not in Model)
        {

#line default
#line hidden
                BeginContext(482, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(521, 6, false);
#line 25 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
               Write(not.Id);

#line default
#line hidden
                EndContext();
                BeginContext(527, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(555, 8, false);
#line 26 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
               Write(not.Name);

#line default
#line hidden
                EndContext();
                BeginContext(563, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(591, 8, false);
#line 27 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
               Write(not.Text);

#line default
#line hidden
                EndContext();
                BeginContext(599, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(627, 8, false);
#line 28 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
               Write(not.Date);

#line default
#line hidden
                EndContext();
                BeginContext(635, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(663, 9, false);
#line 29 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
               Write(not.State);

#line default
#line hidden
                EndContext();
                BeginContext(672, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(700, 15, false);
#line 30 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
               Write(not.PhoneNumber);

#line default
#line hidden
                EndContext();
                BeginContext(715, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(743, 9, false);
#line 31 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
               Write(not.Email);

#line default
#line hidden
                EndContext();
                BeginContext(752, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(779, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "565c1bd83dc04116831145d070867458", async() => {
                    BeginContext(808, 6, true);
                    WriteLiteral("Купить");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 788, "~/Home/Buy/", 788, 11, true);
#line 32 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 799, not.Id, 799, 7, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(818, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 34 "C:\Users\brovk\source\repos\API_Notification\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(855, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(876, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<API_Notification.Models.Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
