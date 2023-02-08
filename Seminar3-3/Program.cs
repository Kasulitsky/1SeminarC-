// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число");
int number  = Convert.ToInt32 (Console.ReadLine());
int a = 1;
while (a < number +1)
    {
        Console.WriteLine($"{Math.Pow (a, 3)}");
        a = a+1;
    }
