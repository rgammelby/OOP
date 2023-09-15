using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class Track
    {
        private string _artist;
        private string _album;
        private string _title;
        private string _genre;
        private short _runtime;  // seconds

        enum Genres { Funk, Folk, Electronic, Punk, Hiphop, Jazz }

        public string Artist
        {
            get { return _artist; }
            private set { _artist = value; }
        }

        public string Album
        {
            get { return _album; }
            private set { _album = value; }
        }

        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        public string Genre
        {
            get { return _genre; }
            private set { _genre = value; }
        }

        public short Runtime
        {
            get { return _runtime; }
            private set { _runtime = value; }
        }

        public Track(string artist, string album, string title, byte genre, short runtime)
        {
            _artist = artist;
            _album = album;
            _title = title;
            _genre = ((Genres)genre).ToString();
            _runtime = runtime;
        }
    }
}
