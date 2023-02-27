// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
// Вычислить сумму цифр введенного числа

Console.Write("Введите символы: ");
string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)
{
    if (char.IsNumber(s[i]))
    {
        sum = sum + Convert.ToInt32(s[i].ToString());
    }
    else
    {
        System.Console.Write($"Не число");
        return;
    }
}
System.Console.WriteLine($"Сумма цифр равна {sum}");
