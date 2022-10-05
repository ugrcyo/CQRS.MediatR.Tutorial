using Microsoft.OpenApi.Models;
using System.Reflection;
using DAL.CQRS.Handlers.CommandHandlers;
using DAL.CQRS.Handlers.QueryHandlers;
using MediatR;
using CQRS.DAL;

namespace Developers.Tutorial.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<CreateCommandHandler>();
            services.AddTransient<DeleteCommandHandler>();
            services.AddTransient<GetAllQueryHandler>();
            services.AddTransient<GetByIdQueryHandler>();

            services.AddMediatR(typeof(ApplicationDbContext));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CQRSTutorialMediatR", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CQRSTutorialMediatR v1"));
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
