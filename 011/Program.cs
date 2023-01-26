// 9. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

int n=123;
ште d0,d1,d2;
d0=n%10;
d1=n/10%10;
d2=n/10/10%10;
//d2=n/100; d2=n/10/10;
Console.WriteLine($"{d0} {d1} {d2}");
Console.WriteLine($"{d1}");

//7.Выяснить является ли число чётным.
int N2=7;
bool odd=N2%2==0;
if(odd==true)
{
  Console.WriteLine($"Число {N2} четное ");
}
else 
{
  Console.WriteLine($"Число {N2} не четное ");
}
