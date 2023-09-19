using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Kris_Arv_Opgave.Model
{
    internal class EmployeeList
    {
        #region Lists
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<CFO_Manager> CFOMangers { get; set; } = new List<CFO_Manager>();
        public List<COO_Manager> COOManagers { get; set; } = new List<COO_Manager>();
        public List<CFO> CFOs { get; set; } = new List<CFO>();
        public List<COO> COOs { get; set; } = new List<COO>();
        public CEO ChiefExecutive { get; set; }
        #endregion

        #region Methods
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public void AddCFOManager(CFO_Manager manager)
        {
            CFOMangers.Add(manager);
        }

        public void RemoveCFOManager(CFO_Manager manager)
        {
            CFOMangers.Remove(manager);
        }

        public void AddCOOManager(COO_Manager manager)
        {
            COOManagers.Add(manager);
        }

        public void RemoveCOOManager(COO_Manager manager)
        {
            COOManagers.Remove(manager);
        }

        public void SetCEO(CEO ceo)
        {
            ChiefExecutive = ceo;
        }

        public void AddCFO(CFO cfo)
        {
            CFOs.Add(cfo);
        }

        public void AddCOO(COO coo)
        {
            COOs.Add(coo);
        }
        #endregion
    }
}
