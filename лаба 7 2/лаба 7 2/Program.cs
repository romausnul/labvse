using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 110000;
            int b = 2004;
            do
            {
                a = Convert.ToInt32(a + (a * 0.03));
                Console.WriteLine($"Численность населения за {b} год = {a}");
                b = b + 1;
            }
            while (b<=2030);
            Console.ReadKey();
        }

    }
}
