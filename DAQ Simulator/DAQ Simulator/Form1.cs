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
        //Initialize variables
        const int DSensors = 3;
        const int ASensors = 6;
        Sensor[] sObj;
        double sCountDown;
        double lCountDown;
        int nSamples;

        public Form1()
        {
            InitializeComponent();
            
            sObj = new Sensor[ASensors + DSensors]; // Create an array of sensor objects
            for (var i = 0; i < ASensors + DSensors; i++) // Creating the sensors
            {
                if (i < ASensors)
                {
                    sObj[i] = new Sensor(i, "a");
                }
                else
                {
                    sObj[i] = new Sensor(i, "d");
                }
            }
        }
        
        private void sBtn_Click(object sender, EventArgs e)
        {
            //Runs sampling if sampling timer not running
            if (!sTime.Enabled)
            {
                //Clear current text
                aTxt.Clear();
                dTxt.Clear();

                var texts = SampleOperations.SampleSensors(sObj);

                //Update text fields
                aTxt.Text = texts[0].ToString();
                dTxt.Text = texts[1].ToString();

                //Start sampling time
                sTime.Start();
                sCountDown = Convert.ToDouble(sTimTxt.Text);
                sBtn.Text = "Wait - " + sCountDown.ToString("F0") + " s";
            }
        }
        private void lBtn_Click(object sender, EventArgs e)
        {
            //Runs logging if logging timer not running
            if (!lTime.Enabled)
            {
                var filePath = FileOperations.LogToFile(sObj);

                //Update text on UI with filename and times logged
                nSamples += 1;
                nSampleTxt.Text = "File: " + filePath + ", logged " + nSamples + " times";
                //Start logging time
                lTime.Start();
                lCountDown = Convert.ToDouble(lTimTxt.Text);
                lBtn.Text = "Wait - " + lCountDown.ToString("F0") + " s";
            }
        }

        private void sTick_Tick(object sender, EventArgs e)
        {
            //Take analog sample every tick
            for (var i = 0; i < ASensors; i++)
            {
                sObj[i].SampleAnalogValue();
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
            //Stops sample timer when time is up and reset button text
            sTime.Stop();
            sBtn.Text = "Sample";
        }
        private void lTime_Tick(object sender, EventArgs e)
        {
            //Stops logging timer when time is up and reset button text
            lTime.Stop();
            lBtn.Text = "Log to File";
        }

        private void sTimTxt_TextChanged(object sender, EventArgs e)
        {
            //Update sample timer value with new value if valid
            if (double.TryParse(sTimTxt.Text, out double n))
            {
                var timeDouble = Convert.ToDouble(sTimTxt.Text) * 1000;
                var timeInt = Convert.ToInt32(timeDouble);
                sTime.Interval = timeInt;
            }
        }

        private void lTimTxt_TextChanged(object sender, EventArgs e)
        {
            //Update logging timer value with new value if valid
            if (double.TryParse(lTimTxt.Text, out var n))
            {
                var timeDouble = Convert.ToDouble(lTimTxt.Text) * 1000;
                var timeInt = Convert.ToInt32(timeDouble);
                lTime.Interval = timeInt;
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
        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Button in menu to exit application
            this.Close();
        }
    }
}
