/* using System;
namespace Program {
   class Program
    {
        string color = "red";
        static void Main(string[] args)
        {
            Program myObj = new Program();
            Console.WriteLine(myObj.color);
        }
    }
}
*/


//public object

/*using System;
using System.Xml.Schema;

namespace Program
{
    class User
    {
        public string name="Nuhu";

    }

    class Program {
        static void Main(string[] args)
        {
            User myObj = new User();
            Console.WriteLine(myObj.name);
        }
    }

}
*/



//private object protected

/* using System;

namespace Program
{
    class User
    {
        private string name = "Nuhu";
        string email = "wambalinuhu@gmail.com";  

    }

    class Program
    {
        static void Main(string[] args)
        
            User myObj = new User(); 
            Console.WriteLine(myObj.name);
            Console.WriteLine(myObj.email);  
        }
    }

}

*/


using System;
namespace Program
{
    class Vehicle
    {
        public string color = "green";
        public void Honk()
        {
            Console.WriteLine(" Hooon! Hooon! Hooon!");
        }
    }

    class Car : Vehicle
    {
        public string carModel = "Nissan";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.carModel);
            Console.WriteLine(myCar.color);
            myCar.Honk();
        }
    }
}