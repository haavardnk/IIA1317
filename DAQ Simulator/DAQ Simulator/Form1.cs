using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DAQ_Simulator
{
    public partial class Form1 : Form
    {
        int dSensors = 3;
        int aSensors = 6;
        Sensor[] sObj;
        double sCountDown;
        double lCountDown;
        int nSamples;

        //General class for analog or digital sensor
        class Sensor
        {
            List<double> aValues;
            int dVal;
            int sId;
            Random rSensVal;
            string sType;
            List<string> sValues;
            List<string> sTimes;

            //New sensor by sensor id and sensor type. Sensor type should be "a" for analog and "d" for digital.
            public Sensor(int id, string type)
            {
                sId = id;
                sType = type;
                rSensVal = new Random(id);
                sValues = new List<string>(0);
                sTimes = new List<string>(0);
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
                double a = aValues.Average();
                //Save sample for logging
                DateTime dateTime = DateTime.Now;
                sTimes.Add(dateTime.ToString());
                sValues.Add(a.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture));
                return a;
            }
            //Returns Digital Sample
            public int GetDigitalSample()
            {
                dVal = rSensVal.Next(0, 2);
                //Save sample for logging
                DateTime dateTime = DateTime.Now;
                sTimes.Add(dateTime.ToString());
                sValues.Add(dVal.ToString());
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
            //Returns all samples since last log
            public List<String> GetSamples()
            {
                return sValues;
            }
            //Returns sample times
            public List<String> GetSampleTimes()
            {
                return sTimes;
            }
            public void SetLogZero()
            {
                sTimes.Clear();
                sValues.Clear();
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
            //Update wait timer countdowns
            if (sTime.Enabled)
            {
                sCountDown -= 0.1;
                sBtn.Text = "Wait - " + sCountDown.ToString("F0") + " s";
            }
            if (lTime.Enabled)
            {
                lCountDown -= 0.1;
                lBtn.Text = "Wait - " + lCountDown.ToString("F0") + " s";
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

        private void lBtn_Click(object sender, EventArgs e)
        {
            if (!lTime.Enabled)
            {
                DateTime dateTime = DateTime.Today;
                StringBuilder csv = new StringBuilder();
                string filePath = dateTime.ToString("d") + ".csv";
                //Adds column titles
                if (!File.Exists(filePath))
                {
                    String title = " ,";
                    for (int counter = 0; counter < sObj.Count(); counter++)
                    {
                        title +="Sensor " + sObj[counter].GetSensId().ToString();
                        if (counter != sObj.Count()-1)
                        {
                            title += ",";
                        }
                    }
                    csv.AppendLine(title);
                }
                List<String> sTimes = sObj[0].GetSampleTimes();
                //Add samples
                for (int counter = 0; counter < sTimes.Count(); counter++)
                {
                    string line = sTimes[counter] + ",";

                    for (int counter2 = 0; counter2 < sObj.Count(); counter2++)
                    {
                        List<String> sValues = sObj[counter2].GetSamples();
                        line += sValues[counter];
                        if (counter2 != sObj.Count() - 1)
                        {
                            line += ",";
                        }
                    }
                    csv.AppendLine(line);
                        
                }
                //Clear saved samples
                for (int counter = 0; counter < sObj.Count(); counter++)
                {
                    sObj[counter].SetLogZero();
                }
                //Make or append to file
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, csv.ToString());
                }
                else
                {
                    File.AppendAllText(filePath, csv.ToString());
                }
                //Update text on UI with filename and times logged
                nSamples += 1;
                nSampleTxt.Text = "File: " + filePath + ", logged " + nSamples + " times";
            }
            //Start logging time
            lTime.Start();
            lCountDown = Convert.ToDouble(lTimTxt.Text);
            lBtn.Text = "Wait - " + lCountDown.ToString("F0") + " s";
        }

        private void lTime_Tick(object sender, EventArgs e)
        {
            lTime.Stop();
            lBtn.Text = "Log to File";
        }

        private void lTimTxt_TextChanged(object sender, EventArgs e)
        {
            //Update logging timer value with new value if valid
            if (double.TryParse(lTimTxt.Text, out double n))
            {
                double timeDouble = Convert.ToDouble(lTimTxt.Text) * 1000;
                int timeInt = Convert.ToInt32(timeDouble);
                lTime.Interval = timeInt;
            }
        }
    }
}
