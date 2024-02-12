using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using System.IO;

using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;
using Microsoft.ML.TimeSeries;
using System.ComponentModel;

namespace AnomalyDetectionNote
{
    public partial class Form1 : Form
    {

        delegate void UpdateChartDelegate(Chart chart, string[] lines, TrackBar ScaleTrackBar, char separateChar = ',',
            string xMin = "", string xMax = "", string xInterval = "",
            string yMin = "", string yMax = "", string yInterval = "", string seriesName = "Series1", double scaleStep = 10);


        private void UpdateChart(Chart chart, string[] lines, TrackBar ScaleTrackBar, char separateChar = ',',
        string xMin = "", string xMax = "", string xInterval = "",
        string yMin = "", string yMax = "", string yInterval = "", string seriesName = "Series1", double scaleStep = 10)
        {
            if (chart.InvokeRequired)
            {

                Invoke(new UpdateChartDelegate(UpdateChart), 
                    new object[] { chart, lines, ScaleTrackBar, separateChar,
                        xMin, xMax, xInterval, yMin, yMax, yInterval, seriesName, scaleStep });
                return;
            };

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
            if (ScaleTrackBar.Minimum != 1) ScaleTrackBar.Minimum = 1;
            if (ScaleTrackBar.Maximum != series.Points.Count)
            {
                ScaleTrackBar.Maximum = series.Points.Count;
                ScaleTrackBar.Value = ScaleTrackBar.Maximum;
            }

        }

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

        private void ScanFilesChartScaleUpdate(object sender, EventArgs e)
        {
            double newSize = ((TrackBar)sender).Value;

            ChartArea chartArea = chart_ScanFiles_Predict.ChartAreas[0];

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

        private delegate void TrainAndPredictGraphDrawDelegate(Chart PredictChart, string[] TrainFiles, string PredictFile,
            int windowSize, int judgementWindowSize, double thresholdParam, int averagingWindowSize);

        private void TrainAndPredictGraphDraw(Chart PredictChart, string[] TrainFiles, string PredictFile,
            int windowSize, int judgementWindowSize, double thresholdParam, int averagingWindowSize)
        {
            if (PredictChart.InvokeRequired)
            {

                Invoke(new TrainAndPredictGraphDrawDelegate(TrainAndPredictGraphDraw),
                    new object[] {PredictChart, TrainFiles, PredictFile, windowSize, judgementWindowSize, thresholdParam, averagingWindowSize });
                return;
            };

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


        private delegate void PredictEntireGraphDrawDelegate(Chart PredictChart, string PredictFile,
           double threshold = 0.3, int batchSize = 512, double sensitivity = 90.0);

        private void PredictEntireGraphDraw(Chart PredictChart, string PredictFile,
           double threshold = 0.3, int batchSize = 512, double sensitivity = 90.0)
        {

            if (PredictChart.InvokeRequired)
            {
                Invoke(new PredictEntireGraphDrawDelegate(PredictEntireGraphDraw),
                    new object[] { PredictChart, PredictFile, threshold, batchSize, sensitivity });
                return;
            };

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
            var predictionColumn = mlContext.Data.CreateEnumerable<TimeSeriesPrediction>(
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

        private delegate void ScanFilesChartUpdateDelegate(string[] FilenameArray, BackgroundWorker worker, DoWorkEventArgs e);

        private void ScanFilesChartUpdate(string[] FilenameArray, BackgroundWorker worker, DoWorkEventArgs e)
        {


            if (chart_ScanFiles_Predict.InvokeRequired)
            {
                Invoke(new ScanFilesChartUpdateDelegate(ScanFilesChartUpdate),
                    new object[] { FilenameArray, worker,e });
                return;
            };


            //ChartDrawingCondition
            double ScanFiles_ChartAreaAxisX_Size = double.NaN;
            double ScanFiles_ChartAreaAxisX_Position = double.NaN;

            if (chart_ScanFiles_Predict.ChartAreas.Count > 0)
            {
                ScanFiles_ChartAreaAxisX_Size = chart_ScanFiles_Predict.ChartAreas[0].AxisX.ScaleView.Size;
                ScanFiles_ChartAreaAxisX_Position = chart_ScanFiles_Predict.ChartAreas[0].AxisX.ScaleView.Position;
            }

            string xMin = textBox_ScanFiles_PredictChart_xMin.Text;
            string yMin = textBox_ScanFiles_PredictChart_yMin.Text;
            string yMax = textBox_ScanFiles_PredictChart_yMax.Text;
            string yInterval = textBox_ScanFiles_PredictChart_yInterval.Text;


            //SR-CNN Parameter
            int windowSize = (int)textBoxValueList_WindowSize.Value;
            int judgementWindowSize = (int)textBoxValueList_JudgementWindowSize.Value;
            int averageSize = (int)textBoxValueList_AverageSize.Value;
            double thresholdParam = textBoxValueList_Threshold.Value;

            int batchSize = (int)(textBoxValueList_BatchSize.Value);
            double sensitivity = textBoxValueList_Sensitivity.Value;


            //Update TrackBarLabel_JudgementWindowSize
            if (judgementWindowSize > windowSize)
            {
                judgementWindowSize = windowSize;

            }



            for (int filenameIndex = 0; filenameIndex < FilenameArray.Length; filenameIndex++)
            {
                worker.ReportProgress(1, filenameIndex);
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                string filename = FilenameArray[filenameIndex];

                UpdateChart(chart_ScanFiles_Predict, File.ReadAllLines(filename),
                    trackBarLabel_PreviewParameter_ScanFiles_PredictChartScale.trackBar, 
                    xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);


                //Predict by SR-CNN
                if (radioButton_PreviewParameter_DetectionMode_Standard.Checked)
                {
                    TrainAndPredictGraphDraw(chart_ScanFiles_Predict, PreviewParameter_TrainFileArray, filename,
                        windowSize: windowSize, judgementWindowSize: judgementWindowSize, thresholdParam: thresholdParam, averagingWindowSize: averageSize);
                }
                else if (radioButton_PreviewParameter_DetectionMode_Entire.Checked)
                {
                    PredictEntireGraphDraw(chart_ScanFiles_Predict, filename,
                        threshold: thresholdParam, batchSize: batchSize, sensitivity: sensitivity);
                }


                // ChartScaleUpdate
                if (!double.IsNaN(ScanFiles_ChartAreaAxisX_Size))
                {
                    chart_ScanFiles_Predict.ChartAreas[0].AxisX.ScaleView.Size = ScanFiles_ChartAreaAxisX_Size;
                };

                if (!double.IsNaN(ScanFiles_ChartAreaAxisX_Position))
                {
                    chart_ScanFiles_Predict.ChartAreas[0].AxisX.ScaleView.Position = ScanFiles_ChartAreaAxisX_Position;
                };

                string imageSavename = Path.Combine(Path.GetDirectoryName(filename),"chart",Path.GetFileNameWithoutExtension(filename)+".png");
                if (!Directory.Exists(Path.GetDirectoryName(imageSavename))) { Directory.CreateDirectory(Path.GetDirectoryName(imageSavename)); };

                chart_ScanFiles_Predict.SaveImage(imageSavename,ChartImageFormat.Png);

            }

        }

    }
}
