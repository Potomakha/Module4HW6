using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Module4HW6.Entities;

namespace Module4HW6
{
    public class DebugInitializer : IDataInitialize
    {
        public void Initialize(ModelBuilder modelBuilder)
        {
            var artists = new List<Artist>()
            {
                new Artist { ArtistId = 1, Name = "perviy", DateOdBirth = new DateTime(1999, 11, 15), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222 },
                new Artist { ArtistId = 2, Name = "vtoroy", DateOdBirth = new DateTime(2002, 05, 03), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222 },
                new Artist { ArtistId = 3, Name = "tretiy", DateOdBirth = new DateTime(2013, 01, 16), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222 },
                new Artist { ArtistId = 4, Name = "chetvertiy", DateOdBirth = new DateTime(2020, 12, 20), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222 },
                new Artist { ArtistId = 5, Name = "5", DateOdBirth = new DateTime(1975, 02, 02), Email = "qwee@gmail.com", InstagramUrl = "wqewqe", Phone = 222222222 }
            };

            var songs = new List<Song>()
            {
                new Song { SongId = 1, Title = "Song-2", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01) },
                new Song { SongId = 2, Title = "Swoke on the water", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01) },
                new Song { SongId = 3, Title = "Щедрівка", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01) },
                new Song { SongId = 4, Title = "Tranz", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01) },
                new Song { SongId = 5, Title = "highway to hell", Duration = 100, ReleaseDate = new DateTime(2020, 12, 01) }
            };

            var genre = new List<Genre>()
            {
                new Genre { GenreId = 1, Title = "Rock" },
                new Genre { GenreId = 2, Title = "Blues" },
                new Genre { GenreId = 3, Title = "metal" },
                new Genre { GenreId = 4, Title = "hip-hop" },
                new Genre { GenreId = 5, Title = "folk" }
            };
        }
    }
}
