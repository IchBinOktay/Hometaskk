using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task13.genre;

namespace Task13
{
    internal class playlist
    {
        public Song[] songs = new Song[0];

        public void AddSong(Song song)
        {
            Array.Resize(ref songs, songs.Length + 1);
            songs[songs.Length - 1] = song;
        }

        public void GetAll()
        {
            foreach (Song song in songs)
            {
                song.GetDetails(song);
            }
        }

        public void GetAllSongsByGenre(Genre genre)
        {
            foreach (Song song in songs)
            {
                if (genre == song.Genre)
                {
                    song.GetDetails(song);
                }
            }
        }
    }
}
