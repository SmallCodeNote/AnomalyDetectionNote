using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

using WinFormStringCnvClass;
using TrackBarWithValueInGroupBox;

namespace AnomalyDetectionNote
{
    public partial class Form1 : Form
    {
        TrackBarWithValue trackBarLabel_WindowSize;
        TrackBarWithValue trackBarLabel_Threshold;
        TrackBarWithValue trackBarLabel_AverageSize;
        TrackBarWithValue trackBarLabel_PreviewParameter_TrainChartScale;
        TrackBarWithValue trackBarLabel_PreviewParameter_PredictChartScale;

        string thisExeDirPath;

        public Form1()
        {
            InitializeComponent();

            trackBarLabel_WindowSize = new TrackBarWithValue(groupBox_WindowSize);
            trackBarLabel_WindowSize.Maximum = 64;
            trackBarLabel_WindowSize.Minimum = 1;
            trackBarLabel_WindowSize.TickFrequency = 8;
            trackBarLabel_WindowSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_WindowSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);


            trackBarLabel_Threshold = new TrackBarWithValue(groupBox_Threshold);
            trackBarLabel_Threshold.valueFactor = 0.1;
            trackBarLabel_Threshold.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_Threshold.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);


            trackBarLabel_AverageSize = new TrackBarWithValue(groupBox_AverageSize);
            trackBarLabel_AverageSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_AverageSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_AverageSize.Minimum = 1;


            trackBarLabel_PreviewParameter_TrainChartScale = new TrackBarWithValue(groupBox_PreviewParameter_TrainChartScale);
            trackBarLabel_PreviewParameter_TrainChartScale.trackBar.Scroll += new System.EventHandler(TrainChartScaleUpdate);
            trackBarLabel_PreviewParameter_TrainChartScale.trackBar.ValueChanged += new System.EventHandler(TrainChartScaleUpdate);


            trackBarLabel_PreviewParameter_PredictChartScale = new TrackBarWithValue(groupBox_PreviewParameter_PredictChartScale);
            trackBarLabel_PreviewParameter_PredictChartScale.trackBar.Scroll += new System.EventHandler(PredictChartScaleUpdate);
            trackBarLabel_PreviewParameter_PredictChartScale.trackBar.ValueChanged += new System.EventHandler(PredictChartScaleUpdate);



            chart_PreviewParameter_Train.Legends.Clear();

            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }

        }
        #region Preview
        private void button_PreviewParameter_TrainNext_Click(object sender, EventArgs e)
        {
            string xMin = textBox_PreviewParameter_TrainChart_xMin.Text;
            string yMin = textBox_PreviewParameter_TrainChart_yMin.Text;
            string yMax = textBox_PreviewParameter_TrainChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_TrainChart_yInterval.Text;

            if (PreviewParameter_TrainFileArrayIndex < PreviewParameter_TrainFileArray.Length - 1) PreviewParameter_TrainFileArrayIndex++;
            string filename = PreviewParameter_TrainFileArray[PreviewParameter_TrainFileArrayIndex];

            UpdateChart(chart_PreviewParameter_Train, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_TrainChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);


            if (PreviewParameter_TrainFileArrayIndex > 0) { button_PreviewParameter_TrainPrev.Enabled = true; }
            if (PreviewParameter_TrainFileArrayIndex >= PreviewParameter_TrainFileArray.Length - 1)
            {
                button_PreviewParameter_TrainNext.Enabled = false;
            }
        }

        private void button_PreviewParameter_TrainPrev_Click(object sender, EventArgs e)
        {
            string xMin = textBox_PreviewParameter_TrainChart_xMin.Text;
            string yMin = textBox_PreviewParameter_TrainChart_yMin.Text;
            string yMax = textBox_PreviewParameter_TrainChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_TrainChart_yInterval.Text;

            PreviewParameter_TrainFileArrayIndex--;
            string filename = PreviewParameter_TrainFileArray[PreviewParameter_TrainFileArrayIndex];

            UpdateChart(chart_PreviewParameter_Train, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_TrainChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);

            if (PreviewParameter_TrainFileArrayIndex <= 0) { button_PreviewParameter_TrainPrev.Enabled = false; }
            if (PreviewParameter_TrainFileArrayIndex < PreviewParameter_TrainFileArray.Length - 1) { button_PreviewParameter_TrainNext.Enabled = true; }

        }

        private void button_PreviewParameter_PredictNext_Click(object sender, EventArgs e)
        {
            string xMin = textBox_PreviewParameter_PredictChart_xMin.Text;
            string yMin = textBox_PreviewParameter_PredictChart_yMin.Text;
            string yMax = textBox_PreviewParameter_PredictChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_PredictChart_yInterval.Text;

            int windowSize = (int)trackBarLabel_WindowSize.Value;
            int averageSize = (int)trackBarLabel_AverageSize.Value;
            double thresholdParam = trackBarLabel_Threshold.Value;


            if (PreviewParameter_PredictFileArrayIndex < PreviewParameter_PredictFileArray.Length - 1) PreviewParameter_PredictFileArrayIndex++;
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

        private void button_PreviewParameter_PredictPrev_Click(object sender, EventArgs e)
        {
            string xMin = textBox_PreviewParameter_PredictChart_xMin.Text;
            string yMin = textBox_PreviewParameter_PredictChart_yMin.Text;
            string yMax = textBox_PreviewParameter_PredictChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_PredictChart_yInterval.Text;

            int windowSize = (int)trackBarLabel_WindowSize.Value;
            int averageSize = (int)trackBarLabel_AverageSize.Value;
            double thresholdParam = trackBarLabel_Threshold.Value;

            PreviewParameter_PredictFileArrayIndex--;
            string filename = PreviewParameter_PredictFileArray[PreviewParameter_PredictFileArrayIndex];

            UpdateChart(chart_PreviewParameter_Predict, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_PredictChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);


            TrainAndPredictGraphDraw(chart_PreviewParameter_Predict,
                 PreviewParameter_TrainFileArray, PreviewParameter_PredictFileArray[PreviewParameter_PredictFileArrayIndex],
                windowSize: windowSize, thresholdParam: thresholdParam, averagingWindowSize: averageSize);


            if (PreviewParameter_PredictFileArrayIndex <= 0) { button_PreviewParameter_PredictPrev.Enabled = false; }
            if (PreviewParameter_PredictFileArrayIndex < PreviewParameter_PredictFileArray.Length - 1) { button_PreviewParameter_PredictNext.Enabled = true; }

        }

        int PreviewParameter_TrainFileArrayIndex = 0;
        string[] PreviewParameter_TrainFileArray = { "" };

        private void textBox_PreviewParameter_TrainPath_TextChanged(object sender, EventArgs e)
        {
            string pathString = ((TextBox)sender).Text;
            string searchPattern = textBox_PreviewParameter_TrainFilename_SearchPattern.Text;

            button_PreviewParameter_TrainPrev.Enabled = false;
            button_PreviewParameter_TrainNext.Enabled = false;


            if (File.Exists(pathString))
            {
                PreviewParameter_TrainFileArray = new string[] { pathString };
            }
            else if (Directory.Exists(pathString))
            {
                PreviewParameter_TrainFileArray = Directory.GetFiles(pathString, searchPattern, SearchOption.AllDirectories);

                if (PreviewParameter_TrainFileArray.Length < 1) return;
                if (PreviewParameter_TrainFileArray.Length == 1 && PreviewParameter_TrainFileArray[0] == "") return;

                if (PreviewParameter_TrainFileArray.Length > 1) button_PreviewParameter_TrainPrev.Enabled = true;
                if (PreviewParameter_TrainFileArray.Length > 0) button_PreviewParameter_TrainNext.Enabled = true;

            }

            if (PreviewParameter_TrainFileArrayIndex >= PreviewParameter_TrainFileArray.Length) PreviewParameter_TrainFileArrayIndex = PreviewParameter_TrainFileArray.Length - 1;


            string xMin = textBox_PreviewParameter_TrainChart_xMin.Text;
            string yMin = textBox_PreviewParameter_TrainChart_yMin.Text;
            string yMax = textBox_PreviewParameter_TrainChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_TrainChart_yInterval.Text;

            string filename = PreviewParameter_TrainFileArray[PreviewParameter_TrainFileArrayIndex];
            UpdateChart(chart_PreviewParameter_Train, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_TrainChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);

            label_chart_PreviewParameter_Train.Text = Path.GetFileNameWithoutExtension(filename);

        }

        int PreviewParameter_PredictFileArrayIndex = 0;
        string[] PreviewParameter_PredictFileArray = { "" };
        private void textBox_PreviewParameter_PredictPath_TextChanged(object sender, EventArgs e)
        {
            string pathString = ((TextBox)sender).Text;
            string searchPattern = textBox_PreviewParameter_PredictFilename_SearchPattern.Text;

            button_PreviewParameter_PredictPrev.Enabled = false;
            button_PreviewParameter_PredictNext.Enabled = false;


            if (File.Exists(pathString))
            {
                PreviewParameter_PredictFileArray = new string[] { pathString };
            }
            else if (Directory.Exists(pathString))
            {
                PreviewParameter_PredictFileArray = Directory.GetFiles(pathString, searchPattern, SearchOption.AllDirectories);

                if (PreviewParameter_PredictFileArray.Length < 1) return;
                if (PreviewParameter_PredictFileArray.Length == 1 && PreviewParameter_PredictFileArray[0] == "") return;

                if (PreviewParameter_PredictFileArray.Length > 1) button_PreviewParameter_PredictPrev.Enabled = true;
                if (PreviewParameter_PredictFileArray.Length > 0) button_PreviewParameter_PredictNext.Enabled = true;

            }

            if (PreviewParameter_PredictFileArrayIndex >= PreviewParameter_PredictFileArray.Length) PreviewParameter_PredictFileArrayIndex = PreviewParameter_PredictFileArray.Length - 1;

            string xMin = textBox_PreviewParameter_PredictChart_xMin.Text;
            string yMin = textBox_PreviewParameter_PredictChart_yMin.Text;
            string yMax = textBox_PreviewParameter_PredictChart_yMax.Text;
            string yInterval = textBox_PreviewParameter_PredictChart_yInterval.Text;

            string filename = PreviewParameter_PredictFileArray[PreviewParameter_PredictFileArrayIndex];
            UpdateChart(chart_PreviewParameter_Predict, File.ReadAllLines(filename), trackBarLabel_PreviewParameter_PredictChartScale.trackBar, xMin: xMin, yMin: yMin, yMax: yMax, yInterval: yInterval);

            label_chart_PreviewParameter_Predict.Text = Path.GetFileNameWithoutExtension(filename);

        }

        private void button_PreviewParameter_TrainPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "DataFile|" + textBox_PreviewParameter_TrainFilename_SearchPattern.Text;
            ofd.Title = "TrainFile";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            textBox_PreviewParameter_TrainPath.Text = ofd.FileName;
        }

        private void button_PreviewParameter_PredictPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "DataFile|" + textBox_PreviewParameter_PredictFilename_SearchPattern.Text;
            ofd.Title = "PredictFile";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            textBox_PreviewParameter_PredictPath.Text = ofd.FileName;
        }

        #endregion

    }
}
