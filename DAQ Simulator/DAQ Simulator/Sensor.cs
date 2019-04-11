using System;
using System.Collections.Generic;
using System.Linq;

namespace DAQ_Simulator
{
    //General class for analog or digital sensor
    public abstract class Sensor
    {

        public string Type { get; set; }
        public int Id { get; set; }
        public readonly Random randomSensorValue;
        public readonly List<string> sampleValues = new List<string>();
        public readonly List<string> sampleTimes = new List<string>();
        

        protected Sensor(int id)
        {
            Id = id;
            randomSensorValue = new Random(id);
        }

        // Abstract to fill in subclasses
        public abstract double GetSample();


        //Returns all samples in buffer
        public List<string> GetSampleBuffer()
        {
            return sampleValues;
        }
        //Returns sample times
        public List<string> GetSampleTimes()
        {
            return sampleTimes;
        }

        // Clears sample buffer
        public void SetLogZero()
        {
            sampleTimes.Clear();
            sampleValues.Clear();
        }


    }
}
