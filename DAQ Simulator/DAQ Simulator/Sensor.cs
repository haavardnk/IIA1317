using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ_Simulator
{   //General class for analog or digital sensor
    public class Sensor
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
            var a = aValues.Average();
            //Save sample for logging
            var dateTime = DateTime.Now;
            sTimes.Add(dateTime.ToString());
            sValues.Add(a.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture));
            return a;
        }
        //Returns Digital Sample
        public int GetDigitalSample()
        {
            dVal = rSensVal.Next(0, 2);
            //Save sample for logging
            var dateTime = DateTime.Now;
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
        public List<string> GetSamples()
        {
            return sValues;
        }
        //Returns sample times
        public List<string> GetSampleTimes()
        {
            return sTimes;
        }
        public void SetLogZero()
        {
            sTimes.Clear();
            sValues.Clear();
        }
    }
}
