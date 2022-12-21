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
            double r1 = 0;
            double r2 = 0;
            double gena = 0;

            Console.WriteLine("Введите тип сопротивления");
            string tip = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите сопротивление R1");
            r1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сопротивление R2");
            r2 = Convert.ToDouble(Console.ReadLine());

            if (tip == "последовательное")
            {
                gena = r1 + r2;
            }

            if (tip == "параллельное")
            {
                gena = (r1 * r2) / (r1 + r2);
            }

            Console.WriteLine($"Гена доволен: Сопротивление = {gena}");
            Console.ReadKey();


        }
    }
}
