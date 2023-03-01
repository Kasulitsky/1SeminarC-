// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int [,] CreateMassiv ()
{
    int [,] array  = new int [4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random(). Next (-10, 10);
            Console.Write ($"{array [i,j]}   ");
        }
    Console.WriteLine();
    }   
    return array ;
}
int [,] AcceptMeaning () 
{
    int [,] matrix = CreateMassiv();
    Console.WriteLine ("введите номер строки");
    int i = Convert.ToInt32 (Console.ReadLine()); 
    Console.WriteLine ("введите номер столбца");
    int j = Convert.ToInt32 (Console.ReadLine());
    if (i <= matrix.GetLength(0) & j < matrix.GetLength(1)) 
        { Console.WriteLine ($"{matrix [i,j]}");}
    else
    {
        Console.WriteLine ("такого элемента нет");
    }
    return matrix;
}

AcceptMeaning();

