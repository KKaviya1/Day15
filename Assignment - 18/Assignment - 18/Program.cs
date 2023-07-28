//using Assignment18;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment18
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//                Smartphone smartphone = new Smartphone();
//                Laptop laptop = new Laptop();

//                // Connect the devices
//                smartphone.Connect();
//                laptop.Connect();

//                // Charge the devices
//                smartphone.Charge(120); // Charge the smartphone for 120 minutes
//                laptop.Charge(180);     // Charge the laptop for 180 minutes

//                // Display device information
//                Console.WriteLine("Smartphone Information:");
//                Console.WriteLine($"Is Connected: {smartphone.IsConnected}");
//                Console.WriteLine($"Battery Level: {smartphone.BatteryLevel}");
//                Console.WriteLine($"Display Info: {smartphone.Display()}");

//                Console.WriteLine();

//                Console.WriteLine("Laptop Information:");
//                Console.WriteLine($"Is Connected: {laptop.IsConnected}");
//                Console.WriteLine($"Battery Level: {laptop.BatteryLevel}");
//                Console.WriteLine($"Display Info: {laptop.Display()}");

//                Console.ReadLine();
//            }
//        }

//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            Laptop laptop = new Laptop();

            Console.WriteLine("**Welcome to the Electronic Device Simulation**");
      
            Console.WriteLine("\nConnecting the Smartphone...");
            smartphone.Connect();
            Console.WriteLine("Smartphone connected!");

            Console.WriteLine("\nConnecting the Laptop...");
            laptop.Connect();
            Console.WriteLine("Laptop connected!");

            Console.Write("\nEnter charging time for the Smartphone (minutes): ");
            int smartphoneChargeTime = int.Parse(Console.ReadLine());
            smartphone.Charge(smartphoneChargeTime);

            Console.Write("Enter charging time for the Laptop (minutes): ");
            int laptopChargeTime = int.Parse(Console.ReadLine());
            laptop.Charge(laptopChargeTime);

            Console.WriteLine("\nSmartphone Information:");
            Console.WriteLine($"Battery Level: {smartphone.BatteryLevel}");
            Console.WriteLine($"Display Info: {smartphone.Display()}");

            Console.WriteLine("\nLaptop Information:");
            Console.WriteLine($"Battery Level: {laptop.BatteryLevel}");
            Console.WriteLine($"Display Info: {laptop.Display()}");


            Console.ReadKey();
        }

    }
}
