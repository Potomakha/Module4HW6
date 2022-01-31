using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entities;

namespace Module4HW6.EntityConfigs
{
    public class SongConfig : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(s => s.SongId);
            builder.Property(s => s.SongId).ValueGeneratedOnAdd();
            builder.Property(s => s.Title).IsRequired();
            builder.Property(s => s.Duration).IsRequired();
            builder.Property(s => s.ReleaseDate).IsRequired();
            builder.HasOne(s => s.Genre)
                .WithMany(g => g.Songs)
                .HasForeignKey(s => s.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
