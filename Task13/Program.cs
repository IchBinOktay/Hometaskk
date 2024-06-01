using Task13;
using static Task13.genre;

Song song1 = new Song("sound of silence", "disturbed", new TimeSpan(00, 03, 00), Genre.Rock);
playlist playlist = new playlist();
playlist.AddSong(song1);
playlist.GetAll();
playlist.GetAllSongsByGenre(Genre.Rock);