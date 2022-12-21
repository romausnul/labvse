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
            Console.Write("Добро пожаовать в 22");
            Console.Write("Как вас зовут?");
            string name = Convert.ToString (Console.Read());
            Console.Write(name + ", введите 1 целое число");
            double a = Convert.ToDouble(Console.Read());
            Console.Write(name + ", введите 2 целое число");
            double b = Convert.ToDouble(Console.Read());
            double sum = a + b;
            Console.Write($"Сумма этих чисел: {sum}");
            double razn = a - b;
            Console.Write($"Разность этих чисел: {razn}");
            double mnozh = a * b;
            Console.Write($"Произведение этих чисел: {mnozh}");
            double chast = a / b;
            Console.Write($"Частное этих чисел: {chast}");
            double step = Convert.ToDouble(Math.Pow(a, b));
            Console.Write($"Число {a} в степени {b} = {step}");
            Console.ReadKey();
        }
    }
}
