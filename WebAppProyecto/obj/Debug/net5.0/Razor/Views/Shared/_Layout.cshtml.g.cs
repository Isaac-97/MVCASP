#pragma checksum "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5527a4a2f87f88bec368c5526a6f9075632d90ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\_ViewImports.cshtml"
using WebAppProyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\_ViewImports.cshtml"
using WebAppProyecto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5527a4a2f87f88bec368c5526a6f9075632d90ba", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebe9268ceb0f702041df6b1938d50e5599899047", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icoon/Fontsss/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formporfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pictureporfile formporfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nonele"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/main.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5527a4a2f87f88bec368c5526a6f9075632d90ba7977", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - WebAppProyecto</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5527a4a2f87f88bec368c5526a6f9075632d90ba8620", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5527a4a2f87f88bec368c5526a6f9075632d90ba9798", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5527a4a2f87f88bec368c5526a6f9075632d90ba11680", async() => {
                WriteLiteral(@"
    <div class=""darkmode darkmodenone"" id=""darkmode""></div>
    <header class=""arriba"" id=""headarriba"">
        <div class=""arriba-grid"">
            <div class=""grid-box"">

            </div>
            <div class=""grid-box"">

            </div>
            <div class=""grid-box grid-box-info-login"">
                <div class=""grid-box-login"">
                    <!-- ");
#nullable restore
#line 22 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                    Write(DateTime.Now.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("; -->\r\n                </div>\r\n                <div class=\"grid-box-login\">\r\n                    <div class=\"login-newspaper\" id=\"loginnewspaper\">\r\n                        <i class=\"icon-newspaper iconnewspaperclass\"></i>\r\n                    </div>\r\n");
                WriteLiteral("                </div>\r\n                <div class=\"grid-box-login\">\r\n                    <div class=\"cirlce-login\" id=\"logincircle\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5527a4a2f87f88bec368c5526a6f9075632d90ba13061", async() => {
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
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <div class=\"grid-box-login-popup\">\r\n        <div class=\"triangulo\"></div>\r\n        <div class=\"close-notice\">  <i class=\"icon-cross\"");
                BeginWriteAttribute("id", " id=\"", 1506, "\"", 1511, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i></div>
    </div>
    <div class=""windowsuserlogin closeuserlogin"" id=""windowsuserlogin"">
        <div class=""icon-x"">
            <i class=""icon-cross sizetres"" id=""iconcross""></i>
        </div>
        <div class=""icon-login-window"">
            <div class=""cirlce-login-window"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5527a4a2f87f88bec368c5526a6f9075632d90ba14885", async() => {
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
                WriteLiteral(@"
            </div>
            <p class=""name-user"">Hola Alex!</p>
        </div>
        <div class=""info-login-windows-A"">
            <div class=""info-login-windows-A-box"">
                <i class=""icon-user zizecuatroicon usericon""></i>
                <p>Apacheco</p>
            </div>
            <div class=""info-login-windows-A-box"">
                <i class=""icon-earth zizecuatroicon""></i>
                <p>alain.floresimpulsaasesores.mx</p>
            </div>
        </div>
        <hr>
        <div class=""boton-menu-windo-B"">
            <div class=""windo-B-b"">
                <div class=""windo-B-b-h openwindowsprofile"">
                    <i class=""icon-user icon-desg_B"" id=""openwindowsprofile""></i>
                </div>

                <p>Perfil</p>
            </div>
            <div class=""windo-B-b"">
                <div class=""windo-B-b-h"">
                    <i class=""icon-lifebuoy icon-desg_B""></i>
                </div>
                <p>Soporte</p>
     ");
                WriteLiteral(@"       </div>
            <div class=""windo-B-b"">
                <div class=""windo-B-b-h"">
                    <i class=""icon-exit icon-desg_B""></i>
                </div>
                <p>Salir</p>
            </div>
        </div>
    </div>
");
                WriteLiteral("    <div class=\"popupporfile popupporfilenone\" id=\"popupporfile\">\r\n        <div class=\"closeprofile\"><i class=\" icon-cross closeprofile-x\" id=\"closeprofilex\"></i></div>\r\n        <h3 class=\"h3porfile\">Perfil de Usuario</h3>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5527a4a2f87f88bec368c5526a6f9075632d90ba17604", async() => {
                    WriteLiteral("\r\n            <label class=\"nombreporfile\">\r\n                Nombre:\r\n            </label>\r\n            <input class=\"inputporfile\" type=\"text\" placeholder=\"Jhonny\" />\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5527a4a2f87f88bec368c5526a6f9075632d90ba19186", async() => {
                    WriteLiteral("\r\n            <label class=\"nombreporfile\">Imagen:</label>\r\n            <div class=\"containerpicture\">\r\n                <div class=\"a\">\r\n                    <div class=\"img-a\">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5527a4a2f87f88bec368c5526a6f9075632d90ba19669", async() => {
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
                    WriteLiteral(@"
                    </div>
                </div>
                <div class=""a"">
                    <input class=""inputporfileimagebutton"" type=""submit"" value=""Haga clic aquí para subir su archivo"" />
                </div>
            </div>
            <div class=""pictureporfile-button"">
                <button class=""btn-up-profile"">Listo</button>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
    <header class=""izquierda"" style=""z-index:99"">
        <nav class=""izquierdanav"" style=""z-index:99"">
            <ul class=""ul"" style=""z-index: 99"">

                <!--Home-->
                <li class=""li-menu"" id=""animationhover"">
                    
                     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5527a4a2f87f88bec368c5526a6f9075632d90ba22644", async() => {
                    WriteLiteral("<i class=\"icon-home3 icoon-size\" id=\"homewindow\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"                    
                </li>

                <!--Fin Home-->
                <!--Ventas-->
                <li class=""li-menu"" id=""animationhoverdos"">
                    <i class="" icon-cart icoon-size"" id=""openwindows""></i>
                    <span class=""liunohoverdos"" id=""liunohoverdos"">Ventas</span>
                </li>

                <ul class=""submenu cerrar"" id=""submenu"" style=""z-index:-10"">
                    <div class=""return"">
                        <div class=""return-ico"" id=""closewindow""><i class=""icon-circle-up icoon-sizedos""></i></div>
                    </div>
                    <li class=""li_submenu"">");
#nullable restore
#line 135 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Ventas", "Index", "Ventas", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-credit-card icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 136 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Corte", "Index", "CorteCaja", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-stats-bars icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 137 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Devolucion", "Index", "Devolucion", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-loop icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 138 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Garantia", "Index", "Garantia", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<i class=""icon-fire icoon-sizetres box""></i></li>
                </ul>
                <!--termina ventas-->
                <!--Inventario-->
                <li class=""li-menu"" id=""animationhovertres"">
                    <i class=""icon-truck icoon-size"" id=""openwindowsdos""></i>
                    <span class=""liunohovertres"" id=""liunohovertres"">Inventario</span>
                </li>


                <ul class=""submenudos cerrar"" id=""submenudos"" style=""z-index:-10"">
                    <div class=""return"">
                        <div class=""return-ico"" id=""closewindowdos""><i class=""icon-circle-up icoon-sizedos""></i></div>
                    </div>
                    <li class=""li_submenu"">");
#nullable restore
#line 152 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Producto", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-credit-card icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 153 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Marca", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-stats-bars icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 154 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Ejemplo", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-loop icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 155 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Ejemplo 2", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<i class=""icon-fire icoon-sizetres box""></i></li>
                </ul>
                <!--Termina Inventario-->
                <!--Compras-->
                <li class=""li-menu"" id=""animationhovercuatro"">
                    <i class=""icon-briefcase icoon-size"" id=""openwindowcuatro""></i>
                    <span class=""liunohovercuatro"" id=""liunohovercuatro"">Compras</span>
                </li>


                <!--Proveedor-->
                <li class=""li-menu"" id=""animationhovercinco"">
                    <i class=""icon-user-tie icoon-size"" id=""openwindowscinco""></i>
                    <span class=""liunohovercinco"" id=""liunohovercinco"">Proveedores</span>
                </li>
                <!--Fin Proveedor-->
                <!--Cliente-->
                <li class=""li-menu"" id=""animationhoverseis"">
                    <i class=""icon-users icoon-size"" id=""openwindowsseis""></i>
                    <span class=""liunohoverseis"" id=""liunohoverseis"">Clientes</span>
                <");
                WriteLiteral(@"/li>
                <!--Fin Cliente-->
                <!--Empleado-->
                <li class=""li-menu"" id=""animationhoversiete"">
                    <i class=""icon-man icoon-size"" id=""openwindowssiete""></i>
                    <span class=""liunohoversiete"" id=""liunohoversiete"">Empleados</span>
                </li>

                <ul class=""submenusiete cerrar"" id=""submenusiete"" style=""z-index:-10"">
                    <div class=""return"">
                        <div class=""return-ico"" id=""closewindowsiete""><i class=""icon-circle-up icoon-sizedos""></i></div>
                    </div>
                    <li class=""li_submenu"">");
#nullable restore
#line 187 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Empleados", "Index", "Empleados", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-credit-card icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 188 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Usuarios", "Index", "Usuarios", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<i class=""icon-stats-bars icoon-sizetres box""></i></li>
                </ul>
                <!--Fin Empleado  icon-cogs   icon-circle-left-->
                <!-- Reporte -->
                <li class=""li-menu"" id=""animationhoverocho"">
                    <i class=""icon-stats-bars icoon-size"" id=""openwindowsocho""></i>
                    <span class=""liunohoverocho"" id=""liunohoverocho"">Reportes</span>
                </li>

                <ul class=""submenuocho cerrar"" id=""submenuocho"" style=""z-index:-10"">
                    <div class=""return"">
                        <div class=""return-ico"" id=""closewindowocho""><i class=""icon-circle-up icoon-sizedos""></i></div>
                    </div>
                    <li class=""li_submenu"">");
#nullable restore
#line 201 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Reporte 1", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-credit-card icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 202 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Reporte 2", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-stats-bars icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 203 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Reporte 3", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<i class=""icon-stats-bars icoon-sizetres box""></i></li>
                </ul>
                <!-- Fin Reporte -->
                <!-- Configuracion -->
                <li class=""li-menu"" id=""animationhovernueve"" style=""position:absolute; bottom:10px"">
                    <i class=""icon-cogs icoon-size"" id=""openwindowsnueve""></i>
                    <span class=""liunohovernueve"" id=""liunohovernueve"">Configuracion</span>
                </li>

                <ul class=""submenunueve cerrar"" id=""submenunueve"" style=""z-index:-10"">
                    <div class=""return"">
                        <div class=""return-ico"" id=""closewindownueve""><i class=""icon-circle-up icoon-sizedos""></i></div>
                    </div>
                    <li class=""li_submenu"">");
#nullable restore
#line 216 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Configuracion 1", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-credit-card icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 217 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Configuracion 2", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-stats-bars icoon-sizetres box\"></i></li>\r\n                    <li class=\"li_submenu\">");
#nullable restore
#line 218 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
                                      Write(Html.ActionLink("Configuracion 3", "Index", "Ejemplo", null, new { @class = "linkmenu" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"icon-stats-bars icoon-sizetres box\"></i></li>\r\n                </ul>\r\n                <!-- Fin Configuracion -->\r\n            </ul>\r\n\r\n        </nav>\r\n\r\n    </header>\r\n    <div class=\"container\">\r\n        <main>\r\n            ");
#nullable restore
#line 228 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5527a4a2f87f88bec368c5526a6f9075632d90ba36147", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#nullable restore
#line 231 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 232 "C:\repos\AspMVC\Proyecto\MVCASP\WebAppProyecto\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
