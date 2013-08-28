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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.RunDirectQuery(tbDirectQuery.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ArduinoCommunicator.AnalogWrite(11, Convert.ToInt32(tbDirectQuery.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(13, ArduinoCommunicator.PinDirection.Output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(11, ArduinoCommunicator.DigitalValue.High);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(11, ArduinoCommunicator.DigitalValue.Low);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(11, ArduinoCommunicator.PinDirection.Output);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new PinControl().Show();
        }

        private void lbCommandRoots_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ListBox)sender).SelectedItem.ToString())
            {
                case "pinmode":
                    tbDirectQuery.Text = "pinmode/";
                    lbParameter1.Items.Clear();
                    for (int i = 3; i <= 13; i++)
                    {
                        lbParameter1.Items.Add(i);
                    }
                    lbParameter2.Items.Clear();
                    lbParameter2.Items.Add("in");
                    lbParameter2.Items.Add("out");
                    lbParameter3.Items.Clear();
                    break;
                case "pullup":
                    tbDirectQuery.Text = "pullup/";
                    lbParameter1.Items.Clear();
                    for (int i = 3; i <= 13; i++)
                    {
                        lbParameter1.Items.Add(i);
                    }
                    lbParameter2.Items.Clear();
                    lbParameter2.Items.Add("on");
                    lbParameter2.Items.Add("off");
                    lbParameter3.Items.Clear();
                    break;

                case "read":
                    tbDirectQuery.Text = "read/";
                    lbParameter1.Items.Clear();
                    lbParameter1.Items.Add("analog");
                    lbParameter1.Items.Add("digital");
                    lbParameter2.Items.Clear();
                    for (int i = 3; i <= 13; i++)
                    {
                        lbParameter2.Items.Add(i);
                    }
                    lbParameter3.Items.Clear();
                    break;
                case "write":
                    tbDirectQuery.Text = "write/";
                    lbParameter1.Items.Clear();
                    lbParameter1.Items.Add("analog");
                    lbParameter1.Items.Add("digital");
                    lbParameter2.Items.Clear();
                    for (int i = 3; i <= 13; i++)
                    {
                        lbParameter2.Items.Add(i);
                    }
                    lbParameter3.Items.Clear();
                    break;
            }
        }

        private void lbParameter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDirectQuery.Text = lbCommandRoots.SelectedItem.ToString() + "/" + ((ListBox)sender).SelectedItem.ToString();
            if (lbParameter2.SelectedItem != null)
            {
                tbDirectQuery.Text += "/" + lbParameter2.SelectedItem.ToString();
            }

            if(lbCommandRoots.SelectedItem.ToString().Equals("read")) {
                if (lbParameter1.SelectedItem.ToString().Equals("analog"))
                {
                    lbParameter2.Items.Clear();
                    for (int i = 0; i <= 5; i++)
                    {
                        lbParameter2.Items.Add(i);
                    }
                }
                else if(lbParameter1.SelectedItem.ToString().Equals("digital"))
                {
                    lbParameter2.Items.Clear();
                    for (int i = 3; i <= 13; i++)
                    {
                        lbParameter2.Items.Add(i);
                    }
                }
            }
            if (lbCommandRoots.SelectedItem.ToString().Equals("write"))
            {
                if (lbParameter1.SelectedItem.ToString().Equals("analog"))
                {
                    lbParameter2.Items.Clear();
                    lbParameter2.Items.Add(3);
                    lbParameter2.Items.Add(5);
                    lbParameter2.Items.Add(6);
                    lbParameter2.Items.Add(9);
                    lbParameter2.Items.Add(10);
                    lbParameter2.Items.Add(11);

                    lbParameter3.Items.Clear();
                    for (int i = 0; i <= 255; i++)
                    {
                        lbParameter3.Items.Add(i);
                    }
                }
                else if (lbParameter1.SelectedItem.ToString().Equals("digital"))
                {
                    lbParameter2.Items.Clear();
                    for (int i = 3; i <= 13; i++)
                    {
                        lbParameter2.Items.Add(i);
                    }

                    lbParameter3.Items.Clear();
                    for (int i = 0; i <= 1; i++)
                    {
                        lbParameter3.Items.Add(i);
                    }
                }
            }
        }

        private void lbParameter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDirectQuery.Text = lbCommandRoots.SelectedItem.ToString() + "/" + lbParameter1.SelectedItem.ToString() + "/" + ((ListBox)sender).SelectedItem.ToString();
            if (lbParameter3.SelectedItem != null)
            {
                tbDirectQuery.Text += "/" + lbParameter3.SelectedItem.ToString();
            }
        }

        private void lbParameter3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDirectQuery.Text = lbCommandRoots.SelectedItem.ToString() + "/" + lbParameter1.SelectedItem.ToString() + "/" + lbParameter2.SelectedItem.ToString() + "/" + ((ListBox)sender).SelectedItem.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new RGBStuff().Show();
        }

        private void btnProbe_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.Probe();
        }
    }
}
