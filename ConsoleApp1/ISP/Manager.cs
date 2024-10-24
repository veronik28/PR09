using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ISP
{
    public class Manager : IWorkable, IReportable
    {
        public void Work()
        {
            Console.WriteLine("Манагер манагерирует...");
        }

        public void CreateReport()
        {
            Console.WriteLine("Отчёты пишутся...");
        }
    }
}
