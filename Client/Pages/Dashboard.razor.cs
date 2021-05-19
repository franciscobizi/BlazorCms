using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCms.ViewModels;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Charts;

namespace BlazorCms.Client.Pages
{
    public partial class Dashboard
    {
        SfChart chartObj = new SfChart();
        SfChart barchartObj;
        SfRangeNavigator rangeObj;
        SfChart linechartObj;
        DateTime[] Value = new DateTime[] { new DateTime(2006, 01, 01), new DateTime(2008, 01, 01) };
        public List<ChartData> DataSource = new List<ChartData>
        {
            new ChartData { XValue = new DateTime(2005, 01, 01), YValue = 21, X = "USA", Y =300.2, Country = "USA: 72", X1= "2012"},
            new ChartData { XValue = new DateTime(2006, 01, 01), YValue = 24, X = "Russia", Y = 103.1, Country = "RUS: 103.1", X1= "2013"},
            new ChartData { XValue = new DateTime(2007, 01, 01), YValue = 36, X = "Brazil", Y = 139.1, Country = "BRZ: 139.1", X1= "2014"},
            new ChartData { XValue = new DateTime(2008, 01, 01), YValue = 38, X = "India", Y = 262.1, Country = "IND: 262.1", X1= "2015"},
        };
        public List<Order> Orders { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await Task.Delay(3000); // simulate the async operations
            //this.chartObj.Refresh();
            //this.rangeObj.Refresh();
            //this.linechartObj.Refresh();
            //this.barchartObj.Refresh();
        }
        
    }

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

    public class Order
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
    }
}