using System;

namespace мамонов_Роман
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу!"); // Эта команда выведет фразу "Добро пожаловать в программу!"
            Console.WriteLine(); // Эта команда выведет пустую строку
            
            
            
            
            
            Console.WriteLine("1 ТОВАР"); // Эта команда выведет фразу "1 ТОВАР"
            Console.WriteLine("Введите название товара"); // Эта команда выведет фразу "Введите название товара"
            string N1 = Console.ReadLine(); // Эта команда для ввода данных названия, переменная строкового типа
            Console.WriteLine("Введите количество товара"); // Эта команда выведет фразу "Введите количество товара"
            int K1 = Convert.ToInt32(Console.ReadLine()); // Эта команда для ввода данных о количестве, переменная целого числового типа Integer
            Console.WriteLine("Введите цену товара (между целой и дробной частью ставится запятая)");// Эта команда выведет фразу "Введите цену товара…"
            double C1 = Convert.ToDouble(Console.ReadLine()); // Эта команда для ввода данных о цене, переменная вещественного числового типа Double
            Console.WriteLine();



            Console.WriteLine("2 ТОВАР"); // Эта команда выведет фразу "2 ТОВАР"
            Console.WriteLine("Введите название товара"); // Эта команда выведет фразу "Введите название товара"
            string N2 = Console.ReadLine(); // Эта команда для ввода данных названия, переменная строкового типа
            Console.WriteLine("Введите количество товара"); // Эта команда выведет фразу "Введите количество товара"
            int K2 = Convert.ToInt32(Console.ReadLine()); // Эта команда для ввода данных о количестве, переменная целого числового типа Integer
            Console.WriteLine("Введите цену товара (между целой и дробной частью ставится запятая)");// Эта команда выведет фразу "Введите цену товара…"
            double C2 = Convert.ToDouble(Console.ReadLine()); // Эта команда для ввода данных о цене, переменная вещественного числового типа Double
            Console.WriteLine();


            Console.WriteLine("3 ТОВАР"); // Эта команда выведет фразу "3 ТОВАР"
            Console.WriteLine("Введите название товара"); // Эта команда выведет фразу "Введите название товара"
            string N3 = Console.ReadLine(); // Эта команда для ввода данных названия, переменная строкового типа
            Console.WriteLine("Введите количество товара"); // Эта команда выведет фразу "Введите количество товара"
            int K3 = Convert.ToInt32(Console.ReadLine()); // Эта команда для ввода данных о количестве, переменная целого числового типа Integer
            Console.WriteLine("Введите цену товара (между целой и дробной частью ставится запятая)");// Эта команда выведет фразу "Введите цену товара…"
            double C3 = Convert.ToDouble(Console.ReadLine()); // Эта команда для ввода данных о цене, переменная вещественного числового типа Double
            Console.WriteLine();


            double Ob_st = K1 * C1 + K2 * C2 + K3* C3;
            Console.WriteLine("Стоимость вашей покупки составила " + Ob_st + "руб."); // Эта команда вывода результата
            Console.ReadKey();
            
        
    
    
         
            Console.ReadKey();
        }
    }
}
