using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCamp48
{
    public partial class RGBStuff : Form
    {
        private struct Triple {
            public int r, g, b;

            public Triple(int red, int green, int blue)
            {
                r = red;
                g = green;
                b = blue;
            }

            public void apply()
            {
                RGBController.setRed(r);
                RGBController.setGreen(g);
                RGBController.setBlue(b);
            }
        }


        private List<Triple> colors = new List<Triple>();
        private int currentIndex = 0;

        public RGBStuff()
        {
            InitializeComponent();

            colors.Add(new Triple(0, 255, 255));
            colors.Add(new Triple(255, 0, 255));
            colors.Add(new Triple(255, 255, 0));

            ArduinoCommunicator.pinMode(3, ArduinoCommunicator.PinDirection.Output);
            ArduinoCommunicator.pinMode(5, ArduinoCommunicator.PinDirection.Output);
            ArduinoCommunicator.pinMode(6, ArduinoCommunicator.PinDirection.Output);

            ArduinoCommunicator.digitalWrite(3, ArduinoCommunicator.DigitalValue.High);
            ArduinoCommunicator.digitalWrite(5, ArduinoCommunicator.DigitalValue.High);
            ArduinoCommunicator.digitalWrite(6, ArduinoCommunicator.DigitalValue.High);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex + 1 > colors.Count)
            {
                currentIndex = 0;
            }

            colors[currentIndex++].apply();
        }
    }
}
