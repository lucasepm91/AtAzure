#pragma checksum "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d95c72fc44335f403e2a6e535f59c98bec7f05b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pais_Details), @"mvc.1.0.view", @"/Views/Pais/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pais/Details.cshtml", typeof(AspNetCore.Views_Pais_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d95c72fc44335f403e2a6e535f59c98bec7f05b", @"/Views/Pais/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07757e7ca231959950e2e98f2d7c188f0c59bc58", @"/Views/_ViewImports.cshtml")]
    public class Views_Pais_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<At_Azure.Models.Pais>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
  
    ViewData["Title"] = "Detais";

#line default
#line hidden
            BeginContext(73, 67, true);
            WriteLiteral("\r\n<h2>Detais</h2>\r\n\r\n<div>\r\n    <h4>Pais</h4>\r\n    <br />\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 140, "", 186, 1);
#line 12 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
WriteAttributeValue("", 145, Html.DisplayFor(model => model.Bandeira), 145, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(186, 120, true);
            WriteLiteral(" />\r\n    <hr />\r\n    <br />\r\n    <dl class=\"dl-horizontal\">        \r\n        <dt style=\"text-align:left;\">\r\n            ");
            EndContext();
            BeginContext(307, 40, false);
#line 17 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(347, 44, true);
            WriteLiteral(":\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(392, 36, false);
#line 20 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(428, 36, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
            EndContext();
#line 24 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
 if (@ViewBag.Estados != null)
{

#line default
#line hidden
            BeginContext(499, 23, true);
            WriteLiteral("    <h4>Estados:</h4>\r\n");
            EndContext();
            BeginContext(524, 318, true);
            WriteLiteral(@"    <table class=""table table-hover table-striped table-responsive"">
        <thead>
            <tr>
                <th>
                    Nome
                </th>                
                <th>
                    Ações
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 40 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
             foreach (Estado estado in @ViewBag.Estados)
            {

#line default
#line hidden
            BeginContext(915, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(988, 38, false);
#line 44 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
                   Write(Html.DisplayFor(Estado => estado.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 123, true);
            WriteLiteral("\r\n                    </td>                    \r\n                    <td>                        \r\n                        ");
            EndContext();
            BeginContext(1150, 73, false);
#line 47 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
                   Write(Html.ActionLink("Detalhes", "details", "estado", new { estado.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 50 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1290, 51, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1342, 61, false);
#line 54 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
   Write(Html.ActionLink("Editar país", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1403, 20, true);
            WriteLiteral(" |        \r\n        ");
            EndContext();
            BeginContext(1424, 75, false);
#line 55 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
   Write(Html.ActionLink("Voltar para lista de países", "index", "pais", null, null));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 57 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1525, 164, true);
            WriteLiteral("    <div>\r\n        <div>\r\n            <p>\r\n                Nenhum estado cadastrado para este país.\r\n            </p>            \r\n            <p>\r\n                ");
            EndContext();
            BeginContext(1690, 75, false);
#line 66 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
           Write(Html.ActionLink("Voltar para lista de países", "index", "pais", null, null));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 48, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 70 "C:\Users\lucas.pmartins\source\repos\At_Azure\At_Azure\Views\Pais\Details.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<At_Azure.Models.Pais> Html { get; private set; }
    }
}
#pragma warning restore 1591
