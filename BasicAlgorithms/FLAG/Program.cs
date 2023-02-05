// Дано число. Проверить ечть ли в этом числе цифра 0

int N = 1234;
bool flag = false;
while (N != 0)
{
  int d = N % 10;
  if (d == 0)
    flag = true;
  N /= 10;// N=N/10
}

if (flag)
  Console.WriteLine("В числе есть 0");
else
  Console.WriteLine("В числе нет 0");