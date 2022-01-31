using System.Collections.Generic;

namespace Module4HW6.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Title { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
