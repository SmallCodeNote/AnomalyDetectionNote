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


        private void TrainChartUpdate(object sender = null, EventArgs e = null)
        {
            double PreviewParameter_TrainChartAreaAxisX_Size = double.NaN;
            double PreviewParameter_TrainChartAreaAxisX_Position = double.NaN;

            if (chart_PreviewParameter_Train.ChartAreas.Count > 0)
            {
                PreviewParameter_TrainChartAreaAxisX_Size = chart_PreviewParameter_Train.ChartAreas[0].AxisX.ScaleView.Size;
                PreviewParameter_TrainChartAreaAxisX_Position = chart_PreviewParameter_Train.ChartAreas[0].AxisX.ScaleView.Position;
            }

            string xMin = textBox_PreviewParameter_TrainChart_xMin.Text;
            string yMin = textBox_PreviewParameter_TrainChart_yMin.Text;
            string yMax = textBox_PreviewParameter_TrainChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_TrainChart_yInterval.Text;

            string filename = PreviewParameter_TrainFileArray[PreviewParameter_TrainFileArrayIndex];

            UpdateChart(chart_PreviewParameter_Train, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_TrainChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);

            if (!double.IsNaN(PreviewParameter_TrainChartAreaAxisX_Size))
            {
                chart_PreviewParameter_Train.ChartAreas[0].AxisX.ScaleView.Size = PreviewParameter_TrainChartAreaAxisX_Size;
            };

            if (!double.IsNaN(PreviewParameter_TrainChartAreaAxisX_Position))
            {
                chart_PreviewParameter_Train.ChartAreas[0].AxisX.ScaleView.Position = PreviewParameter_TrainChartAreaAxisX_Position;
            };

        }


        private void PredictChartUpdate(object sender = null, EventArgs e = null)
        {
            //ChartDrawingCondition
            double PreviewParameter_PredictChartAreaAxisX_Size = double.NaN;
            double PreviewParameter_PredictChartAreaAxisX_Position = double.NaN;

            if (chart_PreviewParameter_Predict.ChartAreas.Count > 0)
            {
                PreviewParameter_PredictChartAreaAxisX_Size = chart_PreviewParameter_Predict.ChartAreas[0].AxisX.ScaleView.Size;
                PreviewParameter_PredictChartAreaAxisX_Position = chart_PreviewParameter_Predict.ChartAreas[0].AxisX.ScaleView.Position;
            }

            string xMin = textBox_PreviewParameter_PredictChart_xMin.Text;
            string yMin = textBox_PreviewParameter_PredictChart_yMin.Text;
            string yMax = textBox_PreviewParameter_PredictChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_PredictChart_yInterval.Text;


            //SR-CNN Parameter
            int windowSize = (int)trackBarLabel_WindowSize.Value;
            int judgementWindowSize = (int)trackBarLabel_JudgementWindowSize.Value;
            int averageSize = (int)trackBarLabel_AverageSize.Value;
            double thresholdParam = trackBarLabel_Threshold.Value;

            int batchSize = (int)(trackBarLabel_BatchSize.Value);
            double sensitivity = trackBarLabel_Sensitivity.Value;


            //Update TrackBarLabel_JudgementWindowSize
            if (FormParamLoaded && judgementWindowSize > windowSize)
            {
                judgementWindowSize = windowSize;
                trackBarLabel_JudgementWindowSize.Value = judgementWindowSize;
            }
            if (FormParamLoaded)
            {
                trackBarLabel_JudgementWindowSize.Maximum = windowSize;
            }


            string filename = PreviewParameter_PredictFileArray[PreviewParameter_PredictFileArrayIndex];

            UpdateChart(chart_PreviewParameter_Predict, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_PredictChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);


            //Predict by SR-CNN
            if (radioButton_PreviewParameter_DetectionMode_Standard.Checked)
            {
                TrainAndPredictGraphDraw(chart_PreviewParameter_Predict, PreviewParameter_TrainFileArray, filename,
                    windowSize: windowSize, judgementWindowSize: judgementWindowSize, thresholdParam: thresholdParam, averagingWindowSize: averageSize);
            }
            else if (radioButton_PreviewParameter_DetectionMode_Entire.Checked)
            {
                PredictEntireGraphDraw(chart_PreviewParameter_Predict, filename,
                    threshold: thresholdParam, batchSize: batchSize, sensitivity: sensitivity);
            }


            // ChartScaleUpdate
            if (!double.IsNaN(PreviewParameter_PredictChartAreaAxisX_Size))
            {
                chart_PreviewParameter_Predict.ChartAreas[0].AxisX.ScaleView.Size = PreviewParameter_PredictChartAreaAxisX_Size;
            };

            if (!double.IsNaN(PreviewParameter_PredictChartAreaAxisX_Position))
            {
                chart_PreviewParameter_Predict.ChartAreas[0].AxisX.ScaleView.Position = PreviewParameter_PredictChartAreaAxisX_Position;
            };
        }


        private void TrainAndPredictGraphDraw(Chart PredictChart, string[] TrainFiles, string PredictFile,
            int windowSize, int judgementWindowSize, double thresholdParam, int averagingWindowSize)
        {

            MLContext mlContext = new MLContext();
            var pipeline = mlContext.Transforms.DetectAnomalyBySrCnn(outputColumnName: "Prediction", inputColumnName: "value",
                windowSize: windowSize, judgementWindowSize: judgementWindowSize, threshold: thresholdParam, averagingWindowSize: averagingWindowSize);

            List<TimeSeriesDataFloat> predictTimeSeries = getTimeSeriesDataFloatList(File.ReadAllLines(PredictFile));
            IDataView dataViewPredict = mlContext.Data.LoadFromEnumerable(predictTimeSeries);

            foreach (var TrainFile in TrainFiles)
            {

                List<TimeSeriesDataFloat> trainTimeSeries = getTimeSeriesDataFloatList(File.ReadAllLines(TrainFile));
                IDataView dataViewTrain = mlContext.Data.LoadFromEnumerable(trainTimeSeries);

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
                        TimeSeriesDataFloat t = predictTimeSeries[dataIndex];
                        chartGraph_Point.Points.AddXY(t.time, t.value);
                        chartGraph_Point.Points.AddXY(t.time, RawScore * 10.0);
                        chartGraph_Point.Points.AddXY(t.time, Magnitude * 10.0);

                        Console.WriteLine(t.time.ToString() + "\t" + t.value.ToString());
                    }
                }
                Console.WriteLine("anomalyCount : " + anomalyCount.ToString());

            }

        }



        private void PredictEntireGraphDraw(Chart PredictChart, string PredictFile,
           double threshold = 0.3, int batchSize = 512, double sensitivity = 90.0)
        {

            // Create a new ML context, for ML.NET operations. It can be used for
            // exception tracking and logging, 
            // as well as the source of randomness.
            var mlContext = new MLContext();


            // Convert data to IDataView.
            List<TimeSeriesDataDouble> predictTimeSeries = getTimeSeriesDataDoubleList(File.ReadAllLines(PredictFile));
            IDataView dataViewPredict = mlContext.Data.LoadFromEnumerable<TimeSeriesDataDouble>(predictTimeSeries);

            if (batchSize < 12) batchSize = 12;
            // Setup the detection arguments
            string outputColumnName = nameof(TimeSeriesPrediction.Prediction);
            string inputColumnName = nameof(TimeSeriesDataDouble.value);

            // Do batch anomaly detection
            var outputDataView = mlContext.AnomalyDetection.DetectEntireAnomalyBySrCnn(dataViewPredict, outputColumnName, inputColumnName,
                threshold: threshold, batchSize: batchSize, sensitivity: sensitivity, detectMode: SrCnnDetectMode.AnomalyAndMargin);

            // Getting the data of the newly created column as an IEnumerable of
            // SrCnnAnomalyDetection.
            var predictionColumn = mlContext.Data.CreateEnumerable<SrCnnAnomalyDetection>(
                outputDataView, reuseRowObject: false);

            Console.WriteLine("Index\tData\tAnomaly\tAnomalyScore\tMag\tExpectedValue\tBoundaryUnit\tUpperBoundary\tLowerBoundary");

            Series chartGraph_Point = new Series(Path.GetFileNameWithoutExtension(PredictFile));
            chartGraph_Point.ChartType = SeriesChartType.Point;

            PredictChart.Series.Add(chartGraph_Point);

            int anomalyCount = 0;
            var predictions = predictionColumn.ToList();
            for (int dataIndex = 0; dataIndex < predictions.Count; dataIndex++)
            {
                //Console.WriteLine(predictions[dataIndex].Prediction[0].ToString() + "\t" + predictions[dataIndex].Prediction[1].ToString() + "\t" + predictions[dataIndex].Prediction[2].ToString());
                double AnomalyScore = predictions[dataIndex].Prediction[0];
                double RawScore = predictions[dataIndex].Prediction[1];
                double Magnitude = predictions[dataIndex].Prediction[2];

                if ((predictions[dataIndex]).Prediction[0] > 0.3)
                {

                    anomalyCount++;
                    TimeSeriesDataDouble t = predictTimeSeries[dataIndex];
                    chartGraph_Point.Points.AddXY(t.time, t.value);
                    chartGraph_Point.Points.AddXY(t.time, RawScore * 10.0);
                    chartGraph_Point.Points.AddXY(t.time, Magnitude * 10.0);

                    Console.WriteLine(t.time.ToString() + "\t" + t.value.ToString());
                }
            }


        }


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
