// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
// Вариант 2
int a, b, c, max;
Console.Write("Введите а:");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b:");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c:");
c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
  if (a > c)
  {
    max = a;
  }
  else
  {
    max = c;
  }
}
else
{
  if (b > c)
  {
    max = b;
  }
  else
  {
    max = c;
  }
}
Console.WriteLine($"max={max}");
