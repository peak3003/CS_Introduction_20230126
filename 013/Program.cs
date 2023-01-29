// 13. Удалить вторую цифру целого числа введенного с клавиатуры.

int n;
Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
int n1, d1;
n1 = (int)n / 100;
d1 = n % 10;
Console.WriteLine($"n1={n1}" + d1);
