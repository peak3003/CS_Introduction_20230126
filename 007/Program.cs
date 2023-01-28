//7. Выяснить является ли число чётным.
int N2;
Console.Write("Введите число:");
N2 = Convert.ToInt32(Console.ReadLine());
bool odd = N2 % 2 == 0;
if (odd == true)
{
  Console.WriteLine($"Число {N2} четное ");
}
else
{
  Console.WriteLine($"Число {N2} не четное ");
}
