using Disco.Service.Domain.Disco.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Disco.Service.Infrastructure.Persistence.EF.Contexts.Configurations
{
    public class MusicianConfiguration : IEntityTypeConfiguration<Musician>
    {
        public void Configure(EntityTypeBuilder<Musician> builder)
        {
            builder.ToTable("Musician");

            builder.HasKey(a => a.Id);
            builder.Property(p => p.Id).HasColumnName("MusicianId");


            builder.HasMany(a => a.Albums)
                   .WithOne()
                   .HasForeignKey(b => b.MusicianId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
