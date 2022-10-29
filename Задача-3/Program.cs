 /*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели и проверяет, является ли этот день выходным
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("ВВедите день недели, от 1 - 7");
int number = int.Parse(Console.ReadLine());

if(number >= 1 && number <= 5 )
   Console.WriteLine("Рабочий день");
else if(number == 6 || number ==7)
   Console.WriteLine("Выходной день");
else
   Console.WriteLine("ВВедите день недели от 1-7");


