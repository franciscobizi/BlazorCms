#pragma checksum "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40428e4d55aee3594e110ccca6f39e965fd0c643"
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
#line 2 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
using BlazorCms.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bz-admin/post/edit/{postId}")]
    public partial class EditPost : Microsoft.AspNetCore.Components.ComponentBase
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
                __builder2.AddAttribute(7, "class", "col-12");
                __builder2.AddMarkupContent(8, "<h1>Edit post</h1>\r\n                    ");
                __builder2.OpenComponent<BlazorCms.Client.Shared.MessageNotify>(9);
                __builder2.AddAttribute(10, "Alert", "success");
                __builder2.AddAttribute(11, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                           _postViewModel.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Display", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                                                             _postViewModel.Display

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "container");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-sm-9");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(20);
                __builder2.AddAttribute(21, "Placeholder", "Post title");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                                      _postViewModel.PostTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _postViewModel.PostTitle = __value, _postViewModel.PostTitle))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _postViewModel.PostTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                    <br><br>\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.RichTextEditor.SfRichTextEditor>(26);
                __builder2.AddAttribute(27, "value", 
#nullable restore
#line 20 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                    _postViewModel.PostContent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(28, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _postViewModel.PostContent = __value, _postViewModel.PostContent));
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.RichTextEditor.RichTextEditorToolbarSettings>(30);
                    __builder3.AddAttribute(31, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Syncfusion.Blazor.RichTextEditor.ToolbarItemModel>>(
#nullable restore
#line 21 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                               Tools

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                    <br><br>\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(33);
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                        _postViewModel.Update

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "CssClass", "e-info");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "Update");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-sm-3");
                __builder2.AddMarkupContent(41, "<h5>Thumbnail</h5>\r\n                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "thumbnail");
                __builder2.OpenElement(44, "img");
                __builder2.AddAttribute(45, "src", "/uploads/images/" + (
#nullable restore
#line 29 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                   _postViewModel.PostThumbnail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "alt", 
#nullable restore
#line 29 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                                                       _postViewModel.PostTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(48);
                __builder2.AddAttribute(49, "ID", "UploadFiles");
                __builder2.AddAttribute(50, "AutoUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                                 false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.UploaderEvents>(52);
                    __builder3.AddAttribute(53, "Success", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.SuccessEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.SuccessEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                                                     _postViewModel.OnImageUploadedSuccess

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.UploaderAsyncSettings>(55);
                    __builder3.AddAttribute(56, "SaveUrl", "posts/uploadimage");
                    __builder3.AddAttribute(57, "RemoveUrl", "posts/removeimage");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                    <hr>\r\n                    ");
                __builder2.AddMarkupContent(59, "<h5>Author</h5>\r\n                    ");
                __builder2.AddMarkupContent(60, "<p>Francisco Bizi</p>\r\n                    ");
                __builder2.AddMarkupContent(61, "<h5>Published</h5>\r\n                    ");
                __builder2.OpenElement(62, "p");
                __builder2.AddContent(63, 
#nullable restore
#line 39 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
                        _postViewModel.PostCreated

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(64, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorCms.Client.Shared.UserAuthForm>(65);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(67, "<style>\r\n\r\n.thumbnail img {\r\n        height: auto;\r\n        width: 100%;\r\n        box-shadow: inset 0 0 1px #e0e0e0, inset 0 0 14px rgba(0, 0, 0, 0.2);\r\n}\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\EditPost.razor"
       

    private List<ToolbarItemModel> Tools = new List<ToolbarItemModel>()
    {
        new ToolbarItemModel() { Command = ToolbarCommand.Bold },
        new ToolbarItemModel() { Command = ToolbarCommand.Italic },
        new ToolbarItemModel() { Command = ToolbarCommand.Underline },
        new ToolbarItemModel() { Command = ToolbarCommand.StrikeThrough },
        new ToolbarItemModel() { Command = ToolbarCommand.FontName },
        new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
        new ToolbarItemModel() { Command = ToolbarCommand.BackgroundColor },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.Formats },
        new ToolbarItemModel() { Command = ToolbarCommand.Alignments },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.LowerCase },
        new ToolbarItemModel() { Command = ToolbarCommand.UpperCase },
        new ToolbarItemModel() { Command = ToolbarCommand.SuperScript },
        new ToolbarItemModel() { Command = ToolbarCommand.SubScript },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.OrderedList },
        new ToolbarItemModel() { Command = ToolbarCommand.UnorderedList },
        new ToolbarItemModel() { Command = ToolbarCommand.Outdent },
        new ToolbarItemModel() { Command = ToolbarCommand.Indent },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
        new ToolbarItemModel() { Command = ToolbarCommand.Image },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateTable },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.ClearFormat },
        new ToolbarItemModel() { Command = ToolbarCommand.Print },
        new ToolbarItemModel() { Command = ToolbarCommand.SourceCode },
        new ToolbarItemModel() { Command = ToolbarCommand.FullScreen },
        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
        new ToolbarItemModel() { Command = ToolbarCommand.Undo },
        new ToolbarItemModel() { Command = ToolbarCommand.Redo }
    };

    [Parameter]
    public string postId { get; set; }
    
    protected override async Task OnInitializedAsync()
    {

        await _postViewModel.GetOne(this.postId);
    } 



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostViewModel _postViewModel { get; set; }
    }
}
#pragma warning restore 1591
