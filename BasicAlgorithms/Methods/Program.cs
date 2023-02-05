// Напишите подпрограмму нахождения расстояния между двумя точками


//тип Название(аргументы)

//метод = подпрограмма = функция 
double Distance(double x1,double y1,double x2,double y1)
{
  return Math.Sqrt(Math.Pow(x1-x2,2+Math.Pow(y1-y2,2)));
}


double x1=0,y1=0,x2=0,y2=0;

//double distance=Math.Sqrt(Math.Pow(x1-x2,2+Math.Pow(y1-y2,2)));
double distance=Distance(0,0,2,2);
System.Console.WriteLine(distance);
System.Console.WriteLine(Distance(0,0,2,2));