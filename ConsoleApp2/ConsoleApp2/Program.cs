using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kolTovar1 = 0;
            int kolTovar2 = 0;
            int kolTovar3 = 0;
            int costTovar1 = 1488;
            int costTovar2 = 1337;
            int costTovar3 = 228;
            int deng = 0;
            int realitog = 0;

            Console.WriteLine("Введите название первого товара");
            string tovar1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара");
            kolTovar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите название второго товара");
            string tovar2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара");
            kolTovar2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите название третьего товара");
            string tovar3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара");
            kolTovar3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Внесите сумму денег");
            deng = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чек:");
            int itog = (kolTovar1 * costTovar1) + (kolTovar2 * costTovar2) + (kolTovar3 * costTovar3);
            Console.WriteLine(itog);
            Console.WriteLine("Внесенная сумма");
            Console.WriteLine(deng);

            realitog = itog - deng;
            
            if (realitog == 0)
            {
                Console.WriteLine("Спасибо за покупку");
            }
            if (realitog > 0)
            {

            }

        }
    }
}
