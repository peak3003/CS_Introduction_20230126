// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int n;
Console.Write("Введите целое число:");
n = Convert.ToInt32(Console.ReadLine());
int d0;
d0=n%10;
Console.WriteLine($"{d0}");
