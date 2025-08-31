using Disco.Service.Application.UseCases.Musician.Commands.CreateMusician;
using Disco.Service.Application.UseCases.Musician.Interfaces;
using Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians;
using Disco.Service.Application.UseCases.Musician.Services;
using SharedKernel.Application.UseCases.Interfaces;


namespace Disco.Service.Framework.DI
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IQueryUseCase<GetAllMusiciansQuery, GetAllMusiciansResult>, GetAllMusicianUseCase>();
            return services;
        }
    }
}
