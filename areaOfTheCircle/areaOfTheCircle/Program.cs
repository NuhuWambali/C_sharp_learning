using System;
namespace AreaOfTheCirle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("enter the radius of the cirle in meter");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaCirle = pi * radius * radius;
            Console.WriteLine(" radius : {0} and the area is {1}",radius,areaCirle);
        }
    }
}