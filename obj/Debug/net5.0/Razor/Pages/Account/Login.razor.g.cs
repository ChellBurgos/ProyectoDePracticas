#pragma checksum "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2c95722c8c52aa6617204b8df78a1e597bf87d"
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
#line 1 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using TiendaArtesaniasMarielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Providers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(UnauthorizedLayaout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
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
#line 16 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
                                     Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
                                                           LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(16, "<h4 class=\"card-title text-center\">Iniciar Sesión</h4>\r\n                        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(19, "<label>Usuario</label>\r\n                            ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "placeholder", "Escriba su nombre de usuario");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
                                                                                                                      Model.Usuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Usuario = __value, Model.Usuario));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __Blazor.TiendaArtesaniasMarielos.Pages.Account.Login.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 24 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
                                                    (()=>Model.Usuario)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n\r\n                        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(32, "<label>Contraseña</label>\r\n                            ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "password");
                __builder2.AddAttribute(35, "placeholder", "Escriba la contraseña");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
                                                                                                                   Model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Password = __value, Model.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __Blazor.TiendaArtesaniasMarielos.Pages.Account.Login.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 31 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
                                                    (()=>Model.Password)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n\r\n                        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-md-12 mb-3");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group form-check");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "type", "checkbox");
                __builder2.AddAttribute(49, "class", "form-check-input");
                __builder2.AddAttribute(50, "id", "exampleCheck1");
                __builder2.AddAttribute(51, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
                                              Model.Recordarme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Recordarme = __value, Model.Recordarme));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.AddMarkupContent(54, "<label class=\"form-check-label\" for=\"exampleCheck1\">Mantener sesión abierta </label>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(56, "<div class=\"col-md-12 mb-3\"><button type=\"submit\" class=\"btn btn-primary btn-block\">Iniciar</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n\r\n                    ");
            __builder.AddMarkupContent(58, "<div class=\"col-md-12 mb-3\"><a href=\"/recoverpassword\">¿Olvidaste tu contraseña?</a></div>\r\n\r\n                    ");
            __builder.AddMarkupContent(59, "<div class=\"col-md-12 mb-3\"><hr></div>\r\n\r\n                    ");
            __builder.AddMarkupContent(60, "<div class=\"col-md-12 mb-3\"><h5>¿Aún no tienes cuenta?</h5></div>\r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(61, "<div class=\"col-md-12 mb-3\"><a href=\"RegistrarUsuario\" class=\"btn btn-success btn-block\">Registrarte Ahora</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n");
            __builder.OpenComponent<Sotsera.Blazor.Toaster.ToastContainer>(63);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\Usuarios\Alejandro Moraga\Escritorio\Practica\Pages\Account\Login.razor"
       

    public LoginUsuarioModel Model { get; set; } = new LoginUsuarioModel();

    protected async Task LoginUser()
    {
        var res = usuarioService.Login(Model);

        if (!res.IsSuccess)
        {
            toaster.Error(res.Message, "Error");
        }
        else
        {


            var token = new LoginModel
            {
                Usuario = Model.Usuario,
                Recordar = Model.Recordarme,
            };

            await authProvider.Login(token);

            navigation.NavigateTo("/", true);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthProvider authProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuariosService usuarioService { get; set; }
    }
}
namespace __Blazor.TiendaArtesaniasMarielos.Pages.Account.Login
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
    }
}
#pragma warning restore 1591
