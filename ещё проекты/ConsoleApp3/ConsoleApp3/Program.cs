using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код товара");
            int k = Convert.ToInt32(Console.ReadLine());

            switch (k)
            {
                case 1:
                    Console.WriteLine("Ручка");

                    break;

                case 2:
                    Console.WriteLine("Пакет");

                    break;

                case 3:
                    Console.WriteLine("Вода");

                    break;

                default:
                    Console.WriteLine("товара не существует");

                    break;
            }

            Console.ReadKey();
        }
    }
}
