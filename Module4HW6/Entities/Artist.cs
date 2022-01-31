using System;
using System.Collections.Generic;

namespace Module4HW6.Entities
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public DateTime DateOdBirth { get; set; }
        public ulong Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
