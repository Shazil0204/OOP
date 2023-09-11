using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Elon
{
    #region ControllerAndView
    internal class Program
    {
        #region MainMethod
        static void Main(string[] args)
        {
            // Creating car instances
            RCCar redCar = new RCCar();
            redCar.Color = "Red";

            RCCar yellowCar = new RCCar();
            yellowCar.Color = "Yellow";

            // you can add a while loop here and add this in it so the car will continue driving (Like this)

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                DriveCar(redCar);
            }

            // Driving and charging the cars
            DriveCar(redCar);
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.ForegroundColor = ConsoleColor.Yellow; 
            DriveCar(yellowCar);

            Console.ForegroundColor = ConsoleColor.Red; 
            ChargeCar(redCar);
            DriveCar(redCar);

            Console.ForegroundColor = ConsoleColor.Yellow; 
            ChargeCar(yellowCar);
            DriveCar(yellowCar);

            Console.ResetColor();
        }
        #endregion

        #region HelperMethods
        static void DriveCar(RCCar car)
        {
            Console.WriteLine("Driving the car...");
            car.Drive();
        }

        static void ChargeCar(RCCar car)
        {
            Console.WriteLine("Charging the car...");
            car.Charge();
        }
        #endregion
    }
    #endregion
}
