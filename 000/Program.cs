// С клавиатуры вводятся два числа. Найти и вывести на экран их сумму

//string s;
int a, b, sum;
Console.Write("Введите а:");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b:");
b = Convert.ToInt32(Console.ReadLine());
sum = a + b;
//1 способ вывода: Конкатенация (склеивание) строк
Console.WriteLine(a + "+" + b.ToString() + "=" + Convert.ToString(sum));
//2 Форматированный вывод строк
Console.WriteLine("{0:F2}+{1:E5}={2:G4}", a, b, sum);
//3 Инерполяция строк
Console.WriteLine($"{a:F2}+{b:E5}={sum:G4}");


// С клавиатуры вводятся два числа. Найти и вывести на экран максимальное из них
int max;
if (a > b)
{
  max = a;
}
else
{
  max = b;
}
Console.WriteLine($"max={max}");