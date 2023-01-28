// 11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

int n;
Console.Write("Введите число больше 9:");
n = Convert.ToInt32(Console.ReadLine());
int d0, d1, d2;
d0 = n % 10;
d1 = n / 10 % 10;
d2 = n / 10 / 10 % 10;
//d2=n/100; d2=n/10/10;
Console.WriteLine($"{d0} {d1} {d2}");
Console.WriteLine($"{d1}");
