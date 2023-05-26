using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
    {
        class Program
        {
            static void Main(string[] args)
            {
                int e;
                int r;

                for (int i = 0; i < 21; i++)
                {
                    r = 1;
                    e = i;

                    while (e > 0)
                    {
                        r *= 2;
                        e--;
                    }
                    Console.WriteLine("2 в степени " + i + " равно " + r);
                }
                Console.ReadKey();
            }
        }
 }



