/* 2. С клавиатуры вводятся два вещественных числа. 
Проверять является ли одно из них квадратом второго
*/

double a, b;
string? s;
s = Console.ReadLine();
a = Convert.ToDouble(s);
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a * a == b)
  Console.WriteLine("b является квадратом a");
if (b * b == a)
  Console.WriteLine("a является квадратом b");


