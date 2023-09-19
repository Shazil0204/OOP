using _11._1_Kris_Arv_Opgave.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Kris_Arv_Opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the EmployeeList instance
            EmployeeList employeeList = new EmployeeList();

            // Adding a CEO
            CEO ceo = new CEO("CEO", "John", "Doe", 50000, "Global Expansion");
            employeeList.SetCEO(ceo);

            // Adding a CFO and CFO Manager
            CFO cfo = new CFO("CFO", "Jane", "Smith", 45000, "Budget Optimization");
            employeeList.AddCFO(cfo);

            CFO_Manager cfoManager = new CFO_Manager("CFO Manager", "Alan", "White", 40000, "Team Leadership");
            employeeList.AddCFOManager(cfoManager);

            // Adding a COO and COO Manager
            COO coo = new COO("COO", "Emily", "Brown", 43000, "Operational Efficiency");
            employeeList.AddCOO(coo);

            COO_Manager cooManager = new COO_Manager("COO Manager", "Chris", "Green", 39000, "Process Improvement");
            employeeList.AddCOOManager(cooManager);

            // Adding Employees
            Employee emp1 = new Employee("Developer", "Ella", "Johnson", 30000, 22);
            Employee emp2 = new Employee("Designer", "Lucas", "Evans", 31000, 22);
            Employee emp3 = new Employee("Analyst", "Sophia", "Lee", 32000, 22);

            // Adding Emplyees into the list
            employeeList.AddEmployee(emp1);
            employeeList.AddEmployee(emp2);
            employeeList.AddEmployee(emp3);

            // Output to verify
            Console.WriteLine($"{employeeList.ChiefExecutive}");
            Console.WriteLine($"Number of CFOs: {employeeList.CFOs.Count}");
            Console.WriteLine($"Number of COOs: {employeeList.COOs.Count}");
            Console.WriteLine($"Number of Employees: {employeeList.Employees.Count}");
        }
    }
}
