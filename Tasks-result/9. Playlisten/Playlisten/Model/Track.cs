using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Model
{
    internal class Track
    {
        private string _songName;
        private string _artist;
        private string _songWriter;
        private string _addDate;
        private string _songLength;

        private string songName { get { return _songName; } set { _songName = value;  } }
        private string artist { get { return _artist; } set { _artist = value; } }
        private string songWriter { get { return _songWriter; } set { _songWriter = value; } }
        private string addDate { get { return _addDate; } set { _addDate = value; } }
        private string songLength { get {  return _songLength; } set { _songLength = value; } }

        #region constructor
        public Track(string SongName, string Artist, string SongWriter, string AddDate, string SongLength)
        {
            SongName = songName;

            Artist = artist;

            SongWriter = songWriter;

            AddDate = addDate;

            SongLength  = songLength;
        }

        #endregion

    }
}
