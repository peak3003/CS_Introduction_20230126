//60. Показать двумерный массив размером m×n заполненный целыми случайными числами


int[,] Random2DArray(int N, int M,int min, int max)  //заполняет целыми числамы                    
{
    int[,] a=new int[N,M];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}


void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}"); //выводит 2 после запятой
    System.Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк массива M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,] a=Random2DArray(m,n,0,z);
Print2DArray(a);

