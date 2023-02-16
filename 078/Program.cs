//78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию.

int Fib(int N)
{
    if (N == 0) return 0;
        else
            if (N == 1) return 1;
                else
                    return Fib(N - 1) + Fib(N - 2);
}


Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
//for (i=-10;i!=10;i++)
    System.Console.WriteLine(Fib(n));