Console.WriteLine("Введите a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c");
double c = Convert.ToDouble(Console.ReadLine());
double d = a;
while (d < b)
{
    if (d % c == 0)
    {
        Console.WriteLine($"Число, кратное C = {d}");
    }
    d += 1;

}