#pragma checksum "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fee963f3a7e6b5cb5d3db6cd635a3975478e902e"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaArtesaniasMarielos.Pages.Account
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistrarUsuario")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-6 offset-md-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "<div class=\"card-header\"><h4>Artesanias Marielos</h4></div>\r\n\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                     Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                           Registrar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(16, "<h4 class=\"card-title text-center\">Registro de Usuario</h4>\r\n                        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(19, "<label>Nombres y Apellidos</label>\r\n                            ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "placeholder", "Escriba sus Nombres y Apellidos");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                                                                                         Model.Nombre_Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Nombre_Apellido = __value, Model.Nombre_Apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __Blazor.TiendaArtesaniasMarielos.Pages.Account.Register.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 24 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                      ()=>Model.Nombre_Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n                        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(32, "<label>Usuario</label>\r\n                            ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "placeholder", "Escriba un nombre de usuario");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                                                                                          ValidarNombreUsuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __Blazor.TiendaArtesaniasMarielos.Pages.Account.Register.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 30 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                      ()=>Model.Nombre_Usuario

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 32 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                             if (MostrarMensaje)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(41, "<span class=\"text-danger\">El usuario que intenta registrar ya existe</span>");
#nullable restore
#line 35 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n                        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(45, "<label>Contraseña</label>\r\n                            ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "password");
                __builder2.AddAttribute(48, "placeholder", "Escriba la contraseña");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                                                                                   Model.Clave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Clave = __value, Model.Clave));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __Blazor.TiendaArtesaniasMarielos.Pages.Account.Register.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 42 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                      ()=>Model.Clave

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(58, "<label>Confirmar Contraseña</label>\r\n                            ");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "type", "password");
                __builder2.AddAttribute(61, "placeholder", "Confirme la contraseña");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                                                                                    Model.ConfirmarClave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.ConfirmarClave = __value, Model.ConfirmarClave));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __Blazor.TiendaArtesaniasMarielos.Pages.Account.Register.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 48 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
                                                      ()=>Model.ConfirmarClave

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(69, "<div class=\"col-md-12 mb-3\"><button type=\"submit\" class=\"btn btn-primary btn-block\">\r\n                                Registrarme\r\n                            </button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.AddMarkupContent(71, "<div class=\"col-md-12 mb-3\"><hr></div>\r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(72, "<div class=\"col-md-12 mb-3\"><h5>¿Ya tienes una Cuenta?</h5></div>\r\n\r\n                    ");
            __builder.AddMarkupContent(73, "<div class=\"col-md-12 mb-3\"><a href=\"login\" class=\"btn btn-success btn-block\">Iniciar Sesión Ahora</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "D:\Usuarios\Alejandro Moraga\Imágenes\Practica\Pages\Account\Register.razor"
       

    public bool MostrarMensaje { get; set; } = false;

    public Usuario Model { get; set; } = new Usuario
    {
        TU_IdRol = 1,
    };

    protected async void Registrar()
    {
        var res = service.Registrar(Model);

        if (res.IsSuccess)
        {
            var result = await swal.FireAsync(new SweetAlertOptions
            {
                ShowCloseButton = true,
                Title = "Todo Bien",
                Text = res.Message,
                Icon = SweetAlertIcon.Success,

            });

            navigation.NavigateTo("/login");
        }

        else
        {
            var result = await swal.FireAsync(new SweetAlertOptions
            {
                ShowCloseButton = true,
                Title = "Error",
                Text = res.Message,
                Icon = SweetAlertIcon.Error,

            });
        }
    }

    protected  void ValidarNombreUsuario(ChangeEventArgs e)
    {
        var res = service.ValidarNombreUsuario(e.Value.ToString());

        MostrarMensaje = res.IsSuccess;

        Model.Nombre_Usuario = e.Value.ToString();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuariosService service { get; set; }
    }
}
namespace __Blazor.TiendaArtesaniasMarielos.Pages.Account.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
