﻿using System;
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
    public partial class PinControl : Form
    {
        private int[] analCache = new int[6];

        public PinControl()
        {
            InitializeComponent();
        }

        private void cbPin2Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(2, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void cbPin4Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(4, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void cbPin7Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(7, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void cbPin8Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(8, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void cbPin12Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(12, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void cbPin13Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(13, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void btnPin2SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(2, ArduinoCommunicator.DigitalValue.High);
        }

        private void btnPin4SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(4, ArduinoCommunicator.DigitalValue.High);
        }

        private void btnPin7SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(7, ArduinoCommunicator.DigitalValue.High);
        }

        private void btnPin8SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(8, ArduinoCommunicator.DigitalValue.High);
        }

        private void btnPin12SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(12, ArduinoCommunicator.DigitalValue.High);
        }

        private void btnPin13SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(13, ArduinoCommunicator.DigitalValue.High);
        }

        private void btnPin2SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(2, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin4SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(4, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin7SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(7, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin8SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(8, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin12SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(12, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin13SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(13, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin2Read_Click(object sender, EventArgs e)
        {
            lPin2Read.Text = ArduinoCommunicator.DigitalRead(2).ToString();
        }

        private void btnPin4Read_Click(object sender, EventArgs e)
        {
            lPin4Read.Text = ArduinoCommunicator.DigitalRead(4).ToString();
        }

        private void btnPin7Read_Click(object sender, EventArgs e)
        {
            lPin7Read.Text = ArduinoCommunicator.DigitalRead(7).ToString();
        }

        private void btnPin8Read_Click(object sender, EventArgs e)
        {
            lPin8Read.Text = ArduinoCommunicator.DigitalRead(8).ToString();
        }

        private void btnPin12Read_Click(object sender, EventArgs e)
        {
            lPin12Read.Text = ArduinoCommunicator.DigitalRead(12).ToString();
        }

        private void btnPin13Read_Click(object sender, EventArgs e)
        {
            lPin13Read.Text = ArduinoCommunicator.DigitalRead(13).ToString();
        }

        private void btnAnal0Read_Click(object sender, EventArgs e)
        {
            analCache[0] = ArduinoCommunicator.AnalogRead(0);
            renderAnalVals(0, cbAnal0DisplayMode, lAnal0Read);
        }

        private void btnAnal1Read_Click(object sender, EventArgs e)
        {
            analCache[1] = ArduinoCommunicator.AnalogRead(1);
            renderAnalVals(1, cbAnal1DisplayMode, lAnal1Read);
        }

        private void btnAnal2Read_Click(object sender, EventArgs e)
        {
            analCache[2] = ArduinoCommunicator.AnalogRead(2);
            renderAnalVals(2, cbAnal2DisplayMode, lAnal2Read);
        }

        private void btnAnal3Read_Click(object sender, EventArgs e)
        {
            analCache[3] = ArduinoCommunicator.AnalogRead(3); 
            renderAnalVals(3, cbAnal3DisplayMode, lAnal3Read);
        }

        private void btnAnal4Read_Click(object sender, EventArgs e)
        {
            analCache[4] = ArduinoCommunicator.AnalogRead(4);
            renderAnalVals(4, cbAnal4DisplayMode, lAnal4Read);
        }

        private void btnAnal5Read_Click(object sender, EventArgs e)
        {
            analCache[5] = ArduinoCommunicator.AnalogRead(5);
            renderAnalVals(5, cbAnal5DisplayMode, lAnal5Read);
        }

        private void tbPin3PWM_Scroll(object sender, EventArgs e)
        {
            ArduinoCommunicator.AnalogWrite(3, tbPin3PWM.Value);
        }

        private void tbPin5PWM_Scroll(object sender, EventArgs e)
        {
            ArduinoCommunicator.AnalogWrite(5, tbPin5PWM.Value);
        }

        private void tbPin6PWM_Scroll(object sender, EventArgs e)
        {
            ArduinoCommunicator.AnalogWrite(6, tbPin6PWM.Value);
        }

        private void tbPin9PWM_Scroll(object sender, EventArgs e)
        {
            ArduinoCommunicator.AnalogWrite(9, tbPin9PWM.Value);
        }

        private void tbPin10PWM_Scroll(object sender, EventArgs e)
        {
            ArduinoCommunicator.AnalogWrite(10, tbPin10PWM.Value);
        }

        private void tbPin11PWM_Scroll(object sender, EventArgs e)
        {
            ArduinoCommunicator.AnalogWrite(11, tbPin11PWM.Value);
        }

        private void btnPin3SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(3, ArduinoCommunicator.DigitalValue.High);
        }

        private void cbPin3Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(3, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void btnPin5SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(5, ArduinoCommunicator.DigitalValue.High);
        }

        private void cbPin6Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(6, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void btnPin6SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(6, ArduinoCommunicator.DigitalValue.High);
        }

        private void cbPin9Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(9, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void btnPin9SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(9, ArduinoCommunicator.DigitalValue.High);
        }

        private void cbPin10Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(10, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void btnPin10SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(10, ArduinoCommunicator.DigitalValue.High);
        }

        private void cbPin11Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArduinoCommunicator.PinMode(11, (((ComboBox)sender).SelectedIndex == 0) ? ArduinoCommunicator.PinDirection.Input : ArduinoCommunicator.PinDirection.Output);
        }

        private void btnPin11SetHigh_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(11, ArduinoCommunicator.DigitalValue.High);
        }

        private void btnPin3SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(3, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin5SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(5, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin6SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(6, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin9SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(9, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin10SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(10, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin11SetLow_Click(object sender, EventArgs e)
        {
            ArduinoCommunicator.DigitalWrite(11, ArduinoCommunicator.DigitalValue.Low);
        }

        private void btnPin3Read_Click(object sender, EventArgs e)
        {
            lPin3Read.Text = ArduinoCommunicator.DigitalRead(3).ToString();
        }

        private void btnPin5Read_Click(object sender, EventArgs e)
        {
            lPin5Read.Text = ArduinoCommunicator.DigitalRead(5).ToString();
        }

        private void btnPin6Read_Click(object sender, EventArgs e)
        {
            lPin6Read.Text = ArduinoCommunicator.DigitalRead(6).ToString();
        }

        private void btnPin9Read_Click(object sender, EventArgs e)
        {
            lPin9Read.Text = ArduinoCommunicator.DigitalRead(9).ToString();
        }

        private void btnPin10Read_Click(object sender, EventArgs e)
        {
            lPin10Read.Text = ArduinoCommunicator.DigitalRead(10).ToString();
        }

        private void btnPin11Read_Click(object sender, EventArgs e)
        {
            lPin11Read.Text = ArduinoCommunicator.DigitalRead(11).ToString();
        }

        private void cbAnal0DisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderAnalVals(0, (ComboBox)sender, lAnal0Read);
        }

        private float voltFromRaw(int raw)
        {
            return raw * (5F / 1023F);
        }

        private void cbAnal1DisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderAnalVals(1, (ComboBox)sender, lAnal1Read);
        }

        private void cbAnal2DisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderAnalVals(2, (ComboBox)sender, lAnal2Read);
        }

        private void cbAnal3DisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderAnalVals(3, (ComboBox)sender, lAnal3Read);
        }

        private void cbAnal4DisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderAnalVals(4, (ComboBox)sender, lAnal4Read);
        }

        private void cbAnal5DisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderAnalVals(5, (ComboBox)sender, lAnal5Read);
        }


        private void renderAnalVals(int adId, ComboBox renderMode, Label outLabel)
        {
            if (renderMode.SelectedItem == null)
            {
                renderMode.SelectedIndex = 0;
                return;
            }

            switch (renderMode.SelectedItem.ToString())
            {
                case "RAW":
                    outLabel.Text = analCache[adId].ToString();
                    break;

                case "V":
                    outLabel.Text = voltFromRaw(analCache[adId]).ToString();
                    break;
            }
        }
    }
}
