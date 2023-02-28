// 98. Показать треугольник Паскаля
Console.Write("Введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
int [,] triangle=new int [row,row];


void FillTriangle()
{
    for (int i=0;i<row;i++)
    {
        triangle[i,0]=1;
        triangle[i,i]=1;
    }
    for (int i=2;i<row;i++)
    {
        for (int j=1;j<=i;j++)
        {
            triangle[i,j]=triangle[i-1,j-1]+triangle[i-1,j];
        }
    }

}

void PrintTriangle()
{
    for(int i=0;i<row;i++)
    {
        for(int j=0;j<row;j++)
        {
            if (triangle[i,j]!=0)
            System.Console.Write($"{triangle[i,j],5}");
        }
        System.Console.WriteLine();
    }
}

FillTriangle();
PrintTriangle();
