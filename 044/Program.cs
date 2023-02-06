// 44. Линейный поиск
//Определить, присутствует ли в заданном массиве, некоторое число

int[] a = new int[10];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
  a[i] = random.Next(-9, 10);

for (int i = 0; i < a.Length; i++)
  System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

//линейный поиск
int find = 5;
int j = 0;
while (j < a.Length && a[j] != 0) j++;
if (j == a.Length)
  System.Console.WriteLine("NO");
else
  System.Console.WriteLine($"Element {find} found at index {j}");
