using Microsoft.EntityFrameworkCore;
using SharedKernel.Domain.Interfaces;
using SharedKernel.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistences.EF.Relational.Generic.Repositories
{
    public class QueryService<T, TDbContext> : IQueryService<T>
      where T : class
      where TDbContext : DbContext
    {
        protected readonly TDbContext _context;

        public QueryService(TDbContext context)
        {
            _context = context;
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().AsNoTracking()
                .FirstOrDefaultAsync(e => Microsoft.EntityFrameworkCore.EF.Property<Guid>(e, "Id") == id);
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }
        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
        }
        public virtual async Task<IEnumerable<T>> FindAsync(ISpecification<T> specification)
        {
            return await _context.Set<T>().AsNoTracking().Where(specification.Criteria).ToListAsync();
        }
        public virtual async Task<bool> AnyAsync()
        {
            return await _context.Set<T>().AnyAsync();
        }
        public virtual async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AnyAsync(predicate);
        }
    }
}
