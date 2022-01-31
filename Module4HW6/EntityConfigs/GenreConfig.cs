using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Entities;

namespace Module4HW6.EntityConfigs
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(g => g.GenreId);
            builder.Property(g => g.GenreId).ValueGeneratedOnAdd();
            builder.Property(g => g.Title).IsRequired();
        }
    }
}
