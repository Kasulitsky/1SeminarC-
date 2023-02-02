int numberA = new Random().Next (1,30);
int numberB = new Random().Next (1,30);
int numberC = new Random().Next (1,30);
int max = numberA;
if (numberB > numberA)
    {
        max = numberB;
    }
        else 
            if (numberA < numberC)
            {
                max = numberC;
            }
Console.Write ("numberA="); Console.WriteLine (numberA);
Console.Write ("numberB="); Console.WriteLine (numberB);
Console.Write ("numberC="); Console.WriteLine (numberC);
Console.Write ("max="); Console.Write (max);