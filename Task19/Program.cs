// Задача 19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите пятизначное число");
string number = Console.ReadLine();
string rev = string.Concat(number.Reverse());
Console.WriteLine(number == rev ? "палиндром" : "не палиндром");

