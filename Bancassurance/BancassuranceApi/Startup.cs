using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BancassuranceApi.Utils;
using BancassuranceApi.Security;
using BancassuranceApi.Services;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace BancassuranceApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bancassurance", Version = "v1" });
            });

            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling
                = Newtonsoft.Json.ReferenceLoopHandling.Ignore);                    

            services.AddTransient<IConfigReader, ConfigReader>();
            services.AddTransient<IMemberService, MemberService>();
            services.AddTransient<INumberService, NumberService>();
            services.AddTransient<ITitlesService, TitlesService>();
            services.AddSingleton<ISessionBasket, SessionBasket>();
            services.AddTransient<ITokenGenerator, TokenGenerator>();
            services.AddSingleton<ISessionChecker, SessionChecker>();
            services.AddTransient<IUnitOfWorkRepo, UnitOfWorkRepo>();            
            services.AddTransient<ITurnOverService, TurnOverService>();
            services.AddTransient<IStringExtensions, StringExtensions>();
            services.AddTransient<IJsonResultFacade, JsonResultFacade>();
            services.AddTransient<IDependantsService, DependantsService>();
            services.AddTransient<IT24AccountService, T24AccountService>();
            services.AddTransient<ISessionBridgeService, SessionBridgeService>();
            services.AddTransient<IRelationshipsService, RelationshipsService>();
            services.AddTransient<ISessionBridgeService, SessionBridgeService>();
            services.AddTransient<ISystemSettingsService, SystemSettingsService>();            
            services.AddTransient<IUnsubscriptionService, UnsubscriptionService>();
            services.AddSingleton<ISessionBridgeVmManager, SessionBridgeVmManager>();            
            services.AddTransient<IAccountSettingsService, AccountSettingsService>();
            services.AddTransient<IPortalUserActionsService, PortalUserActionsService>();

            services.AddDbContext<BancassuranceContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Bancassurance")), ServiceLifetime.Transient);

            services.AddAutoMapper(typeof(Startup));

            SetupAuthentication(services);

            SetupPolicies(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bancassurance V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void SetupAuthentication(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration.GetSection("Jwt:Issuer").Get<string>(),
                        ValidAudience = Configuration.GetSection("Jwt:Audience").Get<string>(),
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("Jwt:SecretKey").Get<string>())),
                        ClockSkew = TimeSpan.Zero
                    };
                }
                );
        }

        private void SetupPolicies(IServiceCollection services)
        {
            services.AddAuthorization(config =>
            {
                config.AddPolicy(Policies.User, Policies.UserPolicy());
                config.AddPolicy(Policies.Admin, Policies.AdminPolicy());                
                config.AddPolicy(Policies.SuperAdmin, Policies.SuperAdminPolicy());
            });
        }
    }
}
