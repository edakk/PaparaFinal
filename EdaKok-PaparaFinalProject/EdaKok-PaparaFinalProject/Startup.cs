using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Papara.Data.Context;
using Papara.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Papara.Services.Concretes;
using Papara.Data.Abstracts;
using Papara.Data.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace EdaKok_PaparaFinalProject
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EdaKok_PaparaFinalProject", Version = "v1" });
            });
            services.AddDbContext<FDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
          

            services.AddTransient<IUserService, UserService>();
            services.AddTransient(typeof(IUserRepository<>), typeof(UserRepository<>));
            services.AddTransient<IApartmentService, ApartmentService>();
            services.AddTransient(typeof(IApartmentRepository<>), typeof(ApartmentRepository<>));

            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient(typeof(IInvoiceRepository<>), typeof(InvoiceRepository<>));
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient(typeof(IMessageRepository<>), typeof(MessageRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EdaKok_PaparaFinalProject v1"));
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
