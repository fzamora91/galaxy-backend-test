using Microsoft.EntityFrameworkCore;
using SharedKernel.Domain.Interfaces;
using System.Linq.Expressions;

namespace Infrastructure.Persistences.EF.Relational.Generic.Repositories
{
    public class GenericRepository<T, TDbContext>
        : ReadOnlyRepository<T, TDbContext>, IGenericRepository<T>
        where T : class
        where TDbContext : DbContext
    {

        public GenericRepository(TDbContext context)
           : base(context)
        {
        }

        public virtual async Task AddAsync(T entity)
            => await _context.Set<T>().AddAsync(entity);

        public virtual void Update(T entity)
           => _context.Set<T>().Update(entity);

        public virtual void Upsert(T entity)
            => _context.Set<T>().Update(entity);

        public virtual void Remove(T entity)
            => _context.Set<T>().Remove(entity);

    }
}
