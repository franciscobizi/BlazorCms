#pragma checksum "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc363390ada5b98f9a07c2352922d7cf7af638a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCms.Client.Pages
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
#line 2 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
using BlazorCms.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-9");
#nullable restore
#line 7 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                     if(@_postViewModel.Posts != null && @_postViewModel.Posts.Count() > 0)
                    {
                        var posts = _postViewModel.Posts.Take(Items);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row mt-2");
#nullable restore
#line 11 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                         foreach (var post in posts)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-4 mt-3");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", "/blog/" + (
#nullable restore
#line 14 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                    post.PostPermalink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "text-decoration: none;");
            __builder.AddAttribute(13, "title", "Read More");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(14);
            __builder.AddAttribute(15, "Orientation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Cards.CardOrientation>(
#nullable restore
#line 15 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                             CardOrientation.Vertical

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ID", "Trimmer");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(18, "img");
                __builder2.AddAttribute(19, "class", "card-thambnail");
                __builder2.AddAttribute(20, "src", "/uploads/images/" + (
#nullable restore
#line 16 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                                                              post.PostThumbnail

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardHeader>(22);
                __builder2.AddAttribute(23, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                                post.PostTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                                            ");
                __builder2.OpenElement(25, "em");
                __builder2.AddAttribute(26, "class", "ml-3");
                __builder2.AddMarkupContent(27, "<span class=\"fa fa-calendar\"></span> ");
                __builder2.AddContent(28, 
#nullable restore
#line 18 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                                                                   post.PostUpdated

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                            
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row mt-5");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-12 text-center");
#nullable restore
#line 27 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                 if(@Items < @_postViewModel.Posts.Count())
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                                              LoadMoreItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Load more");
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<div class=\"row mt-5\"><div class=\"col-sm-12 text-center\"><h3>There are not posts at the moment!</h3></div></div>");
#nullable restore
#line 41 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-sm-3");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(42);
            __builder.AddAttribute(43, "Placeholder", "Search");
            __builder.AddAttribute(44, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                                                                  _postViewModel.OnSearchTermChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 44 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                                                                                                           InputType.Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
                                                             _postViewModel.SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _postViewModel.SearchTerm = __value, _postViewModel.SearchTerm))));
            __builder.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _postViewModel.SearchTerm));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n                <hr>\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.Calendars.SfCalendar<DateTime>>(50);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Index.razor"
      
    protected int Items { get; set; } = 3;
    protected override async Task OnInitializedAsync() => await _postViewModel.GetAll();
    private void LoadMoreItems() => Items += 3;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostViewModel _postViewModel { get; set; }
    }
}
#pragma warning restore 1591
