#pragma checksum "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12cdbaebe0acc63a95ab713dba642f6ed90173c8"
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
#line 2 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
using BlazorCms.Shared.Mapping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
using BlazorCms.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bz-admin/posts")]
    public partial class Posts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "container");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-sm-12");
                __builder2.AddMarkupContent(8, "<h1>Posts</h1>\r\n                    ");
                __builder2.OpenComponent<BlazorCms.Client.Shared.MessageNotify>(9);
                __builder2.AddAttribute(10, "Alert", "success");
                __builder2.AddAttribute(11, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                           _postViewModel.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Display", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                             _postViewModel.Display

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(14);
                __builder2.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                        AddNewPost

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "class", "btn-create");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Add new post");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "row");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-sm-12");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<PostResponse>>(24);
                __builder2.AddAttribute(25, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<PostResponse>>(27);
                    __builder3.AddAttribute(28, "CommandClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.CommandClickEventArgs<PostResponse>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.CommandClickEventArgs<PostResponse>>(this, 
#nullable restore
#line 20 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                    OnCommandClicked

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(30);
                    __builder3.AddAttribute(31, "Url", "/posts");
                    __builder3.AddAttribute(32, "Adaptor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 21 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                             Adaptors.WebApiAdaptor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(34);
                    __builder3.AddAttribute(35, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                    2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(37);
                    __builder3.AddAttribute(38, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 23 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                         EditMode.Normal

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(42);
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(44);
                        __builder4.AddAttribute(45, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                nameof(post.PostId)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "HeaderText", "ID");
                        __builder4.AddAttribute(48, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 25 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                    TextAlign.Left

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "Width", "50");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\r\n                            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(51);
                        __builder4.AddAttribute(52, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                nameof(post.PostTitle)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "HeaderText", "Title");
                        __builder4.AddAttribute(54, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 26 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                      TextAlign.Left

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(55, "Width", "120");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n                            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(57);
                        __builder4.AddAttribute(58, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                nameof(post.PostAuthorName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(59, "HeaderText", "Author");
                        __builder4.AddAttribute(60, "Width", "150");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(62);
                        __builder4.AddAttribute(63, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                nameof(post.PostCreated)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "HeaderText", "Created");
                        __builder4.AddAttribute(65, "Format", "d");
                        __builder4.AddAttribute(66, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 28 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                ColumnType.Date

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 28 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                                            TextAlign.Left

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "Width", "130");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "\r\n                            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(70);
                        __builder4.AddAttribute(71, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                nameof(post.PostUpdated)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(72, "HeaderText", "Updated");
                        __builder4.AddAttribute(73, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 29 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                          TextAlign.Left

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Width", "120");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(75, "\r\n                            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(76);
                        __builder4.AddAttribute(77, "HeaderText", "Manage Records");
                        __builder4.AddAttribute(78, "Width", "150");
                        __builder4.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumns>(80);
                            __builder5.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(82);
                                __builder6.AddAttribute(83, "Title", "View");
                                __builder6.AddAttribute(84, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 32 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                          CommandButtonType.None

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(85, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 32 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                  new CommandButtonOptions() { IconCss = "fa fa-eye", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(86, "\r\n                                    ");
                                __builder6.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(87);
                                __builder6.AddAttribute(88, "Title", "Edit");
                                __builder6.AddAttribute(89, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 33 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                          CommandButtonType.Edit

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(90, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 33 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                  new CommandButtonOptions() { IconCss = "e-icons e-edit", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(91, "\r\n                                    ");
                                __builder6.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(92);
                                __builder6.AddAttribute(93, "Title", "Delete");
                                __builder6.AddAttribute(94, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 34 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                            CommandButtonType.None

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(95, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 34 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                    new CommandButtonOptions() { IconCss = "e-icons e-delete", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(96, "\r\n                                    ");
                                __builder6.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(97);
                                __builder6.AddAttribute(98, "Title", "Save");
                                __builder6.AddAttribute(99, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 35 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                          CommandButtonType.Save

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(100, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 35 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                  new CommandButtonOptions() { IconCss = "e-icons e-update", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(101, "\r\n                                    ");
                                __builder6.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(102);
                                __builder6.AddAttribute(103, "Title", "Cancel");
                                __builder6.AddAttribute(104, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 36 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                            CommandButtonType.Cancel

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(105, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 36 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
                                                                                                                      new CommandButtonOptions() { IconCss = "e-icons e-cancel-icon", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(106, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorCms.Client.Shared.UserAuthForm>(107);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(108, "\r\n\r\n");
            __builder.AddMarkupContent(109, "<style>\r\n    .post-actions a{\r\n        margin: 0 5px;\r\n    }\r\n    .fa-trash{\r\n        cursor: pointer;\r\n        color: red;\r\n    }\r\n    .btn-create{\r\n        margin: 5px 0;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Posts.razor"
      
    private List<string> ToolbarItems = new List<string>(){ "Add","Edit","Delete","Update","Cancel"};

    private void OnCommandClicked(CommandClickEventArgs<PostResponse> args)
    {
        var clicked = args.CommandColumn.Title;
        //_postViewModel.ToUrlFriendly(args.RowData.PostTitle)
        switch (clicked)
        {
            case "View":
               _navigate.NavigateTo("/blog/" + args.RowData.PostPermalink);
               break;
            case "Edit":
               _navigate.NavigateTo("/bz-admin/post/edit/" + args.RowData.PostId);
               break;
            case "Delete":
               this._postViewModel.Remove(args.RowData.PostId);
               break;
            default:
               break;
        }

    }
    PostResponse post = new PostResponse();
    public void AddNewPost()
    {
        _navigate.NavigateTo("/bz-admin/post/new/");
    }
    protected override async Task OnInitializedAsync()
    {

        await _postViewModel.GetAll();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostViewModel _postViewModel { get; set; }
    }
}
#pragma warning restore 1591