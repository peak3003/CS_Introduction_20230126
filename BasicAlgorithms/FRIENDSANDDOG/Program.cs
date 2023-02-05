/* Предположим, что у нас есть два друга. 
Друг 1 и друг 2. Они движутся навстречу друг к другу с какой-то скоростью.
У друга 1 скорость — 1 м/с, он идёт не спеша. Друг 2 торопится, его скорость
— 2 м/с. У них есть собака, она хорошо знает обоих друзей и периодически
бегает от одного к другому. Когда друзья стартовали, собака от друга 1 бежит к 
другу 2, добегает до него 
и сразу возвращается к другу 1. У собаки 
тоже есть какая-то скорость. То есть пока собака будет
бежать к другу 2, друг 2 тоже пойдёт ей навстречу. Таким образом, 
они пересекутся в какой-то точке. Потом собака развернётся 
и сразу же побежит обратно. Вопрос: Перед тем как друзья 
встретятся, сколько раз собака перебежит от друга 1 к другу 2? 
*/
int count, firstFriendSpeed, secondFriendSpeed, dogSpeed, friend; // camelCase
//int  Count, Distance, FirstFriendSpeed //PascalCase
double distance, time;
count = 0;
distance = 10000;
firstFriendSpeed = 1;
secondFriendSpeed = 2;
dogSpeed = 5;
friend = 2;

while (distance > 10)
{
  if (friend == 1)
  {
    time = distance / (firstFriendSpeed + dogSpeed);
    friend = 2;
  }
  else
  {
    time = distance / (secondFriendSpeed + dogSpeed);
    friend = 1;
  }
  distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
  count = count + 1;
}
System.Console.WriteLine(count);


