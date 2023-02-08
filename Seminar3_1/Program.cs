// 

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите 5-значное число");
int NumbA = Convert.ToInt32 (Console.ReadLine ());
int NumbA1 = NumbA / 10000;
int NumbA2 = (NumbA % 10000) / 1000;
int NumbA3 = (NumbA % 1000) / 100;
int NumbA4 = (NumbA % 100) / 10;
int NumbA5 = NumbA % 10;

int NumbB1 = NumbA5;
int NumbB2 = NumbA4;
int NumbB3 = NumbA3;
int NumbB4 = NumbA2;
int NumbB5 = NumbA1;
int NumbB = (NumbB1*10000) + (NumbB2*1000) + (NumbB3*100) + (NumbB4*10) + NumbB5;
if (NumbA == NumbB) 
    {
        Console.WriteLine("число является палиндромом");
    }
else
    {
        Console.WriteLine("число не является палиндромом");
    }

