using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Planet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instance of the controller class
            Controller.Controller maincontroller = new Controller.Controller();
            
            // My main controller that controlls my whole program
            maincontroller.MainController();
        }
    }
}
