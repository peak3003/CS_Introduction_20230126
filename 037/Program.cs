// 37. Показать кубы чисел, заканчивающихся на четную цифру
// Компьютер придумывает число и определяет заканчивается ли на четную цифру куб этого числа
bool Test(int n) //подпрограмма
{
  return n % 2 == 0;
  //if (n|%2==0)
  //return true;
  //else
  //return false;
}


Random random = new Random(10); //описали переменную типа Random и создали объект
for (int i = 0; i < 10; i++)
{
  int a = random.Next(1, 100); //следующее случайное число
  int b = (int)Math.Pow(a, 3);
  if (Test(b))
    System.Console.WriteLine($"{a}, {b}");
}


