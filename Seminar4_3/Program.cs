// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int [8];
int length = array.Length;
int i = 0;
for (array [i] = 0; i < length; i++)
{
  array [i] = new Random(). Next (1,99);
  Console.WriteLine(array[i]);
}

