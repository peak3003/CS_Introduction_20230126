//61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArrayDouble(int N, int M,int min, int max)   //заполняет вещественными числами                   
{
    double[,] a=new double[N,M];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.NextDouble();
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],6:F2}"); //выводит 2 после запятой
    System.Console.WriteLine();
    }
}


Console.Write("Введите кол-во строк массива M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());
double[,] a=Random2DArrayDouble(4,4,0,10);
Print2DArray(a);


