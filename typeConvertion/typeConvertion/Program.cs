using System;
namespace TypeConversionAplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 1234.5;
            int i;
            //cast double to int
            i = (int)d;
            Console.WriteLine("converted number is  \a "+i);

            Console.ReadKey();
        }
    }
}
