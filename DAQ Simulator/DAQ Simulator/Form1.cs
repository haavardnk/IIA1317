using System;
using System.Windows.Forms;

namespace DAQ_Simulator
{
    public partial class Form1 : Form
    {
        //Initialize variables
        private const int DigitalSensors = 3;
        private const int AnalogSensors = 6;
        private readonly Sensor[] _sObj;
        private double _sampleCountDown;
        private double _logCountDown;
        private int _numberOfSamples;

        public Form1()
        {
            InitializeComponent();
            
            _sObj = new Sensor[AnalogSensors + DigitalSensors]; // Create an array of sensor objects
            for (var i = 0; i < AnalogSensors + DigitalSensors; i++) // Creating the sensors
            {
                if (i < AnalogSensors)
                {
                    _sObj[i] = new Sensor(i, "a");
                }
                else
                {
                    _sObj[i] = new Sensor(i, "d");
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

                var texts = SampleOperations.SampleSensors(_sObj);

                //Update text fields
                aTxt.Text = texts[0].ToString();
                dTxt.Text = texts[1].ToString();

                //Start sampling time
                sTime.Start();
                _sampleCountDown = Convert.ToDouble(sTimTxt.Text);
                sBtn.Text = "Wait - " + _sampleCountDown.ToString("F0") + " s";
            }
        }
        private void lBtn_Click(object sender, EventArgs e)
        {
            //Runs logging if logging timer not running
            if (!lTime.Enabled)
            {
                var filePath = FileOperations.LogToFile(_sObj);

                //Update text on UI with filename and times logged
                _numberOfSamples += 1;
                nSampleTxt.Text = "File: " + filePath + ", logged " + _numberOfSamples + " times";
                //Start logging time
                lTime.Start();
                _logCountDown = Convert.ToDouble(lTimTxt.Text);
                lBtn.Text = "Wait - " + _logCountDown.ToString("F0") + " s";
            }
        }

        private void sTick_Tick(object sender, EventArgs e)
        {
            //Take analog sample every tick
            for (var i = 0; i < AnalogSensors; i++)
            {
                _sObj[i].SampleAnalogValue();
            }
            //Update wait timer countdowns
            if (sTime.Enabled)
            {
                _sampleCountDown -= 0.1;
                sBtn.Text = "Wait - " + _sampleCountDown.ToString("F0") + " s";
            }
            if (lTime.Enabled)
            {
                _logCountDown -= 0.1;
                lBtn.Text = "Wait - " + _logCountDown.ToString("F0") + " s";
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
