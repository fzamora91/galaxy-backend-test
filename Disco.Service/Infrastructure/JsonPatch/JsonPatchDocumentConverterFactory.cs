using System.Text.Json;
using System.Text.Json.Serialization;

namespace Disco.Service.Infrastructure.JsonPatch
{
    public class JsonPatchDocumentConverterFactory : JsonConverterFactory
    {

        public override bool CanConvert(Type typeToConvert)
           => typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(JsonPatchDocument<>);

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var elementType = typeToConvert.GetGenericArguments()[0];
            var converterType = typeof(JsonPatchDocumentConverter<>).MakeGenericType(elementType);
            return (JsonConverter)Activator.CreateInstance(converterType)!;
        }

    }
}
