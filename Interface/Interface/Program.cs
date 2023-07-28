//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interface
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            OurClass ourClass = new OurClass();
//            ourClass.Display();
//            ourClass.Welcome("Viya");

//            Console.ReadKey();
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass obj = new OurClass();
            IMyInterface my = obj;
            my.Display();

            IMyInterfaceTwo myInterfaceTwo = obj;
            myInterfaceTwo.Display();

            Console.ReadKey();
        }
    }
}
