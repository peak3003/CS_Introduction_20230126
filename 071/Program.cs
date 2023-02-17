//71. Показать натуральные числа от N до 1, N задано

void Loop(int i, int N)
{
    System.Console.Write($"{N,4}");
    if (i < N) Loop(i, N-1);  
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Loop(1,n);
