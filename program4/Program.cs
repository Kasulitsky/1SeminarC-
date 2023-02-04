// напиши программу, котораяна вход принимает число(N), а на выходе показывает все четные числа от 1 до (N).
Console.WriteLine ("введите число");
int a = Convert.ToInt32 (Console.ReadLine());
while (a != 0)
    {
        if (a < 0)
            {
            if (a % 2 == 0) 
                {
                    Console.WriteLine (a);
                    a = a + 2; 
                }
            else 
                {
                    a = a + 1;
                }
            }
        else
            if (a % 2 == 0)
                {
                    Console.WriteLine (a);
                    a = a - 2; 
                }
            else  
                {
                a = a - 1; 
                } 
    }