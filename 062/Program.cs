//62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
//Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int[,] Random2DArray(int N, int M,int min, int max)  //заполняет целыми числамы                    
{
    int[,] a=new int[N,M];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}


void Print2DArray(int[,] a)     //Выводит на печать
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}"); 
    System.Console.WriteLine();
    }
}

int[,] New2DArray(int[,] z)
{
       
    for(int i=0;i<z.GetLength(0);i++)
        for(int j=0;j<z.GetLength(1);j++)
            if (z[i,j]<0) 
            {
                z[i,j]=z[i,j]*-1;                    
            }
            
    return z;
}


Console.Write("Введите кол-во строк массива M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,] a=Random2DArray(m,n,-z,z);
Console.WriteLine("Исходный массив: ");
Print2DArray(a);
Console.WriteLine();
New2DArray(a);
Console.WriteLine("Измененный массив: ");
Print2DArray(a);

