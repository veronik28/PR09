using ConsoleApp1.DIP;
using ConsoleApp1.ISP;
using ConsoleApp1.LSP;
using ConsoleApp1.OCP;
using ConsoleApp1.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Принцип единственной ответственности
            var employee = new Employee { Name = "Иван Ивановидзе", Position = "Разработник" };
            var salaryCalculator = new SalaryCalculator();
            Console.WriteLine($"Шекели: {salaryCalculator.CalculateSalary(employee)}");

            // Принцип открытости/закрытости
            EmployeeBase fullTime = new FullTimeEmployee { Name = "Че Гевара" };
            EmployeeBase partTime = new PartTimeEmployee { Name = "Владимир Ильич" };
            Console.WriteLine($"{fullTime.Name} и его шекели: {fullTime.CalculateSalary()}");
            Console.WriteLine($"{partTime.Name}'и его шекели: {partTime.CalculateSalary()}");

            // Принцип подстановки Лисков
            var payroll = new Payroll();
            payroll.PrintSalary(fullTime);
            payroll.PrintSalary(partTime);

            // Принцип разделения интерфейсов
            IWorkable manager = new Manager();
            IWorkable developer = new Developer();
            manager.Work();
            developer.Work();

            // Принцип инверсии зависимостей 
            IEmployeeRepository repository = new EmployeeRepository();
            var processor = new EmployeeProcessor(repository);
            processor.ProcessEmployee("Имя Фамилия");
        }
    }
}
