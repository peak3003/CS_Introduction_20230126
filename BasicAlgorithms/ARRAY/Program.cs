//Подсчитать среднюю температуру за неделю
// double t1,t2,t3,t4,t5,t6,t7;
// t1=Convert.ToDouble(Console.ReadLine());
// t2=Convert.ToDouble(Console.ReadLine());
// t3=Convert.ToDouble(Console.ReadLine());
// t4=Convert.ToDouble(Console.ReadLine());
// t5=Convert.ToDouble(Console.ReadLine());
// t6=Convert.ToDouble(Console.ReadLine());
// t7=Convert.ToDouble(Console.ReadLine());
// double sr=(t1+t2+t3+t4+t5+t6+t7)/7;
// System.Console.WriteLine(sr);


//инициализация переменных
double[] temps=new double[7];
//ввод данных массива
for (int i=0;i<temps.Length;i++)
temps[i]=Convert.ToDouble(Console.ReadLine());
//решение задачи
//находим сумму массива
double s=0;
for (int i=0;i<temps.Length;i++)
s=s+temps[i];
//вывод результата
System.Console.WriteLine(s/temps.Length);
