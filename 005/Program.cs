// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a, b, c, max;
Console.Write("Введите а:");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b:");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c:");
c = Convert.ToInt32(Console.ReadLine());
max = a;
if (max < b)
{
  max = b;
}
if (max < c)
{
  max = c;
}
Console.WriteLine($"max={max}");
