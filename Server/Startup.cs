using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using MediatR;
using BlazorCms.Server.Models;
using BlazorCms.Server.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Azure.Storage.Blobs;
using AutoMapper;
using BlazorCms.Server.AutoMapper;
using BlazorCms.Shared.Mapping;

namespace BlazorCms.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddRazorPages();

            // Add cors options
            services.AddCors(options =>
            {
                options.AddPolicy("PolicyName", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            // registe Blob storage
            services.AddSingleton(x => new BlobServiceClient(Configuration.GetValue<string>("AzureBlobConnectionStrings")));

            // registe MediatR library
            services.AddMediatR(typeof(Startup));

            // AddControllers options to increase maxdepth FB
            services.AddControllers().AddJsonOptions(option => { option.JsonSerializerOptions.PropertyNamingPolicy = null; option.JsonSerializerOptions.MaxDepth = 256; });
            
            // add automapper
            services.AddAutoMapper(typeof(AutoMapperSetup));

            // registering custom services
            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IPostServices, PostServices>();
            services.AddTransient<IBlobServices, BlobServices>();
            
            // inject dbcontext
            services.AddEntityFrameworkSqlite().AddDbContext<BlazorCmsContext>();

            // authentications

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            } 
            )
            .AddCookie()
            .AddGoogle(googleOptions => 
            {
                googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            })
            .AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
