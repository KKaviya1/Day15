using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    public class DriveClass : OurAb
    {
        string myprop;
        public override string AbProp 
        { get => myprop; set => myprop = value; }
        public override void Welcome(string name)
        {
            Console.WriteLine("Welcome to Abstract class:" + name);
        }
}
}
