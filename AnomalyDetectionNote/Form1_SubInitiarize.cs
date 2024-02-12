using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.TimeSeries;

using TrackBarWithValueInGroupBox;
using TextBoxValueListInGroupBox;

namespace AnomalyDetectionNote
{
    public partial class Form1
    {
        TrackBarWithValue trackBarLabel_WindowSize;
        TrackBarWithValue trackBarLabel_Threshold;
        TrackBarWithValue trackBarLabel_AverageSize;
        TrackBarWithValue trackBarLabel_JudgementWindowSize;
        TrackBarWithValue trackBarLabel_BatchSize;
        TrackBarWithValue trackBarLabel_Sensitivity;

        TrackBarWithValue trackBarLabel_PreviewParameter_TrainChartScale;
        TrackBarWithValue trackBarLabel_PreviewParameter_PredictChartScale;
        TrackBarWithValue trackBarLabel_PreviewParameter_ScanFiles_PredictChartScale;

        TextBoxValueList textBoxValueList_WindowSize;
        TextBoxValueList textBoxValueList_Threshold;
        TextBoxValueList textBoxValueList_AverageSize;
        TextBoxValueList textBoxValueList_JudgementWindowSize;
        TextBoxValueList textBoxValueList_BatchSize;
        TextBoxValueList textBoxValueList_Sensitivity;

        private void textBoxValue_Initialize()
        {
            textBoxValueList_WindowSize = new TextBoxValueList(groupBox_ScanFiles_WindowSize);
            textBoxValueList_Threshold = new TextBoxValueList(groupBox_ScanFiles_Threshold);
            textBoxValueList_AverageSize = new TextBoxValueList(groupBox_ScanFiles_AverageSize);
            textBoxValueList_JudgementWindowSize = new TextBoxValueList(groupBox_ScanFiles_JudgementWindowSize);
            textBoxValueList_BatchSize = new TextBoxValueList(groupBox_ScanFiles_BatchSize);
            textBoxValueList_Sensitivity = new TextBoxValueList(groupBox_ScanFiles_Sensitivity);

        }

        private void groupBoxLocation_Initialize()
        {
            int topStart = 20;
            int topInterval = 95;
            int i = 0;
            groupBox_Threshold.Top = topStart + topInterval * i; i++;
            groupBox_WindowSize.Top = topStart + topInterval * i; i++;
            groupBox_JudgementWindowSize.Top = topStart + topInterval * i; i++;
            groupBox_AverageSize.Top = topStart + topInterval * i; i++;

            groupBox_BatchSize.Location = groupBox_WindowSize.Location;
            groupBox_Sensitivity.Location = groupBox_JudgementWindowSize.Location;


            topInterval = 95;
            topInterval = 60;
            i = 0;
            groupBox_ScanFiles_Threshold.Top = topStart + topInterval * i; i++;
            groupBox_ScanFiles_WindowSize.Top = topStart + topInterval * i; i++;
            groupBox_ScanFiles_JudgementWindowSize.Top = topStart + topInterval * i; i++;
            groupBox_ScanFiles_AverageSize.Top = topStart + topInterval * i; i++;

            groupBox_ScanFiles_BatchSize.Location = groupBox_ScanFiles_WindowSize.Location;
            groupBox_ScanFiles_Sensitivity.Location = groupBox_ScanFiles_JudgementWindowSize.Location;

        }

        private void trackBarLabel_Initiallize()
        {

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

            trackBarLabel_PreviewParameter_ScanFiles_PredictChartScale = new TrackBarWithValue(groupBox_ScanFiles_PredictChartScale);
            trackBarLabel_PreviewParameter_ScanFiles_PredictChartScale.trackBar.Scroll += new System.EventHandler(ScanFilesChartScaleUpdate);
            trackBarLabel_PreviewParameter_ScanFiles_PredictChartScale.trackBar.ValueChanged += new System.EventHandler(ScanFilesChartScaleUpdate);

        }




    }
}
