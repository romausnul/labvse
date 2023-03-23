Console.WriteLine("Введите возраст внука");
double v = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите возраст дедушки");
double d = Convert.ToDouble(Console.ReadLine());
while (d != 2 * v)
{
    v = v + 1;
    d = d + 1;
}
Console.WriteLine($"Возарст внука: {v}");
Console.WriteLine($"Возарст дедушки: {d}");
