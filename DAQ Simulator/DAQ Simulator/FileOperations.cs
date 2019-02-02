using System;
using System.Linq;
using System.Text;
using System.IO;

namespace DAQ_Simulator
{
    public class FileOperations
    {
        // Method to log saved samples to file
        public static string LogToFile(Sensor[] analogSensors, Sensor[] digitalSensors)
        {
            var dateTime = DateTime.Today;
            var csv = new StringBuilder();
            var filePath = dateTime.ToString("d") + ".csv";
            //Adds column titles
            if (!File.Exists(filePath))
            {
                var title = " ,";
                foreach(var sensor in analogSensors)
                {
                    title += "Sensor " + sensor.GetSensId() + ",";
                }

                foreach (var sensor in digitalSensors)
                {
                    title += "Sensor " + sensor.GetSensId() + ",";
                }

                title.Remove(title.Length -1);
                csv.AppendLine(title);
            }

            var sTimes = analogSensors[0].GetSampleTimes();

            //Add samples
            for (var i = 0; i < sTimes.Count(); i++)
            {
                var line = sTimes[i] + ",";
                
                foreach (var sensor in analogSensors)
                {
                    line += sensor.GetSampleBuffer() + ",";
                }

                foreach (var sensor in digitalSensors)
                {
                    line += sensor.GetSampleBuffer() + ",";
                }
      
                line.Remove(line.Length - 1);
                csv.AppendLine(line);

            }
            //Clear saved samples
            foreach (var sensor in analogSensors)
            {
                sensor.SetLogZero();
            }

            foreach (var sensor in digitalSensors)
            {
                sensor.SetLogZero();
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
