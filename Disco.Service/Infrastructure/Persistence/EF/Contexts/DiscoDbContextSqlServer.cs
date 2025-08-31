using Microsoft.EntityFrameworkCore;

namespace Disco.Service.Infrastructure.Persistence.EF.Contexts
{
    public class DiscoDbContextSqlServer : DiscoDbContext
    {
        public DiscoDbContextSqlServer(DbContextOptions<DiscoDbContextSqlServer> options) : base(options) { }
    }
}
