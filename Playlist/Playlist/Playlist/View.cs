using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class View
    {
        // accepts single key user input
        public ConsoleKey Input()
        {
            var selection = Console.ReadKey(true).Key;

            return selection;
        }

        // accepts string user input
        public string InputLine()
        {
            var selection = Console.ReadLine();

            return selection;
        }

        // display start menu
        public void Menu()
        {
            Console.Clear(); 

            Console.WriteLine($"Welcome. \n" +
                $"Your options: \n\n" +
                $"[ 1 ] View all playlists \n" +
                $"[ 2 ] Create new playlist \n" +
                $"[ Esc ] Quit \n");
        }

        // display playlist menu
        public void PlaylistMenu()
        {
            Console.WriteLine("[ 1 ] Add new track \n" +
                "[ Esc ] Quit \n");
        }

        // display interface for adding a new track
        public (int, int)[] AddTrackMenu()
        {
            (int, int)[] coords = new (int, int)[5];

            Console.Clear();

            Console.WriteLine("New track: \n\n");
            Console.Write("Title: ");
            coords[0] = (Console.CursorLeft, Console.CursorTop);
            Console.Write("\nArtist: ");
            coords[1] = (Console.CursorLeft, Console.CursorTop);
            Console.Write("\nAlbum: ");
            coords[2] = (Console.CursorLeft, Console.CursorTop);
            Console.Write("\nGenre (index): ");
            coords[3] = (Console.CursorLeft, Console.CursorTop);
            Console.Write("\nRuntime (seconds): ");
            coords[4] = (Console.CursorLeft, Console.CursorTop);
            Console.Write("\nGenres: Funk = 0, Folk, Electronic, Punk, Hiphop, Jazz\n");

            return coords;
        }

        // display prompt for playlist name
        public void CreatePlaylistMenu()
        {
            Console.WriteLine("Playlist name: \n");
        }

        // prints names of all playlists
        public void PrintAllPlaylists(List<Playlist> lp)
        {
            Console.Clear();

            var pc = 0; 

            foreach (Playlist playlist in lp)
            {
                pc++;
                Console.WriteLine($"({pc}) {playlist.Name}");
            }
        }

        // prints all info of all elements in a playlist
        public void PrintPlaylist(Playlist playlist)
        {
            Console.Clear();

            foreach (Track track in playlist.Tracks)
            {
                Console.WriteLine($"{playlist.Name} \n" +
                    $"Title: {track.Title} \n" +
                    $"Artist: {track.Artist} \n" +
                    $"Album: {track.Album} \n" +
                    $"Genre: {track.Genre} \n" +
                    $"Runtime: {track.Runtime / 60}:{(track.Runtime % 60).ToString("00")} \n");
            }
        }

        // reads from a specific point on the console
        public string ReadAt((int, int) loc)
        {
            Console.SetCursorPosition(loc.Item1, loc.Item2);
            return Console.ReadLine();
        }
    }
}
