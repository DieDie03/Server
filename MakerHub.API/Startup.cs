using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MakerHub.DAL.Entities;
using MakerHub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakerHub.API.Services;

namespace MakerHub.API
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MakerHub.API", Version = "v1" });
            });
            // cors definit les règles d'accessibilité à l'API
            services.AddCors(options => options.AddPolicy("default", builder =>
            {
                //builder.WithOrigins("http://localhost:4200"); // API Privée
                builder.AllowAnyOrigin();/* API public*/
               // builder.WithMethods("GET");// autoriser uniquement la lecture
               builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));
            services.AddDbContext<MakerHubDBContext>();
            services.AddScoped<MakerHubService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("http://192.168.1.29/MakerHub.API/swagger/v1/swagger.json", "MakerHub.API v1"));

            app.UseHttpsRedirection();

            app.UseCors("default");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
