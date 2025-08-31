using Disco.Service.Application.Interfaces;
using Disco.Service.Domain.Disco.Interfaces;
using Disco.Service.Infrastructure.Persistence.EF.Contexts;
using Disco.Service.Infrastructure.Persistence.EF.Queries;
using Disco.Service.Infrastructure.Persistence.EF.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Disco.Service.Framework.DI
{
    public static class PersistenceExtensions
    {

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfigurationManager configuration)
        {
            services.AddLibraryContext(configuration);

            services.AddScoped<IMusicianRepository, MusicianRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IMusicianQueryService, MusicianQueryService>();

            return services;
        }
        private static IServiceCollection AddLibraryContext(this IServiceCollection services, IConfigurationManager configuration)
        {
            var selected = configuration["Database:Provider"];

            switch (selected)
            {
                case "SqlServer":
                    services.AddDbContext<DiscoDbContextSqlServer>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection")));
                    services.AddScoped<DiscoDbContext>(sp => sp.GetRequiredService<DiscoDbContextSqlServer>());
                    break;
              
            }

            return services;
        }

    }
}
