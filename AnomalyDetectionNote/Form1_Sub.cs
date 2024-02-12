using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace AnomalyDetectionNote
{
    public partial class Form1 : Form
    {


        private List<TimeSeriesDataFloat> getTimeSeriesDataFloatList(string[] lines)
        {
            var timeSeriesData = new List<TimeSeriesDataFloat>();

            foreach (var line in lines)
            {
                if (line.StartsWith("time")) continue;

                var splitLine = line.Split(',');
                timeSeriesData.Add(new TimeSeriesDataFloat
                {
                    time = int.Parse(splitLine[0]),
                    value = float.Parse(splitLine[1])
                });
            }

            return timeSeriesData;

        }


        private List<TimeSeriesDataDouble> getTimeSeriesDataDoubleList(string[] lines)
        {
            var timeSeriesData = new List<TimeSeriesDataDouble>();

            foreach (var line in lines)
            {
                if (line.StartsWith("time")) continue;

                var splitLine = line.Split(',');
                timeSeriesData.Add(new TimeSeriesDataDouble
                {
                    time = int.Parse(splitLine[0]),
                    value = double.Parse(splitLine[1])
                });
            }

            return timeSeriesData;

        }

    }
}
