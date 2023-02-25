// See https://aka.ms/new-console-template for more information
double [,] CreateArray () 
{
    Console.WriteLine ("задайте размерноть двухмерного массива");
    int a = Convert.ToInt32 (Console.ReadLine());
    int b = Convert.ToInt32 (Console.ReadLine());
    double [,] array = new double [a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
         array [i,j] = new Random (). NextDouble () * 10;
        Console.WriteLine(array [i,j]);   
        }
    }
    return array;
}
CreateArray ();