//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
int result = 0; 
if ( number < 100 )
    {
        Console.WriteLine("третьей цифры нет");
    }   
else
    {
        if (number < 1000)
            {
                Console.WriteLine   ($"{number}, {number % 10}");
            }
        if (number < 10000)
            {
                if (number > 999)
                    {
                        result = number / 10;
                        Console.WriteLine   ($"{number}, {result % 10}");
                    }
            }    
        if (number < 100000)
            {
                if (number > 9999)
                    {
                        result = number / 100;
                        Console.WriteLine   ($"{number}, {result % 10}");
                    }
            }    
    }

