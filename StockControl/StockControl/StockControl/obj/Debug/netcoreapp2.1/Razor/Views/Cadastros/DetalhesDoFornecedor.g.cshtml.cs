#pragma checksum "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3976816e46700da52cee6d8163231b96923fbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastros_DetalhesDoFornecedor), @"mvc.1.0.view", @"/Views/Cadastros/DetalhesDoFornecedor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastros/DetalhesDoFornecedor.cshtml", typeof(AspNetCore.Views_Cadastros_DetalhesDoFornecedor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3976816e46700da52cee6d8163231b96923fbe", @"/Views/Cadastros/DetalhesDoFornecedor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066864515f9a1e0757d18e623d6527a5be8c8416", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastros_DetalhesDoFornecedor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StockControl.Models.Fornecedor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FornecedoresCadastrados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
  
    ViewData["Title"] = "DetalhesDoFornecedor";

#line default
#line hidden
            BeginContext(94, 34, true);
            WriteLiteral("    <!--Autor:Novadson Thelus-->\r\n");
            EndContext();
            BeginContext(131, 373, true);
            WriteLiteral(@"
<div class=""panel panel-default  pull-right col-lg-8  col-md-7 col-sm-7 col-xl divdlColor panelWidth"">
    <div class=""panel-heading"">Detalhe do Fornecedor</div>

    <dl class=""dl-horizontal panel panel-default dlColor"">
        <dt class=""col-lg-3"">
            <label class=""control-label"">Nome:</label>
        </dt>
        <dd class=""col-lg-3"">
            ");
            EndContext();
            BeginContext(505, 36, false);
#line 16 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(541, 175, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Estabelecimento:</label>\r\n        </dt>\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(717, 51, false);
#line 23 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.TipoEstabelecimento));

#line default
#line hidden
            EndContext();
            BeginContext(768, 166, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Cnpj:</label>\r\n        </dt>\r\n\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(935, 36, false);
#line 31 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(971, 170, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Contato::</label>\r\n        </dt>\r\n\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(1142, 39, false);
#line 39 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Contato));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 167, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Email:</label>\r\n        </dt>\r\n\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(1349, 37, false);
#line 47 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 166, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Cidade:</label>\r\n        </dt>\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(1553, 38, false);
#line 54 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 164, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Estado:</label>\r\n        </dt>\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(1756, 34, false);
#line 60 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Uf));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 161, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Cep:</label>\r\n        </dt>\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(1952, 35, false);
#line 66 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 168, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Bairro:</label>\r\n        </dt>\r\n\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(2156, 38, false);
#line 74 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 164, true);
            WriteLiteral("\r\n        </dd> \r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Rua:</label>\r\n        </dt>\r\n\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(2359, 35, false);
#line 81 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 168, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Número:</label>\r\n        </dt>\r\n\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(2563, 38, false);
#line 89 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 123, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Status:</label>\r\n        </dt>\r\n");
            EndContext();
#line 95 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
         if (Model.Status.Equals(true))
        {


#line default
#line hidden
            BeginContext(2778, 115, true);
            WriteLiteral("            <dd style=\"margin-left:198px\" class=\"col-lg-3 statusAtivo\">\r\n                Ativo\r\n            </dd>\r\n");
            EndContext();
#line 101 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2929, 152, true);
            WriteLiteral("            <dd style=\"margin-left:198px;\" class=\"col-lg-3 statusInativo\">\r\n                <p style=\"margin-left:-5px\">Inativo</p>\r\n            </dd>\r\n");
            EndContext();
#line 107 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Cadastros\DetalhesDoFornecedor.cshtml"
        }

#line default
#line hidden
            BeginContext(3092, 49, true);
            WriteLiteral("    </dl>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(3141, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed7bfb5e7eee4306b4ed463492f7266d", async() => {
                BeginContext(3202, 50, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-backward\"></i>Voltar");
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
            BeginContext(3256, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StockControl.Models.Fornecedor> Html { get; private set; }
    }
}
#pragma warning restore 1591