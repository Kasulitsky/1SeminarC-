// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine ("введите координаты первой точки");
int Ax = Convert.ToInt32 (Console.ReadLine()); int Ay = Convert.ToInt32 (Console.ReadLine()); int Az = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("введите координаты второй точки");
int Bx = Convert.ToInt32 (Console.ReadLine()); int By = Convert.ToInt32 (Console.ReadLine()); int Bz = Convert.ToInt32 (Console.ReadLine());
double result = Math.Sqrt ((Bx - Ax)^2 + (By - Ay)^2 + (Bz - Az)^2);




Console.WriteLine (result);

