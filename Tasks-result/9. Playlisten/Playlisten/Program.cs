using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Testing

            Model.Playlist Playlist1 = new Model.Playlist("Playlist 1");

            Playlist1.tracks.AddFirst(new Model.Track("Zombie", "F4ST", "Dolores O'Riodan", "2 days ago", "2:41"));
            Playlist1.tracks.AddFirst(new Model.Track("The Start", "Zack Diamond", "Unkown", "2 days ago", "3:02"));
            Playlist1.tracks.AddFirst(new Model.Track("Ørn", "Jimilian", "BesiMadeThis, Gio, Jimilian, Jani The Pilot", "2 days ago", "2:07"));
            Playlist1.tracks.AddFirst(new Model.Track("Slowine", "Baloosh, DIBSET, Kamelen", "Baloosh, DIBSET, Kamelen, Marvin S", "2 days ago", "2:27"));
            Playlist1.tracks.AddFirst(new Model.Track("BORED", "HEDEGAARD", "Erik Smaaland, Kristoffer Chaka Bwanausi Tømmerbakke, Erik Gustaf Smaaland, Kyle Reynolds, Rasmus Hedegaard Nielsen", "2 days ago", "2:32"));

            Model.Playlist Playlist2 = new Model.Playlist("Playlist 2");

            Playlist2.tracks.AddLast(new Model.Track("Jumpin", "Hottub", "Thomas Berg", "2 days ago", "3:16"));
            Playlist2.tracks.AddLast(new Model.Track("Djoba", "Martin Jensen, DOLF", "Thom van der Bruggen, Martin Jensen", "2 days ago", "2:22"));
            Playlist2.tracks.AddLast(new Model.Track("Regard, RAYE", "Regard, RAYE", "Rachel Keen, John Hill, Jordan Asher Cruz, Kennedi Lykken, Regard, Stephen Feigenbaum", "2 days ago", "2:56"));
            Playlist2.tracks.AddLast(new Model.Track("Replay", "Justin Wellington", "Jason Desrouleaux, Jonathan Rotem, Keidran Jones, Kisean Anderson, Therom Thomas, Timothy Thomas", "2 days ago", "2:21"));
            Playlist2.tracks.AddLast(new Model.Track("Waves", "Mr. Probz, Robin Schulz", "Jihad Rahmouni, Mike Dean, Dennis Princewell Stehr", "2 days ago", "3:28"));

            #endregion
        }
    }
}
