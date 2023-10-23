using System;
namespace AreaOfTheCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle");
            const double pi = 3.14;
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaOfTheCircle= pi * radius * radius;
            Console.WriteLine("radius is {0}, and area is {1}", radius, areaOfTheCircle);
        }
    }
}