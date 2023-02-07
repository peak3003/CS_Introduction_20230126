// 33. Возведите число А в натуральную степень B используя цикл
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень числа В: ");
int b = Convert.ToInt32(Console.ReadLine());
int c=1;
Console.WriteLine(Math.Pow(a,b)); // проверка
for (int i = 1; i <= b; i++)
  c=c*a;
Console.WriteLine($"A в степени В равно {c}");
