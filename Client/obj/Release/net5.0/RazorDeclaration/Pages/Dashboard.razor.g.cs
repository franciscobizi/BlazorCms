// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/bz-admin/dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Francisco Bizi\Desktop\Blazor\MyAzure\BlazorCms\Client\Pages\Dashboard.razor"
            
    SfChart chartObj;
    SfChart barchartObj;
    SfRangeNavigator rangeObj;
    SfChart linechartObj;
    DateTime[] Value = new DateTime[] { new DateTime(2006, 01, 01), new DateTime(2008, 01, 01) };
    public class ChartData
    {
        public DateTime XValue;
        public double YValue;
        public string X;
        public double Y;
        public string Country;
        public string X1;
        public double Y1;
        public double Y2;
        public double Y3;
        public double Y4;
    }
    public List<ChartData> DataSource = new List<ChartData>
    {
        new ChartData { XValue = new DateTime(2005, 01, 01), YValue = 21, X = "USA", Y =300.2, Country = "USA: 72", X1= "2012"},
        new ChartData { XValue = new DateTime(2006, 01, 01), YValue = 24, X = "Russia", Y = 103.1, Country = "RUS: 103.1", X1= "2013"},
        new ChartData { XValue = new DateTime(2007, 01, 01), YValue = 36, X = "Brazil", Y = 139.1, Country = "BRZ: 139.1", X1= "2014"},
        new ChartData { XValue = new DateTime(2008, 01, 01), YValue = 38, X = "India", Y = 262.1, Country = "IND: 262.1", X1= "2015"},
    };
    public List<Order> Orders { get; set; }

    protected override void OnInitialized()
    {
        Orders = Enumerable.Range(1, 6).Select(x => new Order()
        {
            OrderID = 1000 + x,
            CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
            Freight = 2.1 * x,
            OrderDate = DateTime.Now.AddDays(-x),
        }).ToList();
    }

    public class Order
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await Task.Delay(3000); // simulate the async operations
        this.chartObj.Refresh();
        //this.rangeObj.Refresh();
        this.linechartObj.Refresh();
        this.barchartObj.Refresh();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591