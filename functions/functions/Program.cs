using System;
namespace Program {
    class Program
    {
      
        static void Main(string[] args)
        {
            MyFunction();
        }
        static void MyFunction()
        {
            Console.WriteLine("what is your name? ");
            string myName = Console.ReadLine();
            Console.WriteLine($" hello {myName}!, welcome to the system");
        }


    }

}

