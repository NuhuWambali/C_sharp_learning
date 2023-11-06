using System;

Random random = new Random();
int randomNumber = random.Next(1000, 3000);

CountTo(randomNumber);
Console.WriteLine("flew away");


void CountTo(int max)
{
    for(int i=0; i<max; i++)
    {
        Console.WriteLine(@"$"+i);
      
    }
}