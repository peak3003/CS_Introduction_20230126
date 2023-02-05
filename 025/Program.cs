// Задать номер четверти, показать диапазоны для возможных координат
//1. (x>0 adn y>0)
//2. (x<0 adn y>0)
//3. (x<0 adn y<0)
//4. (x>0 adn y<0)
//int quarter=3;
int quarter=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(quarter);
if (quarter==1) Console.WriteLine("x>0 adn y>0");
if (quarter==2) Console.WriteLine("x<0 adn y>0");
if (quarter==3) Console.WriteLine("x<0 adn y<0");
if (quarter==4) Console.WriteLine("x>0 adn y<0");