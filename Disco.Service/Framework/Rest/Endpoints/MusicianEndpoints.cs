using Asp.Versioning;
using Asp.Versioning.Builder;



namespace Disco.Service.Framework.Rest.Endpoints
{
    public static class MusicianEndpoints
    {
        public static void MapMusicianEndpoints(this IEndpointRouteBuilder app)
        {
            var apiVersionSet = app.NewApiVersionSet()
                .HasApiVersion(new ApiVersion(1, 0))
                .ReportApiVersions()
                .Build();

            var group = app.MapGroup("/api/v{version:apiVersion}/musician")
                            .WithApiVersionSet(apiVersionSet)
                            .WithTags("Musician v1");


        }
    }
}
