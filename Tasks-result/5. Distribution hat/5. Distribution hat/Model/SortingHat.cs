using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Distribution_hat.Model
{

    enum HogwartsHouse {Gryffindor=1, Hufflepuff, Ravenclaw, Slytherin};

    internal class SortingHat
    {
        // Method to randomly assign a Hogwarts house
        public HogwartsHouse Assign()
        {
            // Generate a random number between 1 and 4 because the first enum is define as 1
            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            // Convert the random number to a HogwartsHouse enum value
            HogwartsHouse Assign = (HogwartsHouse)randomNumber;

            return Assign;
        }
    }
}
