#pragma checksum "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14130a8e067d29d242d6e747c2efd8a37ec759a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_DetalhesDoUsuario), @"mvc.1.0.view", @"/Views/Usuario/DetalhesDoUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/DetalhesDoUsuario.cshtml", typeof(AspNetCore.Views_Usuario_DetalhesDoUsuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14130a8e067d29d242d6e747c2efd8a37ec759a9", @"/Views/Usuario/DetalhesDoUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066864515f9a1e0757d18e623d6527a5be8c8416", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_DetalhesDoUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UsuariosCadastrados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 371, true);
            WriteLiteral(@"
<div  class=""panel panel-default  pull-right col-lg-8  col-md-7 col-sm-7 col-xl divdlColor panelWidth"">
    <div class=""panel-heading"">Detalhe do Usuário</div>
    <dl class=""dl-horizontal panel panel-default dlColor"">

        <dt class=""col-lg-3"">
            <label class=""control-label"">Nome:</label>
        </dt>
        <dd class=""col-lg-3"">
            ");
            EndContext();
            BeginContext(388, 36, false);
#line 11 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(424, 165, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Email:</label>\r\n        </dt>\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(590, 37, false);
#line 18 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(627, 169, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Contato:</label>\r\n        </dt>\r\n\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(797, 39, false);
#line 26 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(836, 165, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Login:</label>\r\n        </dt>\r\n        <dd class=\"col-lg-3\">\r\n            ");
            EndContext();
            BeginContext(1002, 37, false);
#line 33 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Login));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 123, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-lg-3\">\r\n            <label class=\"control-label\">Status:</label>\r\n        </dt>\r\n");
            EndContext();
#line 39 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml"
         if (Model.Status.Equals(true))
        {


#line default
#line hidden
            BeginContext(1216, 115, true);
            WriteLiteral("            <dd style=\"margin-left:198px\" class=\"col-lg-3 statusAtivo\">\r\n                Ativo\r\n            </dd>\r\n");
            EndContext();
#line 45 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1367, 152, true);
            WriteLiteral("            <dd style=\"margin-left:198px;\" class=\"col-lg-3 statusInativo\">\r\n                <p style=\"margin-left:-5px\">Inativo</p>\r\n            </dd>\r\n");
            EndContext();
#line 51 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\DetalhesDoUsuario.cshtml"
        }

#line default
#line hidden
            BeginContext(1530, 51, true);
            WriteLiteral("\r\n    </dl>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1581, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "176d16e62ef449b88115d0d080efe84e", async() => {
                BeginContext(1638, 50, true);
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
            BeginContext(1692, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
