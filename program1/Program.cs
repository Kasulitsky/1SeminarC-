int numberA = new Random().Next(-10,10);
int numberB = new Random().Next(-10,10);
int max = (0);
int min = (0);
if(numberA > numberB)
{
    max = numberA; min = numberB;
}  
else 
{
    max = numberB; min = numberA;
}
Console.Write("max"); Console.Write(max);  
Console.Write("min"); Console.Write(min);  
