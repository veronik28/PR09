using ConsoleApp1.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP
{
    public class Payroll
    {
        public void PrintSalary(EmployeeBase employee)
        {
            Console.WriteLine($"Работник: {employee.Name}, Шекели: {employee.CalculateSalary()}");
        }
    }
}
