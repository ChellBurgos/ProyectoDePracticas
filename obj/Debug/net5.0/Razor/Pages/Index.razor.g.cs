#pragma checksum "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd0ff4d52f88a3a57f4efffa7b7727fb8f255c5"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaArtesaniasMarielos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using TiendaArtesaniasMarielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Index.razor"
                                          ListaRoles

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Lista de Roles");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Index.razor"
      

    protected void ListaRoles()
    {
        var list = rolesService.ListaRoles();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolesService rolesService { get; set; }
    }
}
#pragma warning restore 1591
