//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interface
//{
//    public class OurClass : IMyInterface, IMyInterfaceTwo
//    {
//        public void Display()
//        {
//            Console.WriteLine("Display of IMyinterface");
//        }
//        public void Welcome(string name)
//        {
//            Console.WriteLine("Welcome to interface!!");
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
    public class OurClass : IMyInterface, IMyInterfaceTwo
    {
        void IMyInterface.Display()
        {
            Console.WriteLine("Display of IMyinterface");
        }
         void IMyInterfaceTwo.Display()
        {
            Console.WriteLine("Welcome to interface!!");
        }
    }
}