#pragma checksum "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59510cf5cd0a5df7c3fbae210f27d638bcf056a5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCms.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using BlazorCms.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using BlazorCms.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\_Imports.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
using BlazorCms.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class UserAuthForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<div class=\"row justify-content-md-center\"><div class=\"col-6\"><h1>Sign in with any option below!</h1>\r\n            <hr></div></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row justify-content-md-center");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-4");
            __builder.OpenComponent<BlazorCms.Client.Shared.MessageNotify>(7);
            __builder.AddAttribute(8, "Alert", "danger");
            __builder.AddAttribute(9, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                  _IAuthViewModel.Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Display", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                                                     _IAuthViewModel.Display

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(12);
            __builder.AddAttribute(13, "Placeholder", "Your login");
            __builder.AddAttribute(14, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 15 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                      InputType.Text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 15 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                                                                                                FloatLabelType.Auto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                                                    _IAuthViewModel.UserEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _IAuthViewModel.UserEmail = __value, _IAuthViewModel.UserEmail))));
            __builder.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _IAuthViewModel.UserEmail));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n            <br><br>\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(20);
            __builder.AddAttribute(21, "Placeholder", "Your password");
            __builder.AddAttribute(22, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 17 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                         InputType.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 17 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                                                                                                      FloatLabelType.Auto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                                                           _IAuthViewModel.UserPass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _IAuthViewModel.UserPass = __value, _IAuthViewModel.UserPass))));
            __builder.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _IAuthViewModel.UserPass));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n            <br><br>\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(28);
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                _IAuthViewModel.signIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Sign In");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n            <hr>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row justify-content-md-center");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-4");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "btn btn-block btn-social btn-facebook");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                                       _IAuthViewModel.FacebookSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "<span class=\"fa fa-facebook\"></span> ");
            __builder.AddMarkupContent(42, "<b>Sign in with Facebook</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    <br>\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row justify-content-md-center");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-4");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "class", "btn btn-block btn-social btn-google");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Shared\UserAuthForm.razor"
                                                                     _IAuthViewModel.GoogleSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "<span class=\"fa fa-google\"></span> ");
            __builder.AddMarkupContent(52, "<b>Sign in with Google</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthViewModel _IAuthViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
