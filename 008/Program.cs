// 8. Вывести на экран числа от -N до N
int n, i;
Console.Write("Введите целое число:");
n = Convert.ToInt32(Console.ReadLine());
i = -n;
while (i <= n)
{
  Console.Write($"{i} ");
  i++;
}
