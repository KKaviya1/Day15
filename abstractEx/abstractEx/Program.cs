using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.5);
            Console.WriteLine("Area of circle is " + circle.Area());
            Console.WriteLine("Perimeter of circle is " + circle.Area());


            Console.ReadKey();

        }
    }
}