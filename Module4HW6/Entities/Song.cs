using System;
using System.Collections.Generic;

namespace Module4HW6.Entities
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<Artist> Artists { get; set; } = new List<Artist>();
    }
}
