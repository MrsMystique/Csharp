﻿// Очищаем консоль
Console.Clear();
// Говорим Пользователю ввесди число от 1 до 7

Console.Write("Введите число от 1 до 7 и узнаете день недели: ");
int user = Convert.ToInt32(Console.ReadLine());
// Делаем условие которое будет показывать день недели
if(user == 1)
{
    Console.WriteLine("Понедельник");
}
else if(user == 2)
{
    Console.WriteLine("Вторник");
}
else if(user == 3)
{
    Console.WriteLine("Среда");
}
else if(user == 4)
{
    Console.WriteLine("Четверг");
}
else if(user == 5)
{
    Console.WriteLine("Пятница");
}
else if(user == 6)
{
    Console.WriteLine("Суббота");
}
else if(user == 7)
{
    Console.WriteLine("Воскресение");
}


