using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаовать в 22");
            Console.WriteLine("Как вас зовут?");
            string name = Convert.ToString (Console.ReadLine());
            Console.WriteLine(name + ", введите 1 целое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(name + ", введите 2 целое число");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            Console.WriteLine($"Сумма этих чисел: {sum}");
            double razn = a - b;
            Console.WriteLine($"Разность этих чисел: {razn}");
            double mnozh = a * b;
            Console.WriteLine($"Произведение этих чисел: {mnozh}");
            double chast = a / b;
            Console.WriteLine($"Частное этих чисел: {chast}");
            double step = Convert.ToDouble(Math.Pow(a, b));
            Console.WriteLine($"Число {a} в степени {b} = {step}");
            Console.ReadKey();
        }
    }
}
