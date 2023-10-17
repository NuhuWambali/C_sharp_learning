using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dy teller System");
            Console.WriteLine("Enter the number of day and we tell you the name of that month");
            int month = Convert.ToInt32(Console.ReadLine());
            switch(month)
            {
                case 1:
                    Console.WriteLine("You choose : Monday ");
                    break;
                case 2:
                    Console.WriteLine("You choose : Tuesday ");
                    break;
                case 3:
                    Console.WriteLine("You choose : Wednesday");
                    break;
                case 4:
                    Console.WriteLine("You choose : Thursday");
                    break;
                case 5:
                    Console.WriteLine("You choose : Friday");
                    break;
                case 6:
                    Console.WriteLine("You choose : Saturday");
                    break;
                case 7:
                    Console.WriteLine("You choose : Sunday");
                    break;

            }

        }
    }
}
