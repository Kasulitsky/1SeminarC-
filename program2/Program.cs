// принимает 3 числа, выдает максимальное
Console.WriteLine ("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1)
    {
        max = number2;
    }
        else 
            if (number1 < number3)
            {
                max = number3;
            }
Console.Write ("number1="); Console.WriteLine (number1);
Console.Write ("number2="); Console.WriteLine (number2);
Console.Write ("number3="); Console.WriteLine (number3);
Console.Write ("max="); Console.Write (max);