using System;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.EntityFrameworkCore;
using DoeMaisApi.src.Infrastructure.Shared;
using DoeMaisApi.src.Application.Services;
using DoeMaisApi.src.Infrastructure.Configurations.Repositories;
using DoeMaisApi.src.Domain.Entities.DonorAggregate.Repositories;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate.Repositories;
using DoeMaisApi.src.Domain.Entities.DonationAggregate.Repositories;

namespace DoeMaisApi
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DoeMaisApi", Version = "v1" });
            });

            services.AddScoped<DonorAppService>();
            services.AddScoped<IDonorRepository, DonorRepository>();
            
            services.AddScoped<BloodCenterAppService>();
            services.AddScoped<IBloodCenterRepository, BloodCenterRepository>();
            
            services.AddScoped<DonationAppService>();
            services.AddScoped<IDonationRepository, DonationRepository>();

            services.AddDbContext<EFContext>(options => {
                options.UseSqlite(Configuration.GetConnectionString("sqlite"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => {
                    c.RoutePrefix = string.Empty;
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "DoeMaisApi v1");
                    }
                );
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
