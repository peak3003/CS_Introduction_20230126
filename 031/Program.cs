// 31. Вывести на экран кубы чисел от 1 до N
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=N;i++)
System.Console.WriteLine($"Для числа {i} кубом является {i*i*i}");
