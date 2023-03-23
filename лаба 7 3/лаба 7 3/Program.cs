using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2000;
            int b = 1;
            do
            {
                a = a + (a * 0.025);
                b = b + 1;
            }
            while (a == 0.5);
            Console.WriteLine($"Через {b} лет урожайность увеличится в 2 раза");
            Console.ReadKey();
        }
    }
}
