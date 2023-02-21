// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("введите колличество чисел");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите числа ");
int [] array = new int [m];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array [i] = Convert.ToInt32 (Console.ReadLine());   
}
for (int i = 0; i < array.Length; i++)
{
    if (array [i] > 0) {count++;}
}
Console.WriteLine($"количество символов больше нуля {count}");