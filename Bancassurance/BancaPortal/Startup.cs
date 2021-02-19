using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BancaPortal.Data;
using BancassuranceApi.Services;
using BancassuranceLib.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using BancassuranceLib.Repository;
using BancassuranceApi.Utils;
using BancaPortal.Utils;

namespace BancaPortal
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<ISessionBasket, SessionBasket>();
            services.AddSingleton<ISessionChecker, SessionChecker>();
            services.AddSingleton<ISessionBridgeVmManager, SessionBridgeVmManager>();

            services.AddScoped<IUnitOfWorkRepo, UnitOfWorkRepo>();
            services.AddScoped<ITitlesService, TitlesService>();
            services.AddScoped<IRelationshipsService, RelationshipsService>();
            services.AddScoped<IDependantsService, DependantsService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IConfigReader, ConfigReader>();
            services.AddScoped<IUnsubscriptionService, UnsubscriptionService>();
            services.AddScoped<IAccountSettingsService, AccountSettingsService>();
            services.AddScoped<INumberService, NumberService>();
            services.AddScoped<IJsonResultFacade, JsonResultFacade>();
            services.AddScoped<ISessionBridgeService, SessionBridgeService>();
            services.AddScoped<IT24AccountService, T24AccountService>();
            services.AddScoped<ITurnOverService, TurnOverService>();
            services.AddScoped<IPageAccessChecker, PageAccessChecker>();
            services.AddScoped<ISessionBridgeService, SessionBridgeService>();
            services.AddScoped<ISystemSettingsService, SystemSettingsService>();
            services.AddScoped<ISessionLifeChecker, SessionLifeChecker>();

            services.AddTransient<IStringExtensions, StringExtensions>();
            services.AddTransient<IPortalUserActionsService, PortalUserActionsService>();

            services.AddDbContext<BancassuranceContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Bancassurance")), ServiceLifetime.Scoped);

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
