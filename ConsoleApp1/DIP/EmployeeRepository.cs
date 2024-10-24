using ConsoleApp1.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee employee)
        {
            
        }

        public Employee GetEmployee(string name)
        {
            
            return new Employee { Name = name };
        }
    }
}
