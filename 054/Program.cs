// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
// Числа Фибоначчи: F[0]=0, F[1]=1, F[n]=F[n-1]+F[n-2]

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] F = new int[N];
Fib(F);
PrintArray(F);




void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i]} ");
}

void Fib(int[] F)
{
    F[0] = 0;
    F[1] = 1;
    for (int i = 2; i < F.Length; i++)
        F[i] = F[i - 1] + F[i - 2];
}