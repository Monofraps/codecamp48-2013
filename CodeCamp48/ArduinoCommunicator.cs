using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCamp48
{
    class ArduinoCommunicator
    {
        private static String ComPort = "COM3";

        public enum PinDirection
        {
            Output, Input
        }

        public enum DigitalValue
        {
            High, Low
        }

        public static void Probe()
        {
            for (int i = 0; i < 7; i++)
            {
                try
                {
                    SerialPort port = new SerialPort("COM" + i.ToString(), 9600);
                    port.Open();
                    port.Write("ping\n");
                    port.ReadTimeout = 2000;
                    if (port.ReadLine().Equals("pong\r"))
                    {
                        ComPort = "COM" + i.ToString();
                    }
                    Thread.Sleep(20);
                    port.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        public static bool RunDirectQuery(String query)
        {
            try
            {
                SerialPort port = new SerialPort(ComPort, 9600);
                port.Open();
                port.Write(query + '\n');
                port.ReadTimeout = 2000;
                string retCode = port.ReadLine().Trim(new char[] { '\r', '\n' });
                Thread.Sleep(20);
                port.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                return false;
            }
        }

        public static bool PinMode(int pin, PinDirection direction)
        {
            return RunDirectQuery("pinmode/" + pin + "/" + (direction.Equals(PinDirection.Input) ? "in" : "out"));
        }

        public static bool DigitalWrite(int pin, DigitalValue digValue)
        {
            return RunDirectQuery("write/digital/" + pin + "/" + (digValue.Equals(DigitalValue.High) ? "1" : "0"));
        }

        public static int DigitalRead(int pin)
        {
            int result = -1;

            try
            {
                SerialPort port = new SerialPort(ComPort, 9600);
                port.Open();
                port.Write("read/digital/" + pin + '\n');
                result = Convert.ToInt32(port.ReadLine());
                Thread.Sleep(50);
                port.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                return -1;
            }
        }

        public static bool AnalogWrite(int pin, int value)
        {
            return RunDirectQuery("write/analog/" + pin + "/" + value);
        }

        public static int AnalogRead(int pin)
        {
            int result = -1;

            try
            {
                SerialPort port = new SerialPort(ComPort, 9600);
                port.Open();
                port.Write("read/analog/" + pin + '\n');
                System.Threading.Thread.Sleep(100);
                result = Convert.ToInt32(port.ReadLine());
                port.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                return -1;
            }
        }
    }
}
