using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RfidAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using RfidAPI.Models;
using RfidAPI.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace RfidAPI
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
            services.AddDbContext<DataContext>(opt => opt.UseSqlite(Configuration.GetConnectionString("DataContext")));
            services.AddDbContext<LibraryDbContext>(
                config => config.UseSqlite(Configuration.GetConnectionString("DefaultContext")));
            //optionBuilder => optionBuilder.MigrationAssembly(typeof(Startup).Assembly.GetName().Name)));

            services.AddScoped<UserService, UserServiceImpl>();
            services.AddScoped<RepoService, RepoServiceImpl>();
            services.AddScoped<PermissionService, PermissionServiceImpl>();
            services.AddScoped<LogService, LogServiceImpl>();
            services.AddScoped<EquipmentService, EquipmentServiceImpl>();
            services.AddScoped<DeviceCountService,DeviceCountServiceImpl>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "RfidAPI", Version = "v1"}); 
                c.IncludeXmlComments(AppDomain.CurrentDomain.BaseDirectory+"/RfidAPI.xml");
            });
            services.AddIdentity<IUser, IRole>()
                .AddEntityFrameworkStores<LibraryDbContext>();
            var tokenConfigSection = Configuration.GetSection("Security:Token");
            services.AddAuthentication(c =>
                {
                    c.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    c.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(c =>
                {
                    c.TokenValidationParameters = new TokenValidationParameters
                    {
                        
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        
                        ValidAudience = tokenConfigSection["Audience"],
                        ValidIssuer = tokenConfigSection["Issuer"],
                        IssuerSigningKey =
                            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfigSection["Key"])),
                        ClockSkew = TimeSpan.Zero
                    };
                
        });
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RfidAPI v1"));
            //app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseAuthentication();
            
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}