// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponentiate(int A, int B)
{
    Console.WriteLine("введите первое число");
    int f = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("введите второе число");
    int s = Convert.ToInt32 (Console.ReadLine ());
    double result = Math.Pow (f, s);
    return result; 
}

Console.WriteLine (Exponentiate (3, 2));
