/* 48. Задан массив a из N элементов.
Заполнить массив случайными числами от 1 до 10. 
Создайте массив, который является произведением пар чисел в одномерном 
массиве a. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д.
*/



Console.Write("Введите кол-во элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
  a[i] = random.Next(1, 11);

for (int i = 0; i < a.Length; i++)
  Console.Write($"{a[i]} ");
Console.WriteLine();

int M; //определяем размер создаваемого второго массива
if (N % 2 == 0)
{
  M = N / 2;
}
else
{
  M = Convert.ToInt32(N / 2 + 1);
}
Console.WriteLine(M);

int[] b = new int[M];
for (int i = 0; i < b.Length; i++)
  b[i] = a[i] * a[N - 1 - i];

for (int i = 0; i < b.Length; i++)
  Console.Write($"{b[i]} ");
Console.WriteLine();