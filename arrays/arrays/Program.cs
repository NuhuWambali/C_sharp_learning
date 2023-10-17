using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //decraling an array
            string[] cars = {"nissan", "toyota", "Mitsubish", "Tesla"};
            Console.WriteLine(cars[3]);
            //change an array element
            cars[0] = "Range";
            //Console.WriteLine(cars[0]);
          /*  for(int i=0; i<cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }*/
          foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        } 
    }
}