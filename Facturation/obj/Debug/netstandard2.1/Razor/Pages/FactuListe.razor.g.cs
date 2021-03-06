#pragma checksum "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d36dfe9d804e3fec1a3a3c0590e5c91455194a"
// <auto-generated/>
#pragma warning disable 1591
namespace Facturation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/_Imports.razor"
using Facturation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
using Facturation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factListe")]
    public partial class FactuListe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Liste des factures</h3>\n\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.AddMarkupContent(4, @"<thead>
        <tr>
            <th>Numéro</th>
            <th>Client</th>
            <th>Date Emission</th>
            <th>Date Attendu</th>
            <th>Montant Dû</th>
            <th>Montant Réglé</th>
            
        </tr>
        </thead>
        ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 22 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
          
            float totalDu = 0;
            float totalRegle = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
         foreach (var f in factures)

        {
            totalDu += f.MontantDu;
            totalRegle += f.MontantRegle;

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 32 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                     f.numero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 33 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                     f.Client

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 34 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                     f.dateEmission

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                     f.dateAttendu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "class", "text-right");
            __builder.AddContent(24, 
#nullable restore
#line 36 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                                        f.MontantDu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "class", "text-right");
            __builder.AddContent(28, 
#nullable restore
#line 37 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                                        f.MontantRegle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 40 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.OpenElement(32, "tr");
            __builder.AddAttribute(33, "id", "total");
            __builder.AddMarkupContent(34, "\n            <td></td>\n            <td></td>\n            <td></td>\n            ");
            __builder.AddMarkupContent(35, "<td>Totaux</td>\n            ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "class", "text-right");
            __builder.AddContent(38, 
#nullable restore
#line 46 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                                    totalDu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "class", "text-right");
            __builder.AddContent(42, 
#nullable restore
#line 47 "/Users/louis/Documents/Ecole/DEV/C#/Facturation/Facturation/Pages/FactuListe.razor"
                                    totalRegle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private List<Facture> factures { get; set; }
    }
}
#pragma warning restore 1591
