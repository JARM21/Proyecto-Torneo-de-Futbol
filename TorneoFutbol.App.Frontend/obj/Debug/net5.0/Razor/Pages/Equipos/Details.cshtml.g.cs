#pragma checksum "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f6b09c14b658ce61cea87dfaf697aa907407ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbol.App.Frontend.Pages.Equipos.Pages_Equipos_Details), @"mvc.1.0.razor-page", @"/Pages/Equipos/Details.cshtml")]
namespace TorneoFutbol.App.Frontend.Pages.Equipos
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
#line 1 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbol.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f6b09c14b658ce61cea87dfaf697aa907407ab", @"/Pages/Equipos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d179c1a50af22e4f8d73bc42157fd366720dfdc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Equipos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Detalles de los Equipos</h1>
<table class=""table table-striped"">
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">CantidadPartidosJugados</th>
            <th scope=""col"">CantidadPartidosGanados</th>
            <th scope=""col"">CantidadPartidosEmpatados</th>
            <th scope=""col"">GolesAFavor</th>
            <th scope=""col"">GolesEnContra</th>
            <th scope=""col"">Puntos</th>
            <td>");
#nullable restore
#line 15 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml"
           Write(Model.equipo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml"
           Write(Model.equipo.CantidadPartidosJugados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml"
           Write(Model.equipo.CantidadPartidosGanados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml"
           Write(Model.equipo.CantidadPartidosEmpatados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml"
           Write(Model.equipo.GolesAFavor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml"
           Write(Model.equipo.GolesEnContra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\josue\Mision TIC 2022 Ciclo 3\Proyecto Torneo de Futbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Equipos\Details.cshtml"
           Write(Model.equipo.Puntos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f6b09c14b658ce61cea87dfaf697aa907407ab6481", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbol.App.Frontend.Pages.Equipos.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Equipos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Equipos.DetailsModel>)PageContext?.ViewData;
        public TorneoFutbol.App.Frontend.Pages.Equipos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
