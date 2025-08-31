using Asp.Versioning;
using Disco.Service.Framework.Rest.Endpoints;
using Disco.Service.Framework.Rest.Models.Requests;
using Disco.Service.Infrastructure.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Disco.Service.Framework.Web
{
    public static class EndpointExtensions
    {
        public static IServiceCollection AddEndpointVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(2, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
                options.ApiVersionReader = ApiVersionReader.Combine(
                   new UrlSegmentApiVersionReader(),
                   new HeaderApiVersionReader("X-Api-Version")
                );
            })
           .AddApiExplorer(options =>
           {
               options.GroupNameFormat = "'v'V"; // v1, v2, etc.
               options.SubstituteApiVersionInUrl = true;
           });

            return services;
        }

        public static IEndpointRouteBuilder MapAllEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapMusicianEndpoints();

            return app;
        }


    }



}
