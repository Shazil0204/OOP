using _5.Distribution_hat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Distribution_hat
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hogwarts!");

            // Instantiate the SortingHat
            SortingHat sortingHat = new SortingHat();

            // Call the AssignHouse method to determine the assigned house
            HogwartsHouse assignedHouse = sortingHat.Assign();

            // Display the assigned house to the user
            Console.WriteLine("The Sorting Hat has chosen your house:");

            switch (assignedHouse)
            {
                case HogwartsHouse.Gryffindor:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You belong to Gryffindor - for the brave and strong!");
                    Console.ResetColor();
                    break;
                case HogwartsHouse.Hufflepuff:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You belong to Hufflepuff - for the loyal and brave!");
                    Console.ResetColor();
                    break;
                case HogwartsHouse.Ravenclaw:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You belong to Ravenclaw - for the wide-ranging and intelligent!");
                    Console.ResetColor();
                    break;
                case HogwartsHouse.Slytherin:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You belong to Slytherin - for the cunning, strong-willed and who do not spare anything to achieve their goals!");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Sorting Hat couldn't decide!");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
