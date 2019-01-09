using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQ_Simulator
{
    public partial class Form1 : Form
    {
        int dSensors = 3;
        int aSensors = 6;
        Sensor[] sObj;
        double sCountDown;

        //General class for analog or digital sensor
        class Sensor
        {
            List<double> aValues;
            int dVal;
            int sId;
            Random rSensVal;
            string sType;

            //New sensor by sensor id and sensor type. Sensor type should be "a" for analog and "d" for digital.
            public Sensor(int id, string type)
            {
                sId = id;
                sType = type;
                rSensVal = new Random(id);
                if (sType == "a")
                {
                    aValues = new List<double>(10) { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
                }
                else
                {
                    dVal = 0;
                }
            }

            //Samples given analog sensor
            public void SampleAnalogValue()
            {
                aValues.Insert(0, rSensVal.Next(0, 256) / 25.5);
                aValues.RemoveAt(aValues.Count - 1);
            }

            //Returns MA filtered sample for Analog sensor
            public double GetAnalogSample()
            {
                return aValues.Average();
            }
            //Returns Digital Sample
            public int GetDigitalSample()
            {
                dVal = rSensVal.Next(0, 2);
                return dVal;
            }
            //Returns sensor id of given sensor
            public int GetSensId()
            {
                return sId;
            }
            //Returns sensor type of given sensor
            public string GetSensType()
            {
                return sType;
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Create an array of sensor objects
            sObj = new Sensor[aSensors + dSensors];
            // Creating the sensors
            for (int counter = 0; counter < aSensors + dSensors; counter++)
            {
                if (counter < aSensors)
                {
                    sObj[counter] = new Sensor(counter, "a");
                }
                else
                {
                    sObj[counter] = new Sensor(counter, "d");
                }
            }
        }



        private void sBtn_Click(object sender, EventArgs e)
        {
            if (!sTime.Enabled)
            {
                //Clear current text
                aTxt.Clear();
                dTxt.Clear();
                // Get the object values as a string
                for (int counter = 0; counter < sObj.Count(); counter++)
                {
                    if (sObj[counter].GetSensType() == "a")
                    {
                        aTxt.AppendText("Sensor " + sObj[counter].GetSensId().ToString() + ": " +
                            sObj[counter].GetAnalogSample().ToString("F3") + "V" + "\r\n");
                    }
                    else
                    {
                        dTxt.AppendText("Sensor " + sObj[counter].GetSensId().ToString() + ": " +
                            sObj[counter].GetDigitalSample().ToString() + "\r\n");
                    }
                }
                //Start sampling time
                sTime.Start();
                sCountDown = Convert.ToDouble(sTimTxt.Text);
                sBtn.Text = "Wait - " + sCountDown.ToString("F0") + " s";
            }
        }

        private void sTick_Tick(object sender, EventArgs e)
        {
            //Take analog sample every tick
            for (int counter = 0; counter < aSensors; counter++)
            {
                sObj[counter].SampleAnalogValue();
            }
            //Update wait timer countdown
            if (sTime.Enabled)
            {
                sCountDown -= 0.1;
                sBtn.Text = "Wait - " + sCountDown.ToString("F0") + " s";
            }
        }

        private void sTime_Tick(object sender, EventArgs e)
        {
            sTime.Stop();
            sBtn.Text = "Sample";
        }

        private void sTimTxt_TextChanged(object sender, EventArgs e)
        {
            //Update sample timer value with new value if valid
            if (double.TryParse(sTimTxt.Text, out double n))
            {
                double timeDouble = Convert.ToDouble(sTimTxt.Text) * 1000;
                int timeInt = Convert.ToInt32(timeDouble);
                sTime.Interval = timeInt;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DAQ Simulator for sampling 6 analog and 3 digital sensors.\r\n" +
                "- Click 'Sample' to take a sample from the sensors, " +
                "analog sensors is filtered with Moving Average last second.\r\n" +
                "- Click 'Log To File' to save all previous samples since last logging.\r\n" +
                "- Minimum sampling and logging time is user specified, default to assignment spec.",
                "About", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
