// По месяцу определить время года. Использовать ИЛИ.
// int month = 4;
// if (month == 1 || month == 2 || month == 12) System.Console.WritLine("Winter");
// if (month == 3 || month == 4 || month == 5) System.Console.WritLine("Spring");
// if (month == 6 || month == 7 || month == 8) System.Console.WritLine("Summer");
// if (month == 9 || month == 10 || month == 11) System.Console.WritLine("Autumn");
// || - лениый ИЛИ

// Вводится возврст человека и нужно определить подходит ли он для работы (от 25 до 45 лет).
int age = 15;
// if (age >= 25)
//   if (age <= 45)
//     System.Console.WritLine("Подходит");
//   else
//     System.Console.WritLine("Не подходит");
// else
//   System.Console.WritLine("Не подходит");
if (age >= 25 & age <= 45) //И - одинарное проверяется сначало первое условие, потом второе, затем &
  System.Console.WritLine("Подходит");
else
  System.Console.WritLine("Не подходит");
  //&& - ленивый И (проверяет первое условие на истинность. Если ложь, то второе условие не проверяется)