#pragma checksum "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f5dbbcfbf105d203655414f31a6002332215dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastros_ProdutosCadastrados), @"mvc.1.0.view", @"/Views/Cadastros/ProdutosCadastrados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastros/ProdutosCadastrados.cshtml", typeof(AspNetCore.Views_Cadastros_ProdutosCadastrados))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f5dbbcfbf105d203655414f31a6002332215dd", @"/Views/Cadastros/ProdutosCadastrados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066864515f9a1e0757d18e623d6527a5be8c8416", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastros_ProdutosCadastrados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right center-block btnNovoRegistro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
  
    ViewData["Title"] = "ProdutosCadastrados";

#line default
#line hidden
            BeginContext(54, 34, true);
            WriteLiteral("    <!--Autor:Novadson Thelus-->\r\n");
            EndContext();
            BeginContext(114, 166, true);
            WriteLiteral("\r\n<div class=\"panel panel-default  col-lg-8  col-md-7 col-sm-7 col-xl divdlColor panelWidth\">\r\n    <div class=\"panel-heading\">\r\n        Produtos Cadastrados\r\n        ");
            EndContext();
            BeginContext(280, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90f6d6a7530f4838b4482bb270f5ce7c", async() => {
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
            BeginContext(452, 906, true);
            WriteLiteral(@"
        <br />
        <br />
        <div class=""form-group input-group"" style=""margin-bottom:-5px;"">
            <span class=""input-group-addon""><i class=""glyphicon glyphicon-search colorIconEditar""></i></span>
            <input id=""myInput"" placeholder=""Buscar Produto por Descrição"" type=""text"" class=""form-control"">
        </div>
    </div>
    <table id=""myTable"" class=""table table-bordered table-condensed  table-responsive tablebgColor"">
        <thead class=""tabelaHeaderColor"">
            <tr>
                <td>Codigo</td>
                <td>Descricao</td>
                <td>Categoria</td>
                <td>Fornecedor</td>
                <td>EstoqueMinimo</td>
                <td>QtdEmEstoque</td>
                <td style=""text-align:center"">CMV</td>
                <td style=""text-align:center"" colspan=""3"">Ações</td>
            </tr>
        </thead>

");
            EndContext();
#line 35 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
         foreach (var produto in Model)
        {

#line default
#line hidden
            BeginContext(1410, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1471, 40, false);
#line 39 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
               Write(Html.DisplayFor(model => produto.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1581, 43, false);
#line 43 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
               Write(Html.DisplayFor(model => produto.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1692, 43, false);
#line 46 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
               Write(Html.DisplayFor(model => produto.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1805, 47, false);
#line 50 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
               Write(Html.DisplayFor(qtd => produto.Fornecedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1852, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1922, 47, false);
#line 54 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
               Write(Html.DisplayFor(model => produto.EstoqueMinimo));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2037, 46, false);
#line 57 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
               Write(Html.DisplayFor(model => produto.QtdEmEstoque));

#line default
#line hidden
            EndContext();
            BeginContext(2083, 76, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <span>R$ ");
            EndContext();
            BeginContext(2160, 37, false);
#line 60 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
                        Write(Html.DisplayFor(model => produto.CMV));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 95, true);
            WriteLiteral("</span>\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    <a title=\"Editar\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2292, "\"", 2349, 1);
#line 65 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
WriteAttributeValue("", 2299, Url.Action("EditarProduto",new { id =produto.Id}), 2299, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2350, 149, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-edit colorIconEditar\"></i></a>\r\n                </td>\r\n\r\n                <td>\r\n                    <a title=\"Detalhes\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2499, "\"", 2560, 1);
#line 69 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
WriteAttributeValue("", 2506, Url.Action("DetalhesDoProduto",new { id =produto.Id}), 2506, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2561, 238, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-info-sign colorIconEditar\"></i></a>\r\n                </td>\r\n\r\n                <td>\r\n                    <a  onclick = \"return confirm(\'Deseja excluir esse Produto?\');\"\r\n                       title=\"Excluir\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2799, "\"", 2857, 1);
#line 74 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
WriteAttributeValue("", 2806, Url.Action("ExcluirProduto",new { id =produto.Id}), 2806, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2858, 101, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash  colorIcon\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
        }

#line default
#line hidden
            BeginContext(2970, 26, true);
            WriteLiteral("    </table>\r\n    <br />\r\n");
            EndContext();
#line 80 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
     if (Model.Count().Equals(0))
    {

#line default
#line hidden
            BeginContext(3038, 97, true);
            WriteLiteral("        <span class=\"msmEmptyTable\">\r\n            Não há Produto cadastrado...\r\n        </span>\r\n");
            EndContext();
#line 85 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\ProdutosCadastrados.cshtml"
    }

#line default
#line hidden
            BeginContext(3142, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3169, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3175, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51cbeb9fa73c412b8eca005e21c06e44", async() => {
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
                BeginContext(3211, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591