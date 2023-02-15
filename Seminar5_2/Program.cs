// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Hello, World!");
int [] array = new int [9]; 
int n = array.Length;
int i = 0; 
while (i < n)
    {
        array [i] = new Random (). Next (1, +100);
        Console.WriteLine (array[i]);
        i++;
    }
i = 0; 
int sum = 0;
while (i < n)
    {
        sum = sum + array [i];
        i = i + 2;
    }
Console.WriteLine (sum);