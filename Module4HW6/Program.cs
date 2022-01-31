using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;

namespace Module4HW6
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using (var context = new ContextBuilder().CreateDbContext(args))
            {
                if (context.Artists.FirstOrDefault() == null)
                {
                    var initializer = new DebugInitializer();
                    try
                    {
                        await initializer.Initialize(context);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                await FirstQueryAsync(context);
                await SecondQueryAsync(context);
                await ThirdQueryAsync(context);
                Console.WriteLine();
            }
        }

        private static async Task ThirdQueryAsync(ApplicationContext context)
        {
            var result = await context.Songs.Where(s => s.ReleaseDate < context.Artists.Min(a => a.DateOdBirth)).Select(s => s).ToListAsync();
            Console.WriteLine("Second");
            foreach (var item in result)
            {
                Console.WriteLine(item.Title);
            }
        }

        private static async Task SecondQueryAsync(ApplicationContext context)
        {
            var result = context.Songs.Include(s => s.Genre)
                .AsEnumerable()
                .GroupBy(s => s.GenreId).Select(s => new { Title = s.Key, Count = s.Count() }).AsEnumerable();

            Console.WriteLine("Second");
            foreach (var item in result)
            {
                Console.WriteLine(item.Title + " " + item.Count);
            }

            await Task.Delay(0);
        }

        private static async Task FirstQueryAsync(ApplicationContext context)
        {
            var result = await context.Songs
                .Include(s => s.Artists)
                .Include(s => s.Genre).ToListAsync();

            Console.WriteLine("First");
            foreach (var songs in result)
            {
                foreach (var artist in songs.Artists)
                {
                    Console.WriteLine(artist.Name + " " + songs.Title + " " + songs.Genre.Title);
                }
            }
        }
    }
}
