using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class Playlist
    {
        private string _name;
        private LinkedList<Track> _tracks;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public LinkedList<Track> Tracks
        {
            get { return _tracks; }
            private set { _tracks = value; }
        }

        public Playlist(string name)
        {
            _name = name;
            Tracks = new LinkedList<Track>();
        }
    }
}
