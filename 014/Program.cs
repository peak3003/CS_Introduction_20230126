/*14. С клавиатуры вводятся два числа a и b.
Выяснить, кратно ли число a числу b, 
если нет, вывести остаток от деления a на b.
*/
/*То, что число а кратно числу b, означает, 
что число а нацело, то есть без остатка делится на число b. 
*/
int a, b, n;
Console.Write("Введите а:");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b:");
b = Convert.ToInt32(Console.ReadLine());
n = a % b;
if (n != 0)
{
  Console.WriteLine($"Остаток от деления а на b = {n}");
}
else
  Console.WriteLine($"a кратно b");
