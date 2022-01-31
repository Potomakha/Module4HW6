using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Module4HW6.Entities;

namespace Module4HW6
{
    public class DebugInitializer : IDataInitialize
    {
        public async Task Initialize(ApplicationContext context)
        {
            Genre[] genres =
            {
                new Genre { Title = "Rock" },
                new Genre { Title = "Blues" },
                new Genre { Title = "metal" },
                new Genre { Title = "hip-hop" },
                new Genre { Title = "folk" }
            };
            Song[] songs =
            {
                new Song { Title = "Song-2", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01), Genre = genres[0] },
                new Song { Title = "Swoke on the water", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01), Genre = genres[1] },
                new Song { Title = "Щедрівка", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01), Genre = genres[1] },
                new Song { Title = "Tranz", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01), Genre = genres[2] },
                new Song { Title = "highway to hell", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01), Genre = genres[4] }
            };

            Artist[] artists =
            {
                new Artist { Name = "perviy", DateOdBirth = new DateTime(1999, 11, 15), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222, Songs = new List<Song> { songs[0], songs[2] } },
                new Artist { Name = "vtoroy", DateOdBirth = new DateTime(2002, 05, 03), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222, Songs = new List<Song> { songs[1], songs[3] } },
                new Artist { Name = "tretiy", DateOdBirth = new DateTime(2013, 01, 16), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222, Songs = new List<Song> { songs[4] } },
                new Artist { Name = "chetvertiy", DateOdBirth = new DateTime(2020, 12, 20), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222, Songs = new List<Song> { songs[4], songs[2] } },
                new Artist { Name = "5", DateOdBirth = new DateTime(1975, 02, 02), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222 }
            };
            await context.AddRangeAsync(genres);
            await context.SaveChangesAsync();
            await context.AddRangeAsync(songs);
            await context.SaveChangesAsync();
            await context.AddRangeAsync(artists);
            await context.SaveChangesAsync();
        }
    }
}
