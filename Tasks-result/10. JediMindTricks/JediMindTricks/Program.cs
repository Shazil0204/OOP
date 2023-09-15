using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> characters = new Dictionary<string, int>() 
            { 
                { "Luke", 1 }, 
                { "Han", 2 }, 
                { "Chewbacca", 3 } 
            };

            characters.Remove("Luke");
            characters.Add("Anakin", 1);
            foreach (var items in characters)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }
    }
}
