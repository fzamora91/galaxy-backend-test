using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Utils.UpdatePartial
{
    public sealed class UpdatePartialDelta
    {
        public Guid EntityId { get; set; }
        public IReadOnlyCollection<UpdatePartialOperation> Operations { get; set; } = new List<UpdatePartialOperation>();
    }
}
