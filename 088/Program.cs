// 88. Заменить все вхождения подстроки w в строке st на строку v. 
// Вывести на экран первоначальную строку и конечную строку

Console.Write("Введите строку: ");
string s = Console.ReadLine();
string s1="w";
string s2="v";
s=s.Replace(s1,s2);
System.Console.Write($"Новая строка {s}");