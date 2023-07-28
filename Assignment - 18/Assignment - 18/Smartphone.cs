using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }
        public string DisplayInfo { get; private set; }

        public Smartphone()
        {
            BatteryLevel = 0;
            DisplayInfo = "Smartphone Display";
        }

        public bool Connect()
        {
            Console.WriteLine("*Connected Successfully - SmartPhone*");
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
