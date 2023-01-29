// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int n, max;
Console.Write("Введите число в диапазоне от 10 до 99:");
n = Convert.ToInt32(Console.ReadLine());
int d0, d1;
d0 = n % 10;
d1 = n / 10 % 10;
if (d0 > d1)
{
  max = d0;
}
else
{
  max = d1;
}
Console.WriteLine($"Наибольшая цифра введенного числа={max}");

