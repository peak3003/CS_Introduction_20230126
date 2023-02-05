//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0)
{
  if (y > 0)
  {
    Console.WriteLine("1 четверть плоскости, т.к. x>0 adn y>0");
  }
  else
  {
    Console.WriteLine("4 четверть плоскости, т.к. x>0 adn y<0");
  }
}
else
{
  if (y > 0)
  {
    Console.WriteLine("2 четверть плоскости, т.к. x<0 adn y>0");
  }
  else
  {
    Console.WriteLine("3 четверть плоскости, т.к. x<0 adn y<0");
  }
}
