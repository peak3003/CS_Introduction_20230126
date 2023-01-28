// С клавиатуры вводятся два числа. Найти и вывести на экран максимальное из них
int a, b, max;
Console.Write("Введите а:");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b:");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
  max = a;
}
else
{
  max = b;
}
Console.WriteLine($"max={max}");