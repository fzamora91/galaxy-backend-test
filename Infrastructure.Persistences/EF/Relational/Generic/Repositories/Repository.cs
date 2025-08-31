using Microsoft.EntityFrameworkCore;
using SharedKernel.Domain.Interfaces;


namespace Infrastructure.Persistences.EF.Relational.Generic.Repositories
{
    public class Repository<T, TDbContext>
        : GenericRepository<T, TDbContext>, IRepository<T>
        where T : class, IAggregateRoot
        where TDbContext : DbContext
    {
        public Repository(TDbContext context) : base(context) { }
    }
}
