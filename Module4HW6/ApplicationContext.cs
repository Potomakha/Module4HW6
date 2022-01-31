using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;
using Module4HW6.EntityConfigs;

namespace Module4HW6
{
    public class ApplicationContext : DbContext
    {
        private IDataInitialize _initializer;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            _initializer = new DebugInitializer();
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfig());
            modelBuilder.ApplyConfiguration(new SongConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());

            _initializer.Initialize(modelBuilder);
        }
    }
}