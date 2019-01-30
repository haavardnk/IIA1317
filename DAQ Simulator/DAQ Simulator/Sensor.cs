using System;
using System.Collections.Generic;
using System.Linq;

namespace DAQ_Simulator
{   //General class for analog or digital sensor
    public class Sensor
    {
        private  int _digitalValue;
        private readonly List<double> _analogValues;
        private readonly int _sensorId;
        private readonly Random _randomSensorValue;
        private readonly string _sensorType;
        private readonly List<string> _sampleValues = new List<string>(0);
        private readonly List<string> _sampleTimes = new List<string>(0);

        //New sensor by sensor id and sensor type. Sensor type should be "a" for analog and "d" for digital.
        public Sensor(int id, string type)
        {
            _sensorId = id;
            _sensorType = type;
            _randomSensorValue = new Random(id);
            if (_sensorType == "a")
            {
                _analogValues = new List<double>(new double[10]);
            }
            else
            {
                _digitalValue = 0;
            }
        }

        //Samples given analog sensor
        public void SampleAnalogValue()
        {
            _analogValues.Insert(0, _randomSensorValue.Next(0, 256) / 25.5);
            _analogValues.RemoveAt(_analogValues.Count - 1);
        }

        //Returns MA filtered sample for Analog sensor
        public double GetAnalogSample()
        {
            var average = _analogValues.Average();
            //Save sample for logging
            var dateTime = DateTime.Now;
            _sampleTimes.Add(dateTime.ToLongTimeString());
            _sampleValues.Add(average.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture));
            return average;
        }
        //Returns Digital Sample
        public int GetDigitalSample()
        {
            _digitalValue = _randomSensorValue.Next(0, 2);
            //Save sample for logging
            var dateTime = DateTime.Now;
            _sampleTimes.Add(dateTime.ToLongTimeString());
            _sampleValues.Add(_digitalValue.ToString());
            return _digitalValue;
        }
        //Returns sensor id of given sensor
        public int GetSensId()
        {
            return _sensorId;
        }
        //Returns sensor type of given sensor
        public string GetSensType()
        {
            return _sensorType;
        }
        //Returns all samples since last log
        public List<string> GetSamples()
        {
            return _sampleValues;
        }
        //Returns sample times
        public List<string> GetSampleTimes()
        {
            return _sampleTimes;
        }
        public void SetLogZero()
        {
            _sampleTimes.Clear();
            _sampleValues.Clear();
        }
    }
}
