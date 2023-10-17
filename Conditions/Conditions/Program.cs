using System;
namespace Condition
{
    class Program {
       static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the system");
            Console.WriteLine("What is your name? ");
            string myName = Console.ReadLine();
            Console.WriteLine("What is your age? ");
            int myAge = Convert.ToInt32(Console.ReadLine());
            if(myAge <= 17)
            {
                Console.WriteLine($"Hello {myName} your under 18! your exactly age is {myAge}");
            }
            else
            {
                Console.WriteLine($"Hello {myName} your  18+ aged your exactly age is {myAge}");

            }
        }
    }

}

