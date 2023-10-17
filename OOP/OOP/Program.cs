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
using System;

namespace Program
{
    class User
    {
        private string name = "Nuhu";

    }

    class Program
    {
        static void Main(string[] args)
        {
            User myObj = new User();
            Console.WriteLine(myObj.name);
        }
    }

}

