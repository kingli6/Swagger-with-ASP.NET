using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace notesWebApi
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
            // Add your services here

            // Configure NSwag
            services.AddOpenApiDocument(settings =>
            {
                settings.Title = "notesWebApi";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Other middleware setup

            // Use NSwag
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
