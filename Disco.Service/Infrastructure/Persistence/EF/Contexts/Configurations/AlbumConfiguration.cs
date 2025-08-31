using Disco.Service.Domain.Disco.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Disco.Service.Infrastructure.Persistence.EF.Contexts.Configurations
{
    public class AlbumConfiguration: IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("AlbumId");
        }
    }
}
