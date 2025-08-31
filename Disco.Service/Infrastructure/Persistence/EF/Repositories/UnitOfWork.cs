using Disco.Service.Domain.Disco.Interfaces;
using Disco.Service.Infrastructure.Persistence.EF.Contexts;
using Infrastructure.Persistences.EF.Relational.Generic.Repositories;

namespace Disco.Service.Infrastructure.Persistence.EF.Repositories
{
    public class UnitOfWork : GenericUnitOfWork<DiscoDbContext>, IUnitOfWork
    {
        public IMusicianRepository Musician { get; }

        

        public UnitOfWork(
            DiscoDbContext context,
            IMusicianRepository musician
        ) : base(context)
        {
            Musician = musician;
        }
    }
}
