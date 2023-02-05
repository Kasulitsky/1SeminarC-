// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine ()); 
int result = number / 10;
Console.WriteLine ($"{number}, {result % 10}");
