using Breeding_station.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_station.View
{
    internal class MainView
    {
        internal void GUI(string output)
        {
            Console.WriteLine(output);
        }

        internal void SoundGUI(string output)
        {
            Console.WriteLine("This is how this animal sound like: " + output + "\n");
        }

        internal void Count(int i)
        {
            Console.Write(i + "\t");
        }
    }
}
