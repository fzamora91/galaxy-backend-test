using Disco.Service.Infrastructure.JsonPatch;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Library.Service.Infrastructure.JsonPatch
{
    public static class JsonPatchExtensions
    {
        public static IServiceCollection AddJsonPatchSupport(this IServiceCollection services)
        {
            services.ConfigureHttpJsonOptions(opts =>
            {
                opts.SerializerOptions.Converters.Add(new JsonPatchDocumentConverterFactory());
                opts.SerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            });

            return services;
        }
    }
}
