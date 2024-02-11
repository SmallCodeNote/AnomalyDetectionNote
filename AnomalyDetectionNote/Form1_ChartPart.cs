using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnomalyDetectionNote
{
    public partial class Form1 : Form
    {

        private void UpdateChart(Chart chart, string[] lines, TrackBar ScaleTrackBar, char separateChar = ',',
            string xMin = "", string xMax = "", string xInterval = "",
            string yMin = "", string yMax = "", string yInterval = "", string seriesName = "Series1", double scaleStep = 10)
        {
            var series = new Series(seriesName);
            series.ChartType = SeriesChartType.Line;
            chart.Series.Clear();
            chart.Series.Add(series);

            foreach (var line in lines)
            {
                if (line.StartsWith("time")) continue; // Skip the header line

                var parts = line.Split(separateChar);
                if (parts.Length != 2) continue; // Skip lines with wrong format

                int time = int.Parse(parts[0]);
                double value = double.Parse(parts[1]);

                series.Points.AddXY(time, value);
            }

            var chartArea = new ChartArea("ChartArea1");
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Format = "0";
            chartArea.AxisX.Title = "Time";

            chartArea.AxisX.Maximum = Math.Ceiling(chartArea.AxisX.Maximum / scaleStep) * scaleStep;
            chartArea.AxisX.Interval = Math.Ceiling(chartArea.AxisX.Interval / scaleStep) * scaleStep;

            double axisValue = 0;
            if (double.TryParse(xMin, out axisValue)) chartArea.AxisX.Minimum = axisValue;
            if (double.TryParse(xMax, out axisValue)) chartArea.AxisX.Maximum = axisValue;
            if (double.TryParse(xInterval, out axisValue)) chartArea.AxisX.Interval = axisValue;
            if (double.TryParse(yMin, out axisValue)) chartArea.AxisY.Minimum = axisValue;
            if (double.TryParse(yMax, out axisValue)) chartArea.AxisY.Maximum = axisValue;
            if (double.TryParse(yInterval, out axisValue)) chartArea.AxisY.Interval = axisValue;

            chartArea.AxisY.Title = "Value";

            // Set the maximum view range to 10 points and adjust the scroll bar accordingly
            chartArea.AxisX.ScaleView.Size = series.Points.Count;
            if(ScaleTrackBar.Minimum != 1) ScaleTrackBar.Minimum = 1;
            if (ScaleTrackBar.Maximum != series.Points.Count)
            {
                ScaleTrackBar.Maximum = series.Points.Count;
                ScaleTrackBar.Value = ScaleTrackBar.Maximum;
            }

        }


    }
}
