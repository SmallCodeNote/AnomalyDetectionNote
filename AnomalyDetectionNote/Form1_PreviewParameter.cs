using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;
using Microsoft.ML.TimeSeries;

namespace AnomalyDetectionNote
{
    public partial class Form1 : Form
    {

        private void TrainChartScaleUpdate(object sender, EventArgs e)
        {
            double newSize = ((TrackBar)sender).Value;

            ChartArea chartArea = chart_PreviewParameter_Train.ChartAreas[0];

            double oldSize = chartArea.AxisX.ScaleView.Size;
            double oldPosition = chartArea.AxisX.ScaleView.Position;

            double newPosition = oldPosition + (oldSize - newSize) / 2;

            chartArea.AxisX.ScaleView.Size = newSize;
            chartArea.AxisX.ScaleView.Position = newPosition;

        }

        private void PredictChartScaleUpdate(object sender, EventArgs e)
        {
            double newSize = ((TrackBar)sender).Value;

            ChartArea chartArea = chart_PreviewParameter_Predict.ChartAreas[0];

            double oldSize = chartArea.AxisX.ScaleView.Size;
            double oldPosition = chartArea.AxisX.ScaleView.Position;

            double newPosition = oldPosition + (oldSize - newSize) / 2;

            chartArea.AxisX.ScaleView.Size = newSize;
            chartArea.AxisX.ScaleView.Position = newPosition;

        }

        private void PredictChartUpdate(object sender, EventArgs e)
        {
            string xMin = textBox_PreviewParameter_PredictChart_xMin.Text;
            string yMin = textBox_PreviewParameter_PredictChart_yMin.Text;
            string yMax = textBox_PreviewParameter_PredictChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_PredictChart_yInterval.Text;

            int windowSize = (int)trackBarLabel_WindowSize.Value;
            int averageSize = (int)trackBarLabel_AverageSize.Value;
            double thresholdParam = trackBarLabel_Threshold.Value;

            string filename = PreviewParameter_PredictFileArray[PreviewParameter_PredictFileArrayIndex];

            UpdateChart(chart_PreviewParameter_Predict, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_PredictChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);

            TrainAndPredictGraphDraw(chart_PreviewParameter_Predict,
               PreviewParameter_TrainFileArray, PreviewParameter_PredictFileArray[PreviewParameter_PredictFileArrayIndex],
                windowSize: windowSize, thresholdParam: thresholdParam, averagingWindowSize: averageSize);

            if (PreviewParameter_PredictFileArrayIndex > 0) { button_PreviewParameter_PredictPrev.Enabled = true; }
            if (PreviewParameter_PredictFileArrayIndex >= PreviewParameter_PredictFileArray.Length - 1)
            {
                button_PreviewParameter_PredictNext.Enabled = false;
            }

        }


        private void TrainAndPredictGraphDraw(Chart PredictChart, string[] TrainFiles, string PredictFile,
            int windowSize, double thresholdParam, int averagingWindowSize)
        {

            MLContext mlContext = new MLContext();
            var pipeline = mlContext.Transforms.DetectAnomalyBySrCnn(outputColumnName: "Prediction", inputColumnName: "value",
                windowSize: windowSize, judgementWindowSize: windowSize, threshold: thresholdParam, averagingWindowSize: averagingWindowSize);

            List<TimeSeriesData> predictTimeSeries = getTimeSeriesDataList(File.ReadAllLines(PredictFile));
            IDataView dataViewPredict = mlContext.Data.LoadFromEnumerable<TimeSeriesData>(predictTimeSeries);

            foreach (var TrainFile in TrainFiles)
            {

                List<TimeSeriesData> trainTimeSeries = getTimeSeriesDataList(File.ReadAllLines(TrainFile));
                IDataView dataViewTrain = mlContext.Data.LoadFromEnumerable<TimeSeriesData>(trainTimeSeries);

                // Train model
                var model = pipeline.Fit(dataViewTrain);

                // RunPrediction
                var transformedData = model.Transform(dataViewPredict);

                // GetResult
                var predictions = mlContext.Data.CreateEnumerable<TimeSeriesPrediction>(transformedData, reuseRowObject: false).ToList();

                Series chartGraph_Point = new Series(Path.GetFileNameWithoutExtension(TrainFile));
                chartGraph_Point.ChartType = SeriesChartType.Point;

                PredictChart.Series.Add(chartGraph_Point);
                int anomalyCount = 0;
                for (int dataIndex = 0; dataIndex < predictions.Count; dataIndex++)
                {
                    //Console.WriteLine(predictions[dataIndex].Prediction[0].ToString() + "\t" + predictions[dataIndex].Prediction[1].ToString() + "\t" + predictions[dataIndex].Prediction[2].ToString());
                    double AnomalyScore = predictions[dataIndex].Prediction[0];
                    double RawScore = predictions[dataIndex].Prediction[1];
                    double Magnitude = predictions[dataIndex].Prediction[2];

                    if ((predictions[dataIndex]).Prediction[0] > 0.3)
                    {
                        
                        anomalyCount++;
                        TimeSeriesData t = predictTimeSeries[dataIndex];
                        chartGraph_Point.Points.AddXY(t.time, t.value);
                        chartGraph_Point.Points.AddXY(t.time, RawScore * 10.0);
                        chartGraph_Point.Points.AddXY(t.time, Magnitude * 10.0);

                        Console.WriteLine(t.time.ToString() + "\t" + t.value.ToString());
                    }
                }
                Console.WriteLine("anomalyCount : " + anomalyCount.ToString());

            }

        }

        private List<TimeSeriesData> getTimeSeriesDataList(string[] lines)
        {
            var timeSeriesData = new List<TimeSeriesData>();

            foreach (var line in lines)
            {
                if (line.StartsWith("time")) continue;

                var splitLine = line.Split(',');
                timeSeriesData.Add(new TimeSeriesData
                {
                    time = int.Parse(splitLine[0]),
                    value = float.Parse(splitLine[1])
                });
            }

            return timeSeriesData;

        }


    }
}
