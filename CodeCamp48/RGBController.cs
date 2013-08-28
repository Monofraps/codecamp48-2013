using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp48
{
    class RGBController
    {
        // pin5
        public static void setGreen(int val)
        {
            ArduinoCommunicator.analogWrite(5, val);
        }

        // pin3
        public static void setRed(int val)
        {
            ArduinoCommunicator.analogWrite(3, val);
        }

        // pin6
        public static void setBlue(int val)
        {
            ArduinoCommunicator.analogWrite(6, val);
        }
    }
}
