// 45. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Write("Введите кол-во элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
  a[i] = random.Next(100, 999);

for (int i = 0; i < a.Length; i++)
  System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int chet=0; 
int nechet=0;
for (int i = 0; i < a.Length; i++)
if (a[i]%2 == 0)
{
  chet++;
}
else 
{
nechet++;
}
System.Console.WriteLine($"Кол-во четных элементов массива равно {chet} ");
System.Console.WriteLine($"Кол-во нечетных элементов массива равно {nechet} ");