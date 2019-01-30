using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAQ_Simulator
{
    public class FileOperations
    {
        // Method to log saved samples to file
        public static string LogToFile(Sensor[] sObj)
        {
            var dateTime = DateTime.Today;
            var csv = new StringBuilder();
            var filePath = dateTime.ToString("d") + ".csv";
            //Adds column titles
            if (!File.Exists(filePath))
            {
                var title = " ,";
                for (var i = 0; i < sObj.Count(); i++)
                {
                    title += "Sensor " + sObj[i].GetSensId().ToString();
                    if (i != sObj.Count() - 1)
                    {
                        title += ",";
                    }
                }
                csv.AppendLine(title);
            }
            var sTimes = sObj[0].GetSampleTimes();
            //Add samples
            for (var i = 0; i < sTimes.Count(); i++)
            {
                var line = sTimes[i] + ",";

                for (var j = 0; j < sObj.Count(); j++)
                {
                    var sValues = sObj[j].GetSamples();
                    line += sValues[i];
                    if (j != sObj.Count() - 1)
                    {
                        line += ",";
                    }
                }
                csv.AppendLine(line);

            }
            //Clear saved samples
            for (var i = 0; i < sObj.Count(); i++)
            {
                sObj[i].SetLogZero();
            }
            //Make or append to file
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, csv.ToString());
            }
            else
            {
                File.AppendAllText(filePath, csv.ToString());
            }

            return filePath;
        }

    }
}
