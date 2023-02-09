// 51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("Введите кол-во элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int k=0;
int[] a = new int[N];
    for(int i = 0; i < N; i++)
    {
        Console.Write($"A[{i}] = ");
        a[i] = Convert.ToInt32(Console.ReadLine());
        if (a[i]>0) k++;
    }
Console.WriteLine($"Чисел больше 0 = {k}");