/* 15. С клавиатуры вводится целое число. 
Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
*/
int n;
Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
int d1;
int i = 0;
int num = n;
while (num > 0)
{
  i++;
  num /= 10;
}
if (i > 2)
{
  d1 = (int)(n % 1000) / 100;
  Console.WriteLine($"Третья цифра равна={d1}");
}
else
{
  Console.WriteLine($"NO");
}

