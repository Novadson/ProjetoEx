#pragma checksum "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef447e88dfc301d94c90ec8aba6c8a73621ca80b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_UsuariosCadastrados), @"mvc.1.0.view", @"/Views/Usuario/UsuariosCadastrados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/UsuariosCadastrados.cshtml", typeof(AspNetCore.Views_Usuario_UsuariosCadastrados))]
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
#line 1 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\_ViewImports.cshtml"
using StockControl;

#line default
#line hidden
#line 2 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\_ViewImports.cshtml"
using StockControl.Models;

#line default
#line hidden
#line 3 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\_ViewImports.cshtml"
using StockControl.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef447e88dfc301d94c90ec8aba6c8a73621ca80b", @"/Views/Usuario/UsuariosCadastrados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066864515f9a1e0757d18e623d6527a5be8c8416", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_UsuariosCadastrados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right center-block btnNovoRegistro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootbox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
  
    ViewData["Title"] = "UsuariosCadastrados";

#line default
#line hidden
            BeginContext(52, 34, true);
            WriteLiteral("    <!--Autor:Novadson Thelus-->\r\n");
            EndContext();
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(114, 166, true);
            WriteLiteral("\r\n<div class=\"panel panel-default  col-lg-8  col-md-7 col-sm-7 col-xl divdlColor panelWidth\">\r\n    <div class=\"panel-heading\">\r\n        Usuários Cadastrados\r\n        ");
            EndContext();
            BeginContext(280, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7805d7fee2c9462c80cf1476081b2ecb", async() => {
                BeginContext(371, 77, true);
                WriteLiteral("\r\n            <i class=\"glyphicon glyphicon-plus\"></i>Novo registro\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 753, true);
            WriteLiteral(@"
        <br />
        <br />
        <div class=""form-group input-group"" style=""margin-bottom:-5px;"">
            <span class=""input-group-addon""><i class=""glyphicon glyphicon-search colorIconEditar""></i></span>
            <input id=""myInput"" placeholder=""Buscar usuário por nome"" type=""text"" class=""form-control"">
        </div>
    </div>
    <table id=""myTable"" class=""table table-bordered table-condensed table-responsive tablebgColor"">
        <thead class=""tabelaHeaderColor"">
            <tr>
                <td>Nome</td>
                <td>Email</td>
                <td>Contato</td>
                <td>Status</td>
                <td style=""text-align:center"" colspan=""3"">Ações</td>
            </tr>
        </thead>

");
            EndContext();
#line 32 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
         foreach (var usuario in Model)
        {

#line default
#line hidden
            BeginContext(1257, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1318, 38, false);
#line 36 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
               Write(Html.DisplayFor(model => usuario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1426, 39, false);
#line 40 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
               Write(Html.DisplayFor(model => usuario.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1533, 41, false);
#line 43 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
               Write(Html.DisplayFor(model => usuario.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 27, true);
            WriteLiteral("\r\n                </td>\r\n\r\n");
            EndContext();
#line 46 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
                 if (usuario.Status.Equals(true))
                {

#line default
#line hidden
            BeginContext(1671, 171, true);
            WriteLiteral("                    <td>\r\n                        <div class=\"statusAtivo\">\r\n                            Ativo\r\n                        </div>\r\n                    </td>\r\n");
            EndContext();
#line 53 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1902, 175, true);
            WriteLiteral("                    <td>\r\n                        <div class=\"statusInativo\">\r\n                            Inativo\r\n                        </div>\r\n                    </td>\r\n");
            EndContext();
#line 61 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
                }

#line default
#line hidden
            BeginContext(2096, 61, true);
            WriteLiteral("\r\n                <td>\r\n                    <a title=\"Editar\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2157, "\"", 2214, 1);
#line 64 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
WriteAttributeValue("", 2164, Url.Action("EditarUsuario",new { id =usuario.Id}), 2164, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2215, 149, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-edit colorIconEditar\"></i></a>\r\n                </td>\r\n\r\n                <td>\r\n                    <a title=\"Detalhes\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2364, "\"", 2425, 1);
#line 68 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
WriteAttributeValue("", 2371, Url.Action("DetalhesDoUsuario",new { id =usuario.Id}), 2371, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2426, 155, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-info-sign colorIconEditar\"></i></a>\r\n                </td>\r\n\r\n                <td>\r\n\r\n                    <a title=\"Excluir\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2581, "\"", 2639, 1);
#line 73 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
WriteAttributeValue("", 2588, Url.Action("ExcluirUsuario",new { id =usuario.Id}), 2588, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2640, 108, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash  MyLink colorIcon\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 76 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
        }

#line default
#line hidden
            BeginContext(2759, 26, true);
            WriteLiteral("    </table>\r\n    <br />\r\n");
            EndContext();
#line 79 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
     if (Model.Count().Equals(0))
    {

#line default
#line hidden
            BeginContext(2827, 97, true);
            WriteLiteral("        <span class=\"msmEmptyTable\">\r\n            Não há Usuário cadastrado...\r\n        </span>\r\n");
            EndContext();
#line 84 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\UsuariosCadastrados.cshtml"
    }

#line default
#line hidden
            BeginContext(2931, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2958, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2964, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3a7c9929dd442328f0d7f1184851019", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3007, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3012, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
