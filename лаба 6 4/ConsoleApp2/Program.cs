Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
while (a > 0)
{
    a = a / 10;
    b = b + 1;
}
Console.WriteLine($"В этом числе {b} цифр");

