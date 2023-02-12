// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("введите число");
int number = Convert.ToInt32 (Console.ReadLine());
int numberA = 0;
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;
int num6 = 0;
if (number > 0)     
{
    if (number < 10) { numberA = number ;}
    else if (number > 9 && number < 100)
            { num1 = number / 10; num2 = number % 10; numberA = num1 + num2; }
    else if (number > 99 && number < 1000)
            { num1 = number / 100; num2 = (number / 10) % 10; num3 = number % 10; numberA = num1 + num2 + num3; }
    else if (number > 999 && number < 10000)
            { num1 = number / 1000; num2 = (number / 100) % 10; num3 = (number / 10) % 10; num4 = number % 10; 
            numberA = num1 + num2 + num3 + num4; }
    else if (number > 9999 && number < 100000)
            { num1 = number / 10000; num2 = (number / 1000) % 10; num3 = (number / 100) % 10; num4 = (number / 10) % 10; 
            num5 = number % 10; numberA = num1 + num2 + num3 + num4; }
    else if (number > 99999 && number < 1000000)
            { num1 = number / 100000; num2 = (number / 10000) % 10; num3 = (number / 1000) % 10; num4 = (number / 100) % 10; 
            num5 = (number / 10) % 10; num6 = number % 10; numberA = num1 + num2 + num3 + num4; }
    Console.WriteLine(numberA);          
}
else {
    if  (number > -10) { numberA = number ;}
    else if (number > -100 && number < -9)
        { num1 = number / 10; num2 = number % 10; numberA = num1 + num2; }
    else if (number > -1000 && number < -99)
            { num1 = number / 100; num2 = (number / 10) % 10; num3 = number % 10; numberA = num1 + num2 + num3; }
    else if (number > -10000 && number < -999)
            { num1 = number / 1000; num2 = (number / 100) % 10; num3 = (number / 10) % 10; num4 = number % 10; 
            numberA = num1 + num2 + num3 + num4; }
    else if (number > -100000 && number < -9999)
            { num1 = number / 10000; num2 = (number / 1000) % 10; num3 = (number / 100) % 10; num4 = (number / 10) % 10; 
            num5 = number % 10; numberA = num1 + num2 + num3 + num4; } 
    Console.WriteLine($"{Math.Abs (numberA)}");
    } 
                   

