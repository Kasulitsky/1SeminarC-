// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,] CreateArray () 
{
    Console.WriteLine ("задайте кол-во строк");
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("задайте кол-во столбцов");
    int b = Convert.ToInt32 (Console.ReadLine());
    double [,] array = new double [a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
         array [i,j] = new Random (). NextDouble () * 10;
        Console.Write($"{array [i,j]}   ");   
        }
    Console.WriteLine();
    }
    return array;
}
CreateArray ();
