#pragma checksum "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269cf3ff1a3b46be8dd6ee60489191616b8319a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CovidGuate_ColaConfirmados), @"mvc.1.0.view", @"/Views/CovidGuate/ColaConfirmados.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
using ProyectoFinal_EstDatos.Clases;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269cf3ff1a3b46be8dd6ee60489191616b8319a1", @"/Views/CovidGuate/ColaConfirmados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4629929b922a1aefb52e3cee58b716243e1bc8", @"/Views/_ViewImports.cshtml")]
    public class Views_CovidGuate_ColaConfirmados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoFinal_EstDatos.Clases.Paciente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
  
    ViewData["Title"] = "ColaConfirmados";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269cf3ff1a3b46be8dd6ee60489191616b8319a14459", async() => {
                WriteLiteral("\r\n\r\n        <header class=\"PacientesSospechos\">\r\n            <div class=\"textos\">\r\n                <h1 class=\"titulo\">Lista de Espera de Confirmados</h1>\r\n                <h3 class=\"subtitulo\">");
#nullable restore
#line 12 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                                 Write(ViewBag.NombreHospital);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
            </div>
            <div class=""sesgoabajo""></div>
        </header>
        <div class=""container"">
            <table class=""table table-striped"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>
                            ");
#nullable restore
#line 21 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 24 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 27 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                       Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 30 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                       Write(Html.DisplayNameFor(model => model.DPI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 33 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 36 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                       Write(Html.DisplayNameFor(model => model.Municipio));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </th>
                        <th style=""width:auto"">
                            Síntomas
                        </th>
                        <th style=""width:auto"">
                            Descripción
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 47 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                     foreach (Paciente item in ViewBag.ColaConfirmados)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Edad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DPI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Departamento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Municipio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Sintomas));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 72 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Crist\Desktop\ProyectoFinal_EstDatos\Views\CovidGuate\ColaConfirmados.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"sesgoabajo-lista\"></div>\r\n        <section class=\"contenedorlista\">\r\n            <p>\r\n\r\n            </p>\r\n            <center>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269cf3ff1a3b46be8dd6ee60489191616b8319a111971", async() => {
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
                WriteLiteral("\r\n            </center>\r\n            <p>\r\n\r\n            </p>\r\n        </section>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoFinal_EstDatos.Clases.Paciente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
