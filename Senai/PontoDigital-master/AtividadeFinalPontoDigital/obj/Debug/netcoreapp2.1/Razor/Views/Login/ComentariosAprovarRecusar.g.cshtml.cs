#pragma checksum "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "663cfe983566a82697e2beb4b0b0984a2445386d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_ComentariosAprovarRecusar), @"mvc.1.0.view", @"/Views/Login/ComentariosAprovarRecusar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/ComentariosAprovarRecusar.cshtml", typeof(AspNetCore.Views_Login_ComentariosAprovarRecusar))]
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
#line 1 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
using AtividadeFinalPontoDigital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663cfe983566a82697e2beb4b0b0984a2445386d", @"/Views/Login/ComentariosAprovarRecusar.cshtml")]
    public class Views_Login_ComentariosAprovarRecusar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 210, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\r\n");
            EndContext();
            BeginContext(253, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "261c8d4036ce4cda88717c7086633a31", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(315, 12, true);
            WriteLiteral("\r\n<header>\r\n");
            EndContext();
#line 5 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
      
        Html.RenderPartial("_HeadNavBarLoggedAdmin");
    

#line default
#line hidden
            BeginContext(397, 378, true);
            WriteLiteral(@"</header>
<input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Procurar por palavra-chave"">
<table id=""myTable"">
  <tr class=""header"">
    <th style=""width:5%"">ID</th>
    <th style=""width:5%;"">Nome</th>
    <th style=""width:5%;"">Comentário</th>
    <th style=""width:5%"">Aprovar</th>
    <th style=""width:5%"">Recusar</th>
  </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 20 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
     foreach (var item in ViewData["comentarios"] as List<ComentarioModel>)
    {

#line default
#line hidden
            BeginContext(859, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(890, 7, false);
#line 23 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(897, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(921, 9, false);
#line 24 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(930, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(954, 15, false);
#line 25 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
           Write(item.Comentario);

#line default
#line hidden
            EndContext();
            BeginContext(969, 91, true);
            WriteLiteral("</td>\r\n            <td><button name=\"aprovar\" class=\"button1\" type=\"submit\" value=\"Aprovar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1060, "\"", 1146, 3);
            WriteAttributeValue("", 1070, "window.location=\'http://localhost:5000/Login/AprovarComentario?id=", 1070, 66, true);
#line 26 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
WriteAttributeValue("", 1136, item.ID, 1136, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1144, "\';", 1144, 2, true);
            EndWriteAttribute();
            BeginContext(1147, 108, true);
            WriteLiteral(">Aprovar</button></td>\r\n            <td><button name=\"recusar\" class=\"button2\" type=\"submit\" value=\"Recusar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1255, "\"", 1346, 3);
            WriteAttributeValue("", 1265, "window.location=\'http://localhost:5000/Login/ComentariosAprovarRecusar?", 1265, 71, true);
#line 27 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
WriteAttributeValue("", 1336, item.ID, 1336, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1344, "\';", 1344, 2, true);
            EndWriteAttribute();
            BeginContext(1347, 39, true);
            WriteLiteral(">Recusar</button></td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\victo\Desktop\Senai\PontoDigital-master\AtividadeFinalPontoDigital\Views\Login\ComentariosAprovarRecusar.cshtml"
    }

#line default
#line hidden
            BeginContext(1393, 20, true);
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
