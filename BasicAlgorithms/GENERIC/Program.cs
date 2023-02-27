// обощения (Generic)

 //List<string> list=new 

 void Swap(ref int a, ref int b)
 {
    int t=a;
    a=b;
    b=t;
 }

 void Swap(ref double a, ref double b) //перегрузка по параметрам
 {
    int t=a;
    a=b;
    b=t;
 }


 int x=3,y=5;
 System.Console.WriteLine($"x={x} y={y}");   