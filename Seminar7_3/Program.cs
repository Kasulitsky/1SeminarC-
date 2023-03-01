// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
double [,] CreateMassiv() 
{
    double [,] array = new double [4,4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next (1, 11);
            Console.Write($"{array [i,j]}   ");
        }
    Console.WriteLine();
    }
    return array;
}

double [,] massiv = CreateMassiv();
double sum1 = 0;
double av1 = 0;
for (int j = 0; j < massiv.GetLength(1);)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
        {
            sum1 = sum1 + massiv [i,j];
            av1 = sum1 / massiv.GetLength(0); 
        }
    Console.WriteLine($"среднее арифметическое 1го столбца = {av1}");
    break;    
}
double sum2 = 0;
double av2 = 0;
for (int j = 1; j < massiv.GetLength(1);)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
        {
            sum2 = sum2 + massiv [i,j];
            av2 = sum2 / massiv.GetLength(0); 
        }
    Console.WriteLine($"среднее арифметическое 2го столбца = {av2}");
    break;    
}

// аналогично для следующих столбцов..  


// хотел создать метод, но не понял как объявить аргументы, что бы можно было там подставлять, 

// double [,] FindAverege (int a, int b)
// {
    
// double [,] massiv = CreateMassiv();
// double sum1 = 0;
// double av1 = 0;
// for (int j = 0; j < massiv.GetLength(1);)
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//         {
//             sum1 = sum1 + massiv [i,j];
//             av1 = sum1 / massiv.GetLength(0); 
//         }
//     Console.WriteLine($"среднее арифметическое 1го столбца = {av1}");
//     break;    
// }
// return massiv;
// }
// FindAverege (0, 2);


    

