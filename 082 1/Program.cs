﻿// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

Console.Write("Введите строку разделенную точкой: ");
string s = Console.ReadLine();
int k=0;
int i=0;
while (s[i]!='.')
{
    k++;
    i++;
}
 System.Console.Write($"Количество символов равно {k}");