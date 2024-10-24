using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP
{
    public class EmployeeProcessor
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeProcessor(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void ProcessEmployee(string employeeName)
        {
            var employee = _employeeRepository.GetEmployee(employeeName);
        }
    }
}
