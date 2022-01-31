using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entities;

namespace Module4HW6.EntityConfigs
{
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(a => a.ArtistId);
            builder.Property(a => a.ArtistId).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.DateOdBirth).IsRequired();
            builder.HasMany(a => a.Songs)
                .WithMany(s => s.Artists);
        }
    }
}
