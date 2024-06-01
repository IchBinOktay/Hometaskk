using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task13.genre;

namespace Task13
{
    internal class Song
    {
        public string Title { get; set; }

        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, string artist, TimeSpan duration, Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }
        internal void GetDetails(Song song)
        {
            Console.WriteLine($"{song.Title}, {song.Artist}, {song.Duration},{song.Genre}");
        }
    }
}
