#pragma checksum "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "145e410a6dddf0ed854d7a5f36c70bc968ce2c95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Login.cshtml", typeof(AspNetCore.Views_Usuario_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"145e410a6dddf0ed854d7a5f36c70bc968ce2c95", @"/Views/Usuario/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066864515f9a1e0757d18e623d6527a5be8c8416", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(45, 40, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(85, 1608, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72ed2e4f6ef494f8ea793fc23a37db5", async() => {
                BeginContext(91, 295, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <link href=""https://fonts.googleapis.com/css?family=Black+Ops+One"" rel=""stylesheet"">
    ");
                EndContext();
                BeginContext(386, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01b0bb2b00ca42f8843861adba83b97c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(457, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(463, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0941dacb4bf14e21bcc16e9a8634b059", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(511, 563, true);
                WriteLiteral(@"
    <link href=""//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""https://cdn.rawgit.com/mdehoog/Semantic-UI/6e6d051d47b598ebab05857545f242caf2b4b48c/dist/semantic.min.css"" rel=""stylesheet"" type=""text/css"" />
    <script src=""https://code.jquery.com/jquery-2.1.4.js""></script>
    <script src=""https://cdn.rawgit.com/mdehoog/Semantic-UI/6e6d051d47b598ebab05857545f242caf2b4b48c/dist/semantic.min.js""></script>

    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    ");
                EndContext();
                BeginContext(1074, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e88eeca09945088cc2e614e5997566", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1111, 575, true);
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css?family=Monoton"" rel=""stylesheet"">

    <link href=""//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""https://cdn.rawgit.com/mdehoog/Semantic-UI/6e6d051d47b598ebab05857545f242caf2b4b48c/dist/semantic.min.css"" rel=""stylesheet"" type=""text/css"" />
    <script src=""https://code.jquery.com/jquery-2.1.4.js""></script>
    <script src=""https://cdn.rawgit.com/mdehoog/Semantic-UI/6e6d051d47b598ebab05857545f242caf2b4b48c/dist/semantic.min.js""></script>
");
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
            BeginContext(1693, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1695, 3082, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e524ac48ac1d43c9b1ead3454891c721", async() => {
                BeginContext(1711, 291, true);
                WriteLiteral(@"

    <nav class=""navbar navbar-ligh col-lg-12  col-md-12 col-sm-12 col-xl"">
        <h1 align=""center"" style=""color:#4a75f7;font-family:'Black Ops One',
    cursive;font-size:75px;margin-top:10px;margin-left:120px;text-shadow:2px 2px white;"">
            Stock Control
        </h1>
");
                EndContext();
#line 38 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
         if (Model == null)
        {

#line default
#line hidden
                BeginContext(2042, 229, true);
                WriteLiteral("        <div style=\"position:absolute;margin-top:-46px\">\r\n            <p style=\"color:#073ab4;text-shadow: 1px 1px white;\r\nfont-size:20px;font-weight:bolder;margin-left:1090px;margin-top:-20px\">Olá visitante</p>\r\n        </div>\r\n");
                EndContext();
#line 44 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"

        }

#line default
#line hidden
                BeginContext(2284, 677, true);
                WriteLiteral(@"        <a style=""color:#073ab4;text-shadow: 1px 1px white;font-size:16px"" class=""pull-right"" id=""test"">
            <i style=""color:#073ab4;text-shadow: 1px 1px white;font-size:18px""class=""glyphicon glyphicon-log-in""></i>
            Acesse
        </a>

    </nav>

    <div class=""ui modal test"" style=""width:300px;height:300px;margin:-120PX;background:#668cff;"">
        <div class=""ui middle aligned center aligned grid"">
            <div class=""column"">
                <h2 style=""color:white;margin-top:10px
                     ;text-shadow:2px 2px #668cff;font-family:'Black Ops One',cursive;"">
                    Acesse sua conta
                </h2>
");
                EndContext();
#line 60 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
                 using (Html.BeginForm("LogarSe", "Usuario", FormMethod.Post, new { @class = "ui large form " }))
                {

#line default
#line hidden
                BeginContext(3095, 343, true);
                WriteLiteral(@"                    <div class=""ui  segment"">
                        <br />
                        <div class=""field"">
                            <div class=""form-group"">
                                <div class=""ui left icon input"">
                                    <i class=""user icon""></i>
                                    ");
                EndContext();
                BeginContext(3439, 165, false);
#line 68 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
                               Write(Html.TextBoxFor(model => model.EmailLogin, null, new { @class = "large form-control", placeholder = "Endereço E-mail/Login", type = "text", @style = "width:268px" }));

#line default
#line hidden
                EndContext();
                BeginContext(3604, 74, true);
                WriteLiteral("\r\n                                </div>\r\n                                ");
                EndContext();
                BeginContext(3679, 90, false);
#line 70 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
                           Write(Html.ValidationMessageFor(model => model.EmailLogin, null, new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3769, 336, true);
                WriteLiteral(@"
                            </div>
                        </div>

                        <div class=""field"">
                            <div class=""form-group"">
                                <div class=""ui left icon input"">
                                    <i class=""lock icon""></i>
                                    ");
                EndContext();
                BeginContext(4106, 153, false);
#line 78 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
                               Write(Html.TextBoxFor(model => model.Senha, null, new { @class = "form-control", placeholder = "Digite sua senha", type = "password", @style = "width:268px" }));

#line default
#line hidden
                EndContext();
                BeginContext(4259, 74, true);
                WriteLiteral("\r\n                                </div>\r\n                                ");
                EndContext();
                BeginContext(4334, 85, false);
#line 80 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Senha, null, new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(4419, 284, true);
                WriteLiteral(@"
                            </div>
                        </div>
                        <input class=""ui fluid large primary submit button glyphicon glyphicon-log-in"" type=""submit"" name=""login"" value=""Login"" style=""color:white;background:#668cff;"">
                    </div>
");
                EndContext();
#line 85 "C:\Users\Novadson Thelus\Documents\ProjetoExperimental\StockControl\StockControl\StockControl\Views\Usuario\Login.cshtml"
                }

#line default
#line hidden
                BeginContext(4722, 48, true);
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4777, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
