using System;

namespace лаба_5_2
{
    class Program
    {
        static void Main()
        {
            int n = 9;
            int count = 0;
            for (int i = 100; i < 1000; ++i)
            {
                string str = i.ToString();

                if (int.Parse(str[0].ToString()) + int.Parse(str[1].ToString()) + int.Parse(str[2].ToString()) == n)
                {
                    count++;
                }
            }

            Console.WriteLine("Результат: {0}", count);
        }
    }
}