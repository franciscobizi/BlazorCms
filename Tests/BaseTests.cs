using System;
using System.Collections.Generic;
using System.Linq;
using BlazorCms.Server.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorCms.Server;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Data;
using Newtonsoft.Json;

namespace Tests
{
    public class BaseTests
    {
        protected readonly HttpClient testClient;
        protected string BaseUrl = "https://localhost:5001/";
        protected BaseTests()
        {
            var appFactory = new WebApplicationFactory<Startup>()
                                  .WithWebHostBuilder(builder =>
                                        {
                                            /* builder.ConfigureServices(services =>
                                            {
                                                services.RemoveAll(typeof(DataContext));
                                                services.AddDbContext<DataContext>(options => 
                                                {
                                                    options.UseInMemoryDataBase("TestDB");
                                                });
                                            }); */
                                        }
                                    ); 
            testClient = appFactory.CreateClient();
        }
    }
}