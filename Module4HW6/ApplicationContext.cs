using System;
using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;
using Module4HW6.EntityConfigs;

namespace Module4HW6
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfig());
            modelBuilder.ApplyConfiguration(new SongConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
        }
    }
}