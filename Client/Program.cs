using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorCms.ViewModels;
using Syncfusion.Blazor;
using Client.AutoMapper;

namespace BlazorCms.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // add authentication
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddAutoMapper(typeof(AutoMapperSetup));

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

             // Adding httpClient Factory
            builder.Services.AddHttpClient<IProfileViewModel,ProfileViewModel>
                    ("BlazorCmsClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddHttpClient<IPostViewModel,PostViewModel>
                    ("BlazorCmsClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddHttpClient<IAuthViewModel,AuthViewModel>
                    ("BlazorCmsClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddHttpClient<IUserViewModel,UserViewModel>
                    ("BlazorCmsClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}
