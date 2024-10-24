using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OCP
{
    public class PartTimeEmployee : EmployeeBase
    {
        public override decimal CalculateSalary()
        {
            return 1500m;
        }
    }
}
