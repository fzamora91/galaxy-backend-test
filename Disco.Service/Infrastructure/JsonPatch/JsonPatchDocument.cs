namespace Disco.Service.Infrastructure.JsonPatch
{
    public partial class JsonPatchDocument<T>
    {
        public List<JsonPatchOperation> Operations { get; }

        public JsonPatchDocument(List<JsonPatchOperation> ops)
        {
            Operations = ops;
        }


    }
}
