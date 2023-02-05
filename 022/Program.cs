// По двум заданным числам проверять является ли одно квадратом другого.
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == Math.Sqrt(n2))
{
  Console.WriteLine($"{n2} является квадратом {n1}");
}
else
{
  if (n2 == Math.Sqrt(n1))
  {
    Console.WriteLine($"{n1} является квадратом {n2}");
  }
  else
    System.Console.WriteLine("Квадратами друг друга не являются");
}