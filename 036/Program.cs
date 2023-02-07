// 36. Написать программу вычисления произведения чисел от 1 до N
// N! факториал

int Factorial(int n)
{
  int factorial=1;
  for (int i = 2; i <= n; i++)
    factorial *= i;
  return factorial;
}


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведения чисел от 1 до N равна {Factorial(N)}");

