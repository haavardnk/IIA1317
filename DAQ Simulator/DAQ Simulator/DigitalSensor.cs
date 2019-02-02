using System;

namespace DAQ_Simulator
{
    public class DigitalSensor : Sensor
    {
        private int _digitalValue;
        public DigitalSensor(int id) : base(id)
        {
            _digitalValue = 0;
            sensorType = "Digital";
        }

        public override double GetSample()
        {
            _digitalValue = randomSensorValue.Next(0, 2);
            //Save sample for logging
            var dateTime = DateTime.Now;
            sampleTimes.Add(dateTime.ToLongTimeString());
            sampleValues.Add(_digitalValue.ToString());
            return _digitalValue;
        }
    }
}