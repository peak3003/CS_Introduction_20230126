// Программа проверяет пятизначное число на палиндромом. Например: 12321
static bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}

Console.Write("Введите пятизначное число: ");
var s = Convert.ToString(Console.ReadLine());
if (IsPalindrome(s) == false)
Console.WriteLine("Не палиндром");
else 
Console.WriteLine("Палиндром");




