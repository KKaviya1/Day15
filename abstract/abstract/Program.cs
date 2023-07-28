using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurAb obj = new OurAb();  
            //error cam not create object of abstract class

            DriveClass obj = new DriveClass();
            obj.Welcome("Viya");
            obj.Display();

            Console.ReadKey();
        }
    }
}
