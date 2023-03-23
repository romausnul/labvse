using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 0;
            int c = 0;
            do
            {
                c = Convert.ToInt32(Math.Pow(a, b));
                if (b != 11 && b != 14) Console.WriteLine($"{a} в степени {b} = {c}");
                b += 1;
            }
            while (b <= 20);
            Console.ReadKey();
        
        }
    }
}
