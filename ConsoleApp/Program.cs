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
            Console.WriteLine("Ответьте на 5 вопросов получишь игоря");
            double a = 0;
            Console.WriteLine("Назавите устройства вывода");
            string y = Convert.ToString(Console.ReadLine());
            if (y == "Принтер")
            {
                Console.WriteLine("ОПА ПРАВИЛЬНО");
                a = a + 1;
            }
            else
            {
                Console.WriteLine("Неправильный ответ");
            }

            Console.WriteLine("Ростелеком топ?");
            y = Convert.ToString(Console.ReadLine());
            if (y == "да")
            {
                Console.WriteLine("Правильный ответ");
                a = a + 1;
            }
            else
            {
                Console.WriteLine("Неправильный ответ");
            }

            Console.WriteLine("Ты пользуешься интернетем?");
            y = Convert.ToString(Console.ReadLine());
            if (y == "да")
            {
                Console.WriteLine("Правильный ответ");
                a = a + 1;
            }
            else
            {
                Console.WriteLine("Неправильный ответ");
            }

            Console.WriteLine("У тебя есть пк?");
            y = Convert.ToString(Console.ReadLine());
            if (y == "нет")
            {
                Console.WriteLine("Правильный ответ");
                a = a + 1;
            }
            else
            {
                Console.WriteLine("Неправильный ответ");
            }

            Console.WriteLine("Ты играешьв танки?");
            y = Convert.ToString(Console.ReadLine());
            if (y == "нет")
            {
                Console.WriteLine("Правильный ответ");
                a = a + 1;
            }
            else
            {
                Console.WriteLine("Неправильный ответ");
            }
            Console.WriteLine($"Правильных ответов: {a}");
            double b = Convert.ToDouble((a / 5) * 100);
            Console.WriteLine($"Точность ответов: {b}%");
            if (b <= 40)
                Console.WriteLine("У тебя 2");
            if (b >= 50) || (b<=70)
                Console.WriteLine("Опа моя оценка  3");
            if (b >=80) || (b<=90)
                Console.WriteLine("ТЫ не отчислен значит 4 4");
            if ()
            Console.ReadKey();
        }
    }
}
