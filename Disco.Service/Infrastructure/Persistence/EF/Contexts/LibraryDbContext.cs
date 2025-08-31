using Disco.Service.Domain.Disco.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Disco.Service.Infrastructure.Persistence.EF.Contexts
{
    public partial class DiscoDbContext : DbContext
    {
        public DiscoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Configurations.MusicianConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.AlbumConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
