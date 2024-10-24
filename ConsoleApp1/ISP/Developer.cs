using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ISP
{
    public class Developer : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Разработчик разрабатывает...");
        }
    }
}
