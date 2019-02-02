using System;
using System.Collections.Generic;
using System.Linq;

namespace DAQ_Simulator
{
    //General class for analog or digital sensor
    public abstract class Sensor
    {

        public readonly int sensorId;
        public readonly Random randomSensorValue;
        public string sensorType;
        public readonly List<string> sampleValues = new List<int>();
        public readonly List<string> sampleTimes = new List<DateTime>();


        //New sensor by sensor id and sensor type. Sensor type should be "a" for analog and "d" for digital.
        protected Sensor(int id)
        {
            sensorId = id;
            randomSensorValue = new Random(id);
        }

        public abstract double GetSample();

        //Returns sensor id of given sensor
        public int GetSensId()
        {
            return sensorId;
        }
        //Returns sensor type of given sensor
        public string GetSensType()
        {
            return sensorType;
        }
        //Returns all samples since last log
        public List<string> GetSampleBuffer()
        {
            return sampleValues;
        }
        //Returns sample times
        public List<string> GetSampleTimes()
        {
            return sampleTimes;
        }
        public void SetLogZero()
        {
            sampleTimes.Clear();
            sampleValues.Clear();
        }
    }
}
