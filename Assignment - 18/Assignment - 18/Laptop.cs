using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
        public class Laptop : IConnectable, IRechargeable, IDisplayable
        {
            public bool IsConnected { get; private set; }
            public int BatteryLevel { get; private set; }
            public string DisplayInfo { get; private set; }

            public Laptop()
            {
                BatteryLevel = 0;
                DisplayInfo = "Laptop Display";
            }

            public bool Connect()
            {
                 Console.WriteLine("*Connected Successfully - Laptop*");
                 return true;
            }

            public void Charge(int minutes)
            {
                BatteryLevel += minutes;
            }

            public string Display()
            {
                return DisplayInfo;
            }
        }

    
}
