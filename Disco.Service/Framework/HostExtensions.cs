using Disco.Service.Framework.Data;
using Disco.Service.Framework.DI;
using Disco.Service.Framework.Web;
using Disco.Service.Infrastructure.JsonPatch;
using Library.Service.Infrastructure.JsonPatch;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Scalar.AspNetCore;



namespace Disco.Service.Framework
{
    public static class HostExtensions
    {
        public static IServiceCollection AddHostServices(this IServiceCollection services, IConfigurationManager configuration)
        {
            services.AddPersistence(configuration);
            services.AddMappings();
            services.AddApplication();
            services.AddJsonPatchSupport();
            services.AddEndpointVersioning();
            services.AddOpenApi();

            return services;
        }
        public static async Task<WebApplication> UseHostSetupAsync(this WebApplication app)
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options => { options.Servers = Array.Empty<ScalarServer>(); });
            app.MapAllEndpoints();
            await app.SeedDatabaseAsync();

            return app;
        }
    }
}
