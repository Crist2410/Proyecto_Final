#pragma checksum "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cfc248bdaf873939f8c1813fb752c972d73042c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CovidGuate_RealizarPrueba), @"mvc.1.0.view", @"/Views/CovidGuate/RealizarPrueba.cshtml")]
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
#line 1 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\_ViewImports.cshtml"
using ProyectoFinal_EstDatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\_ViewImports.cshtml"
using ProyectoFinal_EstDatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cfc248bdaf873939f8c1813fb752c972d73042c", @"/Views/CovidGuate/RealizarPrueba.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4629929b922a1aefb52e3cee58b716243e1bc8", @"/Views/_ViewImports.cshtml")]
    public class Views_CovidGuate_RealizarPrueba : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoFinal_EstDatos.Clases.Paciente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MostrarHospital", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
  
    ViewData["Title"] = "RealizarPreuba";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cfc248bdaf873939f8c1813fb752c972d73042c4224", async() => {
                WriteLiteral(@"

        <header class=""PacientesSospechos"">
            <div class=""textos"">
                <h1 class=""titulo"">Realizar Preuba</h1>
                <h3 class=""subtitulo"">Paciente</h3>
            </div>
            <div class=""sesgoabajo""></div>
        </header>
        <div class=""container"">
            <dl class=""row"">
                <dt class=""col-md-2"">
                    ");
#nullable restore
#line 18 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.DPI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 39 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.DPI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Departamento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Municipio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Municipio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Sintomas));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 57 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Sintomas));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 63 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayNameFor(model => model.Hospital));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 69 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
               Write(Html.DisplayFor(model => model.Hospital));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <section class=\"contenedorlista\">\r\n                <h2 class=\"titulo\">");
#nullable restore
#line 73 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
                              Write(ViewBag.Descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <h2 class=\"titulo\">");
#nullable restore
#line 74 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\RealizarPrueba.cshtml"
                              Write(ViewBag.Descripcion2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            </section>\r\n            <section class=\"contenedorblanco\">\r\n                <div>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cfc248bdaf873939f8c1813fb752c972d73042c12121", async() => {
                    WriteLiteral("Regresar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </section>\r\n            <div class=\"sesgoabajo-unico\"></div>\r\n        </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoFinal_EstDatos.Clases.Paciente> Html { get; private set; }
    }
}
#pragma warning restore 1591
