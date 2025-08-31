using Disco.Service.Application.UseCases.Musician.Mappings;
using Disco.Service.Framework.Rest.Mappings;

namespace Disco.Service.Framework.DI
{
    public static class MappingExtensions
    {
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<MusicianProfile>();

                cfg.AddProfile<RestProfile>();
            });

            return services;
        }
    }
}
