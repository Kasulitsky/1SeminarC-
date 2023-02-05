// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
Console.WriteLine ("введите номер дня недели");
int Mondey = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday  = 7;
int a = Convert.ToInt32 (Console.ReadLine());
if (a < 6)
    {
        Console.WriteLine ("no");
    }
else 
    Console.WriteLine ("yes");


