﻿// 40. Задать массив из 8 целых элементов и вывести их на экран
int[] a;
a=new int[8];
// int[] a=new int[8];
Random random=new Random(); //описание и создание олбъекта
for(int i=0;i<a.Length;i++)
a[i]=random.Next(0,10);

for(int i=0;i<a.Length;i++)
Console.WriteLine($"{a[i]} ");
Console.WriteLine("");
