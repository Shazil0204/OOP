using _6.Planet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Planet.View
{
    internal class View 
    { 
        Model.Lists lists = new Model.Lists();

        /// <summary>
        /// Just a break Line to tell user that here i end my task
        /// </summary>
        public void QuestionBreak()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
        }

        /// <summary>
        /// GUI to Welcome User
        /// </summary>
        public void StartingView()
        {
            Console.WriteLine(
                "Welcome to our planet program: \n" +
                "We start with a fun fact and that is: \n" +
                "did you know all the humans that have ever been born are only been born on planet earth! \n");
        }

        /// <summary>
        /// This method show all the data from the first list
        /// </summary>
        /// <param name="name"></param> Name
        /// <param name="mass"></param> Mass
        /// <param name="dia"></param>  Diameter
        /// <param name="den"></param>  Density
        /// <param name="gra"></param>  Gravity
        /// <param name="RP"></param>   RotationPeriod
        /// <param name="LoD"></param>  LengthOfDay
        /// <param name="DFS"></param>  DistanceFromSon
        /// <param name="OP"></param>   OrbitalPeriod
        /// <param name="OV"></param>   OrbitalVelocity
        /// <param name="MT"></param>   MeanTemperature
        /// <param name="NoM"></param>  NumberOfMoons
        /// <param name="RS"></param>   RingSystem
        public void outputGUI(string name, float mass, float dia, float den, float gra, float RP, float LoD, float DFS, float OP, float OV, short MT, sbyte NoM, bool RS)
        {
            string color = "\u001b[32m"; // Green color

            string resetcolor = "\u001b[0m"; // default color

            Console.WriteLine(
                $"Name:\t\t\t\t\t{color + name + resetcolor} \n" +
                $"Mass:\t\t\t\t\t{color + mass + resetcolor} \n" +
                $"Diameter:\t\t\t\t{color + dia + resetcolor} \n" +
                $"Density:\t\t\t\t{color + den + resetcolor} \n" +
                $"Gravity:\t\t\t\t{color + gra + resetcolor} \n" +
                $"Rotation Period:\t\t\t{color + RP + resetcolor} \n" +
                $"Length Of Day:\t\t\t\t{color + LoD + resetcolor} \n" +
                $"Distance from sun:\t\t\t{color + DFS + resetcolor} \n" +
                $"Orbitan Period:\t\t\t\t{color + OP + resetcolor} \n" +
                $"Orbitan Velocity:\t\t\t{color + OV + resetcolor} \n" +
                $"Mean Temperature:\t\t\t{color + MT + resetcolor} \n" +
                $"Number of Moons:\t\t\t{color + NoM + resetcolor} \n" +
                $"Does have a ring system:\t\t{color + RS + resetcolor} \n");
        }

        /// <summary>
        /// GUI to tell user that why am i removing Pluto
        /// </summary>
        public void RemovingPlutoGUI()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "In August 2006, the International Astronomical Union declared that Pluto was no longer considered a planet, " +
                "instead the planet was given the status of a so-called dwarf planet. Therefore, we will removed Pluto from the list.\n");
            Console.ResetColor();
        }

        /// <summary>
        /// GUI to tell user that i don't understand the reason of this task as well
        /// </summary>
        public void AddingPlutoAgainGUI()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "Pluto was removed earlier because that was told \n" +
                "but as we all do know your teachers want us to work extra hard \n" +
                "and that is why they want us to add pluto once again! :( :( :( :( :( :( :( \n");
            Console.ResetColor();
        }


        /// <summary>
        /// GUI to Show the total amount of lists inside my list
        /// </summary>
        /// <param name="count"></param>
        public void CountPlantes(byte count) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(count);
            Console.ResetColor();
        }

        /// <summary>
        /// GUI to tell user that over here i have all the Planets with mean temperature below 0°C:
        /// </summary>
        public void NewListStartingGUI()
        {
            Console.WriteLine("Planets with mean temperature below 0°C:");
        }

        /// <summary>
        /// This wiil take data from controller and then write it on Console
        /// </summary>
        /// <param name="name"></param>
        public void NewList(string name)
        {
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine(name);
            Console.ResetColor();
        }

        /// <summary>
        /// GUI to tell user that over here i have all the Planets with the diameter over 10000 and under 50000 km
        /// </summary>
        public void NewListDiameterGUI()
        {
            Console.WriteLine("Planets with the diameter over 10000 and under 50000 km");
        }

        /// <summary>
        /// This will take data from controller and then write it on Console
        /// </summary>
        /// <param name="name"></param>
        public void DiameterList(string name)
        {
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine(name);
            Console.ResetColor();
        }

        /// <summary>
        /// GUI to tell user that i have removed all the data from the lists
        /// </summary>
        public void RemovingListGUI()
        {
            Console.WriteLine("I have empty all the lists!");
        }
    }
}
