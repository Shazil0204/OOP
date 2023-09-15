using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Model
{
    internal class Playlist
    {
        private string _playlistName;

        public string PlaylistName { get { return _playlistName; } set { _playlistName = value; } }

        public LinkedList<Track> tracks = new LinkedList<Track>();

        public Playlist() { PlaylistName = "Default Name!"; }

        public Playlist(string PlayListName)
        {
            PlayListName = PlaylistName;
        }
    }
}
