/* 46. В одномерном массиве из 123 чисел найти количество элементов из 
отрезка [10,99] (значение элемента массива из диапазона от 10 до 99)
*/

int[] a = new int[123];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
  a[i] = random.Next(0, 999);

for (int i = 0; i < a.Length; i++)
  Console.Write($"{a[i]} ");
Console.WriteLine();

int counter = 0;
for (int i = 0; i < a.Length; i++)
  if (a[i]>= 10 && a[i]<=99)
  {
    counter++;
  }
Console.WriteLine($"Кол-во элементов массива из диапазона от 10 др 99 равно {counter} ");
