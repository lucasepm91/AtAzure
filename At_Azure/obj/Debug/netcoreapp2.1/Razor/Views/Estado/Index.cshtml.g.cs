#pragma checksum "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa467415bba330d969bdb722ae8f9295fe84462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estado_Index), @"mvc.1.0.view", @"/Views/Estado/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estado/Index.cshtml", typeof(AspNetCore.Views_Estado_Index))]
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
#line 1 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\_ViewImports.cshtml"
using At_Azure;

#line default
#line hidden
#line 2 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\_ViewImports.cshtml"
using At_Azure.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa467415bba330d969bdb722ae8f9295fe84462", @"/Views/Estado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07757e7ca231959950e2e98f2d7c188f0c59bc58", @"/Views/_ViewImports.cshtml")]
    public class Views_Estado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<At_Azure.Models.Estado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(116, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "720fd9b57c0941878d90018cf7285a4d", async() => {
                BeginContext(139, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(153, 104, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 40, false);
#line 16 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(298, 69, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(368, 40, false);
#line 20 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(408, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(526, 60, true);
            WriteLiteral("        <tr>            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(587, 39, false);
#line 29 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(626, 67, true);
            WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(694, 39, false);
#line 32 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(733, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(789, 51, false);
#line 35 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(840, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(861, 57, false);
#line 36 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(918, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(939, 55, false);
#line 37 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(994, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Estado\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1033, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<At_Azure.Models.Estado>> Html { get; private set; }
    }
}
#pragma warning restore 1591