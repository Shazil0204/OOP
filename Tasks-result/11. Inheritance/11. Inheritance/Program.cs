using _11.Inheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sweeper sweeper = new Sweeper("First Name", "Last Name", "CPR");
            Employee manager = new Employee("First Name", "Last Name", "CPR"); // This won't worl because this is outside the scoop
            ProjectManager ProjectManager1 = new ProjectManager("First Name", "Last Name", "CPR", 1, "EMAIL");

            Console.WriteLine(ProjectManager1.ToString());
            

            Console.WriteLine(sweeper.ToString());

        }
    }
}
