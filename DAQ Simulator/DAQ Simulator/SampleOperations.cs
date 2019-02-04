using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ_Simulator
{
    public class SampleOperations
    {
        //Method to Sample sensors and return new text
        public static StringBuilder SampleSensors(Sensor[] sObj)
        {
            var text = new StringBuilder();
            // Get the object values as a string
            for (var i = 0; i < sObj.Count(); i++)
            {
                if (sObj[i].Type == "Analog")
                {
                    text.Append("Sensor " + sObj[i].Id.ToString() + ": " +
                                    sObj[i].GetSample().ToString("F3") + "V" + "\r\n");
                }
                else
                {
                    text.Append("Sensor " + sObj[i].Id.ToString() + ": " +
                                    sObj[i].GetSample().ToString() + "\r\n");
                }
            }
            return text;
        }
    }
}
