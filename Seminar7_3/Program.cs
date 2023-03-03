// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

double [] FindAverege (double [,] arr)
{
double [] mas = new double [arr.GetLength(1)];
double sum1 = 0;
double av1 = 0;
for (int j = 0; j < arr.GetLength(1); j++)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum1 = sum1 + massiv [i,j];
            av1 = sum1 / massiv.GetLength(0); 
        }
    Console.WriteLine($"среднее арифметическое = {av1}");
     sum1 = 0;
 av1 = 0;  
}
return mas;
}
FindAverege(massiv);

  


// аналогично для следующих столбцов..  


// хотел создать метод, но не понял как объявить аргументы, что бы можно было там подставлять, 

// double [] FindAverege (int [,] arr)
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


    

