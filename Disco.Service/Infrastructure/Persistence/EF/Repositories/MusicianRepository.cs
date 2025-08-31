using Disco.Service.Domain.Disco.Entities;
using Disco.Service.Domain.Disco.Interfaces;
using Disco.Service.Infrastructure.Persistence.EF.Contexts;
using Infrastructure.Persistences.EF.Relational.Generic.Repositories;

namespace Disco.Service.Infrastructure.Persistence.EF.Repositories
{
    public class MusicianRepository : Repository<Musician, DiscoDbContext>, IMusicianRepository
    {
        public MusicianRepository(DiscoDbContext context) : base(context)
        {
        }
    }
}
