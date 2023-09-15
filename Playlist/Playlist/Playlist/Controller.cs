using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class Controller
    {
        View GUI = new View();
        Model m = new Model();

        // initializes default playlist and starts program
        public void Start()
        {
            InitializeDefault();
            Menu();
        }

        // main loop
        public void Menu()
        {
            while (true)
            {
                GUI.Menu();
                MenuSelection();
            }
        }

        // user action
        public void MenuSelection()
        {
            switch (GUI.Input())
            {
                case ConsoleKey.D1:
                    // show all playlists
                    GUI.PrintAllPlaylists(m.GetAllPlaylists());
                    PlaylistSelection();
                    break;

                case ConsoleKey.D2:
                    // create new playlist
                    CreatePlaylist();
                    break;

                case ConsoleKey.Escape:
                    // quit
                    Environment.Exit(0);
                    break;
            }
        }

        public void CreatePlaylist()
        {
            GUI.CreatePlaylistMenu();
            m.CreatePlaylist(GUI.InputLine());
        }

        // displays contents of chosen playlist
        public void PlaylistSelection()
        {
            var selection = GUI.InputLine();

            var p = m.GetPlaylist(Convert.ToInt32(selection));
            GUI.PrintPlaylist(p);

            // user action
            PlaylistSelectionMenu(p); 
        }

        // add new track or return to main menu
        public void PlaylistSelectionMenu(Playlist p)
        {
            GUI.PlaylistMenu();

            switch (GUI.Input())
            {
                case ConsoleKey.D1:
                    AddTrack(p);
                    break;

                case ConsoleKey.Escape:
                    return;
            }
        }

        // retrieves track data and adds new track to chosen playlist
        public void AddTrack(Playlist p)
        {
            var location = GUI.AddTrackMenu();
            var trackData = AddTrackData(location);
            m.AddTrack(p, trackData);
        }

        // stores and returns user input strings
        public string[] AddTrackData((int, int)[] coords)
        {
            string[] track = new string[5];

            for (int i = 0; i < coords.Length; i++)
            {
                track[i] = GUI.ReadAt(coords[i]);
            }

            return track;
        }

        // initializes a default funk playlist
        public void InitializeDefault()
        {
            Playlist defaultPlaylist = new Playlist("Funk");
            m.InitializeDefaultPlaylist(defaultPlaylist);
        }
    }
}
