// Дано число. Проверить кратно ли оно 7 и 23
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
{
  Console.WriteLine($"{n} кратно 7 и 23");
}
else
  Console.WriteLine($"{n} не кратно 7 и 23");