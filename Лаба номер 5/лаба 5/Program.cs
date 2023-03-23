using System;

namespace лаба_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} = {Math.Pow(i, 2)}");
            }
        }
    }
}
