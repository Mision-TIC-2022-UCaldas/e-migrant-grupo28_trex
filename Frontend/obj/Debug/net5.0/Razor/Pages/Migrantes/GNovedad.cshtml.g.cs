#pragma checksum "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\Migrantes\GNovedad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7a4048c39c0c5657c652cad061fb55944162336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Migrantes.Pages_Migrantes_GNovedad), @"mvc.1.0.razor-page", @"/Pages/Migrantes/GNovedad.cshtml")]
namespace Frontend.Pages.Migrantes
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
#line 1 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\_ViewImports.cshtml"
using Frontend.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a4048c39c0c5657c652cad061fb55944162336", @"/Pages/Migrantes/GNovedad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa81b266999a1644105d70b627493e45ca36ef4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrantes_GNovedad : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Listado de novedades</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Fecha de la novedad</th>\r\n            <th>Días de activos</th>\r\n            <th>Descripción</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 15 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\Migrantes\GNovedad.cshtml"
         foreach (var novedad in @Model.Novedads)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\Migrantes\GNovedad.cshtml"
               Write(novedad.FechaInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\Migrantes\GNovedad.cshtml"
               Write(novedad.DiasNovedad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\Migrantes\GNovedad.cshtml"
               Write(novedad.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Adrian\Desktop\e-migrant-grupo28_trex-E\Frontend\Pages\Migrantes\GNovedad.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.GNovedadModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.GNovedadModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.GNovedadModel>)PageContext?.ViewData;
        public Frontend.GNovedadModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
