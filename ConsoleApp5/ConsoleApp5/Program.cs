using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день рождения");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год рождения");
            int y = Convert.ToInt32(Console.ReadLine());
            
            switch (y)
            {
                case 2007:
                    Console.WriteLine("Год Красной Огненной Свиньи");
                break;

                default:
                    Console.WriteLine("Н/Д");
                break;
            }
            switch (m)
            {
                case 1:
                    if (d >= 20 && d <= 31)
                    {
                        Console.WriteLine("Водолей");
                    }
                    if (d >= 1 && d <= 19)
                    {
                        Console.WriteLine("Козерог");
                    }
                break;
                
                case 2:
                    if (d >= 1 && d <= 18)
                    {
                        Console.WriteLine("Водолей");
                    }
                    if (d >= 19 && d <= 28);
                    {
                        Console.WriteLine("Рыбы");
                    }
                break;

                case 3:
                    if (d >= 1 && d <= 20)
                    {
                        Console.WriteLine("Рыбы");
                    }
                    if (d >= 21 && d <= 31)
                    {
                        Console.WriteLine("Овен");
                    }
                break;

                case 4:
                    if (d >= 1 && d <= 19)
                    {
                        Console.WriteLine("Овен");
                    }
                    if (d >= 20 && d <= 30)
                    {
                        Console.WriteLine("Телец");
                    }
                break;

                case 5:
                    if (d >= 1 && d <= 20)
                    {
                        Console.WriteLine("Телец");
                    }
                    if (d >= 21 && d <= 31)
                    {
                        Console.WriteLine("Близнецы");
                    }
                break;

                case 6:
                    if (d >= 1 && d <= 20)
                    {
                        Console.WriteLine("Близнецы");
                    }
                    if (d >= 21 && d <= 30)
                    {
                        Console.WriteLine("Рак");
                    }
                break;

                case 7:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("Рак");
                    }
                    if (d >= 23 && d <= 31)
                    {
                        Console.WriteLine("Лев");
                    }
                break;

                case 8:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("Лев");
                    }
                    if (d >= 23 && d <= 31)
                    {
                        Console.WriteLine("Дева");
                    }
                    break;

                case 9:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("Дева");
                    }
                    if (d >= 23 && d <= 30)
                    {
                        Console.WriteLine("Весы");
                    }
                    break;

                case 10:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("Весы");
                    }
                    if (d >= 23 && d <= 31)
                    {
                        Console.WriteLine("Скорпион");
                    }
                    break;

                case 11:
                    if (d >= 1 && d <= 21)
                    {
                        Console.WriteLine("Скорпион");
                    }
                    if (d >= 22 && d <= 30)
                    {
                        Console.WriteLine("Стрелец");
                    }
                    break;

                case 12:
                    if (d >= 1 && d <= 21)
                    {
                        Console.WriteLine("Стрелец");
                    }
                    if (d >= 22 && d <= 31)
                    {
                        Console.WriteLine("Козерог");
                    }
                    break;

                 default:
                    Console.WriteLine("Н/Д");
                    break;
            }
            Console.ReadKey();
        }
    }
}