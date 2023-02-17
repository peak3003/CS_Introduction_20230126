//74. Найти сумму цифр числа
// Рекурентная формула
//  F(N)=0, N=0
//  F(N)=F(N/10)+N%10, N>0

int SumDigits(int N)
{
    if (N == 0) return 0;
        else
             return SumDigits(N/10) + N%10;
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр равна = {SumDigits(n)}");


