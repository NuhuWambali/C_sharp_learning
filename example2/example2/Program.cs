using System;
using System.Numerics;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, welcome to the system");
            Console.WriteLine("What is your name ? ");
            string myName = Console.ReadLine();
            Console.WriteLine("What is your age ?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("thank you for your response");
            Console.WriteLine("Your name is " + myName + " and your age is " + myAge);
            bool isCSharpFun = true;
            Console.WriteLine(isCSharpFun);
        }
    }
}