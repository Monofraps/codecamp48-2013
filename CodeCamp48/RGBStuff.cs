using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCamp48
{
    public partial class RGBStuff : Form
    {
        private struct Color
        {
            public int r, g, b;

            public Color(int red, int green, int blue)
            {
                r = red;
                g = green;
                b = blue;
            }

            public void apply()
            {
                RGBController.setRed(255 - r);
                RGBController.setGreen(255 - g);
                RGBController.setBlue(255 - b);
            }
        }


        private List<Color> colors = new List<Color>();
        private int currentIndex = 0;

        public RGBStuff()
        {
            InitializeComponent();

            colors.Add(new Color(0, 0, 255));
            colors.Add(new Color(255, 0, 0));
            colors.Add(new Color(0, 255, 0));

            ArduinoCommunicator.Probe();

            ArduinoCommunicator.PinMode(3, ArduinoCommunicator.PinDirection.Output);
            ArduinoCommunicator.PinMode(5, ArduinoCommunicator.PinDirection.Output);
            ArduinoCommunicator.PinMode(6, ArduinoCommunicator.PinDirection.Output);

            ArduinoCommunicator.DigitalWrite(3, ArduinoCommunicator.DigitalValue.High);
            ArduinoCommunicator.DigitalWrite(5, ArduinoCommunicator.DigitalValue.High);
            ArduinoCommunicator.DigitalWrite(6, ArduinoCommunicator.DigitalValue.High);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex + 1 > colors.Count)
            {
                currentIndex = 0;
            }

            colors[currentIndex++].apply();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            colors.Add(new Color(Convert.ToInt32(nudRed.Value), Convert.ToInt32(nudGreen.Value), Convert.ToInt32(nudBlue.Value)));
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            new Color(Convert.ToInt32(nudRed.Value), Convert.ToInt32(nudGreen.Value), Convert.ToInt32(nudBlue.Value)).apply();
        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10 * 3; i++)
            {
                button1_Click(null, null);
                Thread.Sleep(100);
            }
        }
    }
}
