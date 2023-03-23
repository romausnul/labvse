using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            while (a < 1000)
            {
                if ((a % 47) == 43)
                    Console.WriteLine($"Остаток от деления {a}");
                a += 1;
            }
            a = 100;
            while (a < 1000)
            {
                if ((a % 43) == 47)
                    Console.WriteLine($"Остаток от деления {a}");
                a += 1;
            }
            Console.WriteLine("нет остатка 47 от деления на 43");
            Console.ReadKey();
        }
    }
}
