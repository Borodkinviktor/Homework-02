/*
Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите число");
string namberString = Console.ReadLine();
int result = int.Parse(namberString[1].ToString());
Console.WriteLine($"Вторая цифра = {result}");
