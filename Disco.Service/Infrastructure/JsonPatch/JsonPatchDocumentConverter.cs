using System.Text.Json.Serialization;
using System.Text.Json;

namespace Disco.Service.Infrastructure.JsonPatch
{
    public class JsonPatchDocumentConverter<T> : JsonConverter<JsonPatchDocument<T>>
    {
        public override JsonPatchDocument<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            string rawJson = document.RootElement.GetRawText();

            var localOptions = new JsonSerializerOptions(options);
            localOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

            var operations = JsonSerializer.Deserialize<List<JsonPatchOperation>>(rawJson, localOptions);

            return new JsonPatchDocument<T>(operations);
        }

        public override void Write(Utf8JsonWriter writer, JsonPatchDocument<T> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Operations, options);
        }
    }
}
