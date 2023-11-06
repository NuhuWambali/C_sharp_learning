int[] a = { 1, 2, 3, 4, 5 };
int[] b= { 100, 200,300 };

Console.WriteLine("Contents of Array:");
PrintArray();
PrintNames();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}


void PrintNames()
{
    foreach(int x  in b)
    {
        Console.WriteLine(x);
    }
    Console.WriteLine();
}