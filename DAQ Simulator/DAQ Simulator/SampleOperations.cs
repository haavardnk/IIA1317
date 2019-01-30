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
        public static List<StringBuilder> SampleSensors(Sensor[] sObj)
        {
            var aTxt = new StringBuilder();
            var dTxt = new StringBuilder();
            // Get the object values as a string
            for (var i = 0; i < sObj.Count(); i++)
            {
                if (sObj[i].GetSensType() == "a")
                {
                    aTxt.Append("Sensor " + sObj[i].GetSensId().ToString() + ": " +
                                    sObj[i].GetAnalogSample().ToString("F3") + "V" + "\r\n");
                }
                else
                {
                    dTxt.Append("Sensor " + sObj[i].GetSensId().ToString() + ": " +
                                    sObj[i].GetDigitalSample().ToString() + "\r\n");
                }
            }
            return new List<StringBuilder> {aTxt, dTxt};
        }
    }
}
