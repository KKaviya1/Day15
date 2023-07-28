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
                // Constructor
                IsConnected = false;
                BatteryLevel = 0;
                DisplayInfo = "Laptop Display";
            }

            public bool Connect()
            {
                // Implementation for Connect method
                IsConnected = true;
                return true;
            }

            public void Charge(int minutes)
            {
                // Implementation for Charge method
                BatteryLevel += minutes;
            }

            public string Display()
            {
                // Implementation for Display method
                return DisplayInfo;
            }
        }

    
}
