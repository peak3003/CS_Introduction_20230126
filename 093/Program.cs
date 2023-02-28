// 093 Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// а) простым поэлементным перемножением


int[,] RandomMatrix(int N, int M, int min, int max)
{
    int[,] a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}


void PrintMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],5}");
        System.Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = matrixA[i, j]*matrixB[i, j];
        
        }
    }
    return matrixC;
}
Console.Write("Введите кол-во строк массива M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,] a = RandomMatrix(m, n, 0, z);
int[,] b = RandomMatrix(m, n, 0, z);
System.Console.WriteLine("Матрица A:");
PrintMatrix(a);
System.Console.WriteLine("Матрица B:");
PrintMatrix(b);
//int[,] c = new[,];
var c = MatrixMultiplication(a, b);
System.Console.WriteLine("Получившаяся матрица C:");
PrintMatrix(c);

