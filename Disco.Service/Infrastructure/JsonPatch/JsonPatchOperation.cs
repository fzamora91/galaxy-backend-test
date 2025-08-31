using Library.Service.Infrastructure.JsonPatch;
using System.Text.Json;

namespace Disco.Service.Infrastructure.JsonPatch
{
    public class JsonPatchOperation
    {
        public JsonPatchOperationType Op { get; set; }
        public string Path { get; set; }
        public string From { get; set; }
        public JsonElement Value { get; set; }
    }
}
