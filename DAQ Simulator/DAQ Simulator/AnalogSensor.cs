using System;
using System.Collections.Generic;
using System.Linq;

namespace DAQ_Simulator
{
    public class AnalogSensor : Sensor
    {
        private readonly List<double> _analogValues;
        public AnalogSensor(int id) : base(id)
        {
            Type = "Analog";
            _analogValues = new List<double>(new double[10]);
        }
        // Returns MA filtered sample
        public override double GetSample()
        {
            var average = _analogValues.Average();
            //Save sample for logging
            var dateTime = DateTime.Now;
            sampleTimes.Add(dateTime.ToLongTimeString());
            sampleValues.Add(average.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture));
            return average;
        }
        // Background sampling
        public void SampleToFilterBuffer()
        {
            _analogValues.Insert(0, randomSensorValue.Next(0, 256) / 25.5);
            _analogValues.RemoveAt(_analogValues.Count - 1);
        }
    }
}