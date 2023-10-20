using System;
namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"

                    ***************************************
                    *                                     *
                    *      WELCOME TO C# GUESSING GAME    *
                    *                                     *
                    ***************************************
                THIS IS A SIMPLE GUESSING GAME 
                RULES:
                1.PLAYER CAN GUESS A NUMBER IN 6 TRIES ONLY
                2.YOU ARE REQUIRED TO ENTER THE NUMBER BETWEEN 1 AND 20
                3.YOU BEAT MY ROBOT IF YOU GUESS A CORRECT NUMBER OTHERWISE A ROBOT BEATS YOU

                ");
            Console.WriteLine(@"Are you ready to play? 
1.Yes
2.No");
            int getReadyNumber=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int num = random.Next(0,10);
            if (getReadyNumber == 1)
            {
                Console.WriteLine(@" Enter a guessing number");
                int guessingNumber=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(guessingNumber + " my guessing number");
                Console.WriteLine(num + " comp guessed number");
            }
            else
            {
                Console.WriteLine("good bye");
            }




        }
    }
}

