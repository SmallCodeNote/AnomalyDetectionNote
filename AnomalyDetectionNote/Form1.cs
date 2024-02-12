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
        TrackBarWithValue trackBarLabel_JudgementWindowSize;
        TrackBarWithValue trackBarLabel_BatchSize;
        TrackBarWithValue trackBarLabel_Sensitivity;


        TrackBarWithValue trackBarLabel_PreviewParameter_TrainChartScale;
        TrackBarWithValue trackBarLabel_PreviewParameter_PredictChartScale;

        string thisExeDirPath;



        public Form1()
        {
            InitializeComponent();

            //ModeCommonTrackbars
            trackBarLabel_Threshold = new TrackBarWithValue(groupBox_Threshold);
            trackBarLabel_Threshold.valueFactor = 0.02;
            trackBarLabel_Threshold.Maximum = 1;
            trackBarLabel_Threshold.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_Threshold.trackBar.ValueChanged += new System.EventHandler(PredictChartUpdate);


            //NormalModeTrackbars
            trackBarLabel_WindowSize = new TrackBarWithValue(groupBox_WindowSize);
            trackBarLabel_WindowSize.Maximum = 64;
            trackBarLabel_WindowSize.Minimum = 1;
            trackBarLabel_WindowSize.TickFrequency = 8;
            trackBarLabel_WindowSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_WindowSize.trackBar.ValueChanged += new System.EventHandler(PredictChartUpdate);

            trackBarLabel_JudgementWindowSize = new TrackBarWithValue(groupBox_JudgementWindowSize);
            trackBarLabel_JudgementWindowSize.Maximum = 64;
            trackBarLabel_JudgementWindowSize.Minimum = 1;
            trackBarLabel_JudgementWindowSize.TickFrequency = 8;
            trackBarLabel_JudgementWindowSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_JudgementWindowSize.trackBar.ValueChanged += new System.EventHandler(PredictChartUpdate);

            trackBarLabel_AverageSize = new TrackBarWithValue(groupBox_AverageSize);
            trackBarLabel_AverageSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_AverageSize.trackBar.ValueChanged += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_AverageSize.Minimum = 1;


            //EntireModeTrackbars
            groupBox_BatchSize.Location = groupBox_WindowSize.Location;
            groupBox_Sensitivity.Location = groupBox_JudgementWindowSize.Location;

            trackBarLabel_BatchSize = new TrackBarWithValue(groupBox_BatchSize);
            trackBarLabel_BatchSize.Maximum = 1024;
            trackBarLabel_BatchSize.Minimum = 12;
            trackBarLabel_BatchSize.TickFrequency = 8;
            trackBarLabel_BatchSize.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_BatchSize.trackBar.ValueChanged += new System.EventHandler(PredictChartUpdate);

            trackBarLabel_Sensitivity = new TrackBarWithValue(groupBox_Sensitivity);
            trackBarLabel_Sensitivity.Maximum = 100;
            trackBarLabel_Sensitivity.Minimum = 0;
            trackBarLabel_Sensitivity.TickFrequency = 10;
            trackBarLabel_Sensitivity.trackBar.Scroll += new System.EventHandler(PredictChartUpdate);
            trackBarLabel_Sensitivity.trackBar.ValueChanged += new System.EventHandler(PredictChartUpdate);




            //ChartScaleTrackbars
            trackBarLabel_PreviewParameter_TrainChartScale = new TrackBarWithValue(groupBox_PreviewParameter_TrainChartScale);
            trackBarLabel_PreviewParameter_TrainChartScale.trackBar.Scroll += new System.EventHandler(TrainChartScaleUpdate);
            trackBarLabel_PreviewParameter_TrainChartScale.trackBar.ValueChanged += new System.EventHandler(TrainChartScaleUpdate);


            trackBarLabel_PreviewParameter_PredictChartScale = new TrackBarWithValue(groupBox_PreviewParameter_PredictChartScale);
            trackBarLabel_PreviewParameter_PredictChartScale.trackBar.Scroll += new System.EventHandler(PredictChartScaleUpdate);
            trackBarLabel_PreviewParameter_PredictChartScale.trackBar.ValueChanged += new System.EventHandler(PredictChartScaleUpdate);



            chart_PreviewParameter_Train.Legends.Clear();

            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);


        }
        bool FormParamLoaded = false;
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

            FormParamLoaded = true;
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
            //Index Update
            if (PreviewParameter_TrainFileArrayIndex < PreviewParameter_TrainFileArray.Length - 1) PreviewParameter_TrainFileArrayIndex++;
            

            TrainChartUpdate();


            //Button Enabled Upadate
            if (PreviewParameter_TrainFileArrayIndex > 0) { button_PreviewParameter_TrainPrev.Enabled = true; }
            if (PreviewParameter_TrainFileArrayIndex >= PreviewParameter_TrainFileArray.Length - 1)
            {
                button_PreviewParameter_TrainNext.Enabled = false;
            }
        }

        private void button_PreviewParameter_TrainPrev_Click(object sender, EventArgs e)
        {
            //Index Update
            PreviewParameter_TrainFileArrayIndex--;
            

            TrainChartUpdate();


            //Button Enabled Upadate
            if (PreviewParameter_TrainFileArrayIndex <= 0) { button_PreviewParameter_TrainPrev.Enabled = false; }
            if (PreviewParameter_TrainFileArrayIndex < PreviewParameter_TrainFileArray.Length - 1) { button_PreviewParameter_TrainNext.Enabled = true; }

        }

        private void button_PreviewParameter_PredictNext_Click(object sender, EventArgs e)
        {
            //Index Update
            if (PreviewParameter_PredictFileArrayIndex < PreviewParameter_PredictFileArray.Length - 1) PreviewParameter_PredictFileArrayIndex++;
            

            PredictChartUpdate();


            //Button Enabled Upadate
            if (PreviewParameter_PredictFileArrayIndex > 0) { button_PreviewParameter_PredictPrev.Enabled = true; }
            if (PreviewParameter_PredictFileArrayIndex >= PreviewParameter_PredictFileArray.Length - 1)
            {
                button_PreviewParameter_PredictNext.Enabled = false;
            }

        }

        private void button_PreviewParameter_PredictPrev_Click(object sender, EventArgs e)
        {
            //Index Update
            if (PreviewParameter_PredictFileArrayIndex > 0) PreviewParameter_PredictFileArrayIndex--;
           

            PredictChartUpdate();


            //Button Enabled Upadate
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

                //Button Enabled Upadate
                if (PreviewParameter_TrainFileArray.Length > 1 && PreviewParameter_TrainFileArrayIndex > 0) button_PreviewParameter_TrainPrev.Enabled = true;
                if (PreviewParameter_TrainFileArray.Length > 0 && PreviewParameter_TrainFileArrayIndex < PreviewParameter_TrainFileArray.Length - 1) button_PreviewParameter_TrainNext.Enabled = true;

                if (PreviewParameter_TrainFileArray.Length < 1) return;
                if (PreviewParameter_TrainFileArray.Length == 1 && PreviewParameter_TrainFileArray[0] == "") return;

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


                //Button Enable Upadate
                if (PreviewParameter_PredictFileArray.Length > 1 && PreviewParameter_PredictFileArrayIndex > 0) button_PreviewParameter_PredictPrev.Enabled = true;
                if (PreviewParameter_PredictFileArray.Length > 0 && PreviewParameter_PredictFileArrayIndex < PreviewParameter_PredictFileArray.Length - 1) button_PreviewParameter_PredictNext.Enabled = true;

                if (PreviewParameter_PredictFileArray.Length < 1) return;
                if (PreviewParameter_PredictFileArray.Length == 1 && PreviewParameter_PredictFileArray[0] == "") return;


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

        private void radioButton_PreviewParameter_DetectionMode_Standard_CheckedChanged(object sender, EventArgs e)
        {
            bool Visible = ((RadioButton)sender).Checked;


            groupBox_BatchSize.Visible = !Visible;
            groupBox_Sensitivity.Visible = !Visible;

            groupBox_AverageSize.Visible = Visible;
            groupBox_JudgementWindowSize.Visible = Visible;
            groupBox_WindowSize.Visible = Visible;


            PredictChartUpdate();
        }

        private void radioButton_PreviewParameter_DetectionMode_Entire_CheckedChanged(object sender, EventArgs e)
        {
            bool Visible = ((RadioButton)sender).Checked;

            groupBox_BatchSize.Visible = Visible;
            groupBox_Sensitivity.Visible = Visible;

            groupBox_AverageSize.Visible = !Visible;
            groupBox_JudgementWindowSize.Visible = !Visible;
            groupBox_WindowSize.Visible = !Visible;


            PredictChartUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Example();
        }
    }
}
