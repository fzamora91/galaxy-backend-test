using SharedKernel.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Domain.Entities
{
    public abstract class Entity<TId> : IEntity<TId>
        where TId : notnull
    {
        public TId Id { get; protected set; }

        protected Entity()
        {
            Id = default!;
        }

        protected Entity(TId id)
        {
            Id = id;
        }
        public override bool Equals(object? obj)
        {
            if (obj is not Entity<TId> other)
                return false;

            return EqualityComparer<TId>.Default.Equals(Id, other.Id);
        }

        public override int GetHashCode() => Id!.GetHashCode();
    }
}
