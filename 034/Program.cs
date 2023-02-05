// 34. Определить количество цифр в числе. Сделать подпрограмму.

int CounterDigirs(int n)
{
  if (n == 0) return 1;//пограничный случай

  int counter = 0;//счетчик 
  while (n != 0)
  {
    counter++;
    n /= 10;//n=n/10
  }
  //System.Console.WriteLine(CounterDigirs(counter)); //мусорный вывод
  return counter;
}


//Вывод только в основной подпрограмме
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CounterDigirs(N));