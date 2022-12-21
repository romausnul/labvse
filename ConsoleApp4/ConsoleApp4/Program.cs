using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст полностью");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последнюю цифру вашего возраста");
            int u = Convert.ToInt32(Console.ReadLine());

            switch (u)
            {
                case 1:
                    Console.WriteLine($"Мне {k} год");
                break;

                case 2: case 3: case 4:
                    Console.WriteLine($"Мне {k} года");
                break;

                case 5: case 6: case 7: case 8: case 9:
                    Console.WriteLine($"Мне {k} лет");
                break;

                default:
                    Console.WriteLine("Н/Д");
                break;
            }
            Console.ReadKey();
        }
    }
}