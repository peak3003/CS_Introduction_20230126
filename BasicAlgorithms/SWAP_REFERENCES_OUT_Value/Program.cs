// void Swap(int x, int y) //передача по значению(Value) подпрограмма обмена
// {
//   int t=x;
//   x=y;
//   y=t;
// }

// void Swap(ref int x, ref int y) //передача по ссылке(references)
// // ref - модификатор аргумента, пердается ссылка
// {
//   int t=x;
//   x=y;
//   y=t;
// }
// int a=4;
// int b=5;
// Console.WriteLine($"a={a} b={b}");
// Swap(ref a, ref b);
// Console.WriteLine($"a={a} b={b}");


void Сalculator(int a, int b, out sum, out sub) // модификатор out
{
sum=a+b;
sub=a-b;
}


int a=4;
int b=5;
int s,sb;
Сalculator(a,b,out s,out sb);


Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
Console.WriteLine($"a={a} b={b}");




//a=b;  типичная ошибка, затирается а, становится =5
//b=a;

//Классический (стандартный) обмен
// int t;
// t=a;
// a=b;
// b=t;

//хитрый алгоритм, работает только для целых чисел
// a=a+b;
// b=a-b;
// a=a-b;

//Console.WriteLine($"a={a} b={b}");