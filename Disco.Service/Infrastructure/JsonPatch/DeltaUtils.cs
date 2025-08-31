using SharedKernel.Utils.UpdatePartial;
using Disco.Service.Framework.Rest.Models.Requests;
using SharedKernel.Utils;
using SharedKernel.Utils.UpdatePartial;
using System;

namespace Disco.Service.Infrastructure.JsonPatch
{
    public static class DeltaUtils
    {
        public static UpdatePartialDelta FromPatch(JsonPatchDocument<UpdatePartialMusicianRequest> patchDoc)
        {
            return new UpdatePartialDelta
            {
                Operations = patchDoc.Operations
                    .Where(operations => string.Equals(operations.Op.ToString(), "replace", StringComparison.OrdinalIgnoreCase))
                    .Select(operations => new UpdatePartialOperation(operations.Op.ToString(), operations.Path, operations.Value))
                    .ToList()
            };
        }
    }
}
