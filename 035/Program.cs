// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumDigit(int n)
{
  int s = 0;
  while (n != 0)
  {
    s = s + n % 10;
    n = n / 10;
  }
  return s;
}


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр равна {SumDigit(a)}");
