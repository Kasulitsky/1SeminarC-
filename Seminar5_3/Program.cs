// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double [9]; 
int n = array.Length;
int i = 0; 
double max = 0;
double min = 99;
for (i = 0; i < n; i++)
{
    array [i] = new Random (). Next (1, 100);
    Console.WriteLine(array [i]);
}
for (i = 0; i < n; i++)
{
    if (array [i] > max) {max = array [i];}
    if (array [i] < min) {min = array [i];}
    i++;
}
Console.WriteLine ($"min- {min}, max- {max}, разница {max - min}");