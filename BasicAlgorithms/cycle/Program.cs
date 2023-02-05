// // Ввести n от 0 до 10 с проверкой ввода
//Цикл ПОКА (while)
//Вывести на экран числа от 1 до 1
// int i=1
// while(i<=10)
// {
// System.Console.WriteLine(i);
// i++;
// }


//Цикл ДО
// int n;
// // До тех пор пока (цикл с постусловием)
// do
// {
//   // int n; локальная переменная, существует (видимость) только внутри фигурных скобок 
//   n = Convert.ToInt32(Console.ReadLine());
// }
// while (n < 0 || n > 10);

//Цикл ДЛЯ (for), цикл со счетчиком
//Вывести на экран числа от 1 до 1
// int i=1
// while(i<=10)
// {
// System.Console.WriteLine(i);
// i++;
// }
for (int i = 1; i <= 10; i++)
{
  System.Console.WriteLine(i);
}

for (int i = 1, k = 100; i <= 100 && k >= 50; i++, k = --)
{
  System.Console.WriteLine(i + " " + k);
}


int i,k;
for (i = 1; i <= 10; i++)
{
  System.Console.WriteLine(i);
}

for (i = 1, k = 100; i <= 100 && k >= 50; i++, k = --)
{
  System.Console.WriteLine(i + " " + k);
}

//Цикл foreach
string s="ABCDED"
foreach(char с is s)//работает с коллекциями (реализующими интерфейс IEnumerable)
{
  System.Console.WriteLine(c);
}