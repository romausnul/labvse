using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу для нахождения кол-ва обев");
            Console.WriteLine("Введите длину комнаты");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину комнаты");
            double sh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту комнаты");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько окон в комнате?");
            Console.WriteLine("Введите кол-во окон");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол - во дверей");
            int dv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину окна");
            double sho =Convert.ToDouble(Console.ReadLine());
            Console.writeline("Введите высоту окна");
            double vo=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину двери");
            double shd =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту двери");
            double vdv = Convert.ToDouble(Console.ReadLine());
            double s = 2 * (d * v * sh * v);
            double so = sho * vo * o;
            Console.ReadKey();

        } 
    }
}
