using SharedKernel.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Domain.Entities
{
    public abstract class AggregateRoot<TId> : Entity<TId>, IAggregateRoot
        where TId : notnull
    {
        protected AggregateRoot(TId id) : base(id) { }
        protected AggregateRoot() : base(default!) { }
    }
}
