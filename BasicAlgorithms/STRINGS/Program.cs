// char c='A'; // символ заключается в одинарные кавычки
// string s="A"; // строка в двойные кавычкки

//System.Console.WriteLine((int)c);  


// ConsoleKeyInfo keyInfo
// do
// {
//     keyInfo=Console.ReadKey();
//     char c=keyInfo.KeyChar;
//     System.Console.WriteLine(); 
//     System.Console.WriteLine((int)c);
//     if (char >= '0' && char <= '9') System.Console.WriteLine("Digit");
//     if (char >= 'A' && char <= 'Z') System.Console.WriteLine("Big latin");
//     if (char.InDigit(c)) System.Console.WriteLine("Digit");
//     System.Console.WriteLine(keyInfo.Key); 
// } 
// while (keyInfo.Key != ConsoleKey.Escape) ;



// string s="Hello"; //неизменяеые строки immutable
// s[0]='h'; //нельзя, индексатор можно только прочитать, поменять так нельзя
// System.Console.WriteLine(s[2]); //получаем символ слова по индексу

// char[] chars=s.ToCharArray();
// chars[0]='h';
// s=new string (chars);// ЗАМЕНА СИМВОЛА В СТРОКЕ ЧЕРЕЗ СОЗДАНИЕ НОВОГО
// System.Console.WriteLine(S);

//  ReadLn(a,b,c) 3 4 5
// Ввод нескольких значений 
// string s=Console.ReadLine();
// string[] s1=s.Split(' ',StringSplitOptions.RemoveEmptyEntries); //удаляет пустые строки
// int[] a=new int[s1.Length];
// for (int i=0; i<s1.Length;i++);
//     a[i]=Convert.ToInt32(s1[i]);
// for (int i=0; i<s1.Length;i++);
//     System.Console.WriteLine(a[i]);


// Ввод нескольких значений 
// string s=Console.ReadLine();
// string[] s1=s.Split(' ',StringSplitOptions.RemoveEmptyEntries); //удаляет пустые строки
// int[] a=new int[s1.Length];
// //for (int i=0; i<s1.Length;i++);
// //    a[i]=Convert.ToInt32(s1[i]);
// int[] b=Array.ConvertAll<string, int>(s1,Conv.ToInt32);

// for (int i=0; i<s1.Length;i++);
//     System.Console.WriteLine(a[i]);


// String VS StringBuilder
// using System.Text;
// System.Diagnostics.Stopwatch stopwatch=new System.Diagnostics.Stopwatch();
// stopwatch.Start();
// string s="";
// int N=30000;
// for (int i=0;i<N;i++)
// s=s+"ABCDEFGHIJKLMNOPRQSTVWXYZ"; //каждый раз создается новая строка
// stopwatch.Stop();
//  System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
// stopwatch.Reset();

// stopwatch.Start();
// // System.Text.StringBuilder sb=new System.Text.StringBuilder();
// StringBuilder sb=new StringBuilder();
// for (int i=0;i<N;i++)
// sb.Append("ABCDEFGHIJKLMNOPRQSTVWXYZ");
// stopwatch.Stop();
// strings3=sb.ToString();
// System.Console.WriteLine(stopwatch.ElapsedMilliseconds);

int a=1, b=1;
Random r1=new Random(100);
Random r2=new Random(100);
r2=r1;
System.Console.WriteLine(r1==r2); // сравниваются указатели в памяти
string s1="Hello";
string s2="Hello";
System.Console.WriteLine(s1==s2); // строки сравниваются по содержанию


// склеивает в одну строку
string[] s1=new string[3];
s3[0]="word";
s3[1]="word";
s3[2]="word";
string s4=String.Join("", s3); //статический метод
System.Console.WriteLine(s4);