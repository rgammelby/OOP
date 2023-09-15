using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class Model
    {
        // list of playlists
        public List<Playlist> Playlists = new List<Playlist>();
        
        // default playlist
        public Playlist InitializeDefaultPlaylist(Playlist p)
        {
            p.Tracks.AddLast(new Track("Tower of Power", "Tower of Power", "What is Hip?", 0, 304));
            p.Tracks.AddLast(new Track("Kool & The Gang", "Ladies' Night", "Ladies Night", 0, 386));
            p.Tracks.AddLast(new Track("Jaco Pastorius", "Jaco Pastorius", "Come On, Come Over", 0, 233));

            Playlists.Add(p);

            return p;
        }

        // adds a track to a playlist with array of track information
        public void AddTrack(Playlist p, string[] array)
        {
            p.Tracks.AddLast(new Track(array[0], array[1], array[2], byte.Parse(array[3]), short.Parse(array[4])));
        }

        // creates a new playlist with a given name
        public Playlist CreatePlaylist(string name)
        {
            Playlist p = new Playlist(name);

            Playlists.Add(p);

            return p;
        }

        // returns all playlists
        public List<Playlist> GetAllPlaylists()
        {
            return Playlists;
        }
        
        // returns specific playlist (by index)
        public Playlist GetPlaylist(int index)
        {
            index -= 1;

            var pl = Playlists[index];

            return pl;
        }
    }
}
