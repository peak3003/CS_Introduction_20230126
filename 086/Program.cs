// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

Console.Write("Введите строку: ");
string s = Console.ReadLine();
Console.Write("Введите символ: ");
char ch =(char) Console.Read();
int k=0;
int i=0;
while (i < s.Length)
{
    if (s[i]==ch)
    k++;
    i++;
}
 System.Console.Write($"Количество символов равно {k}");