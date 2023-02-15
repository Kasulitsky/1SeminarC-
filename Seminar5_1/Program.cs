// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2


int [] array = new int [9]; 
int n = array.Length;
int i = 0; 
int count = 0; 
while (i < n)
    {
        array [i] = new Random (). Next (100, 1000);
        Console.WriteLine (array[i]);
        i++;
    }
i = 0;
while (i < n)
    {
        if (array[i] % 2 == 0)
        {
            count++;
            i++;
        }
        else i++;     
    }
Console.WriteLine (count);
