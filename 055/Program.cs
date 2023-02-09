// 56. Написать программу копирования массива

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
  a[i] = random.Next(1, 100);
System.Console.WriteLine("Исходный массив:");
PrintArray(a);
System.Console.WriteLine();
int[] b=new int[a.Length];
Array.Copy(a,b,a.Length);
System.Console.WriteLine("Скопированный массив:");
PrintArray(b);



void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i]} ");
}