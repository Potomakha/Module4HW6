using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Module4HW6
{
    public class ContextBuilder : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new ApplicationContext(options);
        }
    }
}
