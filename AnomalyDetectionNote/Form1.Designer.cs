﻿namespace AnomalyDetectionNote
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_PreviewParameter = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_PreviewParameter_DetectionMode = new System.Windows.Forms.GroupBox();
            this.radioButton_PreviewParameter_DetectionMode_Entire = new System.Windows.Forms.RadioButton();
            this.radioButton_PreviewParameter_DetectionMode_Standard = new System.Windows.Forms.RadioButton();
            this.groupBox_PreviewParameters = new System.Windows.Forms.GroupBox();
            this.groupBox_Sensitivity = new System.Windows.Forms.GroupBox();
            this.groupBox_BatchSize = new System.Windows.Forms.GroupBox();
            this.groupBox_JudgementWindowSize = new System.Windows.Forms.GroupBox();
            this.groupBox_WindowSize = new System.Windows.Forms.GroupBox();
            this.groupBox_Threshold = new System.Windows.Forms.GroupBox();
            this.groupBox_AverageSize = new System.Windows.Forms.GroupBox();
            this.button_PreviewParameter_PredictPrev = new System.Windows.Forms.Button();
            this.button_PreviewParameter_TrainPrev = new System.Windows.Forms.Button();
            this.button_PreviewParameter_PredictNext = new System.Windows.Forms.Button();
            this.button_PreviewParameter_TrainNext = new System.Windows.Forms.Button();
            this.textBox_PreviewParameter_PredictFilename_SearchPattern = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_TrainFilename_SearchPattern = new System.Windows.Forms.TextBox();
            this.label_chart_PreviewParameter_Predict = new System.Windows.Forms.Label();
            this.label_chart_PreviewParameter_Train = new System.Windows.Forms.Label();
            this.groupBox_PreviewParameter_PredictChartScale = new System.Windows.Forms.GroupBox();
            this.groupBox_PreviewParameter_TrainChartScale = new System.Windows.Forms.GroupBox();
            this.textBox_PreviewParameter_PredictChart_xMin = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_TrainChart_xMin = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_PredictChart_yInterval = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_TrainChart_yInterval = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_PredictChart_yMin = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_TrainChart_yMin = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_PredictChart_yMax = new System.Windows.Forms.TextBox();
            this.textBox_PreviewParameter_TrainChart_yMax = new System.Windows.Forms.TextBox();
            this.chart_PreviewParameter_Predict = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_PreviewParameter_Train = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_PreviewParameter_PredictPath = new System.Windows.Forms.Button();
            this.button_PreviewParameter_TrainPath = new System.Windows.Forms.Button();
            this.textBox_PreviewParameter_PredictPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PreviewParameter_TrainPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_PreviewParameter_Chart_Min = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_PreviewParameter_Chart_Max = new System.Windows.Forms.Label();
            this.label_PreviewParameter_TargetFilename = new System.Windows.Forms.Label();
            this.tabPage_ScanFiles = new System.Windows.Forms.TabPage();
            this.label_ScanFiles_Index = new System.Windows.Forms.Label();
            this.progressBar_ScanFiles = new System.Windows.Forms.ProgressBar();
            this.groupBox_ScanFiles_Parameters = new System.Windows.Forms.GroupBox();
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add = new System.Windows.Forms.CheckBox();
            this.groupBox_ScanFiles_Sensitivity = new System.Windows.Forms.GroupBox();
            this.groupBox_ScanFiles_BatchSize = new System.Windows.Forms.GroupBox();
            this.button_ScanFiles_GetSrCnnParamFromPreview = new System.Windows.Forms.Button();
            this.groupBox_ScanFiles_JudgementWindowSize = new System.Windows.Forms.GroupBox();
            this.groupBox_ScanFiles_WindowSize = new System.Windows.Forms.GroupBox();
            this.groupBox_ScanFiles_Threshold = new System.Windows.Forms.GroupBox();
            this.groupBox_ScanFiles_AverageSize = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_ScanFiles_DetectionMode_Entire = new System.Windows.Forms.RadioButton();
            this.radioButton_ScanFiles_DetectionMode_Standard = new System.Windows.Forms.RadioButton();
            this.button_ScanFiles_Run = new System.Windows.Forms.Button();
            this.button_ScanFiles_PredictPrev = new System.Windows.Forms.Button();
            this.button_ScanFiles_PredictNext = new System.Windows.Forms.Button();
            this.label_chart_ScanFiles_Predict = new System.Windows.Forms.Label();
            this.groupBox_ScanFiles_PredictChartScale = new System.Windows.Forms.GroupBox();
            this.textBox_ScanFiles_PredictChart_xMin = new System.Windows.Forms.TextBox();
            this.textBox_ScanFiles_PredictChart_yInterval = new System.Windows.Forms.TextBox();
            this.textBox_ScanFiles_PredictChart_yMin = new System.Windows.Forms.TextBox();
            this.textBox_ScanFiles_PredictChart_yMax = new System.Windows.Forms.TextBox();
            this.chart_ScanFiles_Predict = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ScanFiles_PredictFilename_SearchPattern = new System.Windows.Forms.TextBox();
            this.button_ScanFiles_PredictPath = new System.Windows.Forms.Button();
            this.textBox_ScanFiles_PredictPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage_CreateDammyData = new System.Windows.Forms.TabPage();
            this.backgroundWorker_ScanFiles_Run = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage_PreviewParameter.SuspendLayout();
            this.groupBox_PreviewParameter_DetectionMode.SuspendLayout();
            this.groupBox_PreviewParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Predict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Train)).BeginInit();
            this.tabPage_ScanFiles.SuspendLayout();
            this.groupBox_ScanFiles_Parameters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ScanFiles_Predict)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 840);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_PreviewParameter);
            this.tabControl1.Controls.Add(this.tabPage_ScanFiles);
            this.tabControl1.Controls.Add(this.tabPage_CreateDammyData);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 788);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_PreviewParameter
            // 
            this.tabPage_PreviewParameter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage_PreviewParameter.Controls.Add(this.button1);
            this.tabPage_PreviewParameter.Controls.Add(this.groupBox_PreviewParameter_DetectionMode);
            this.tabPage_PreviewParameter.Controls.Add(this.groupBox_PreviewParameters);
            this.tabPage_PreviewParameter.Controls.Add(this.button_PreviewParameter_PredictPrev);
            this.tabPage_PreviewParameter.Controls.Add(this.button_PreviewParameter_TrainPrev);
            this.tabPage_PreviewParameter.Controls.Add(this.button_PreviewParameter_PredictNext);
            this.tabPage_PreviewParameter.Controls.Add(this.button_PreviewParameter_TrainNext);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_PredictFilename_SearchPattern);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_TrainFilename_SearchPattern);
            this.tabPage_PreviewParameter.Controls.Add(this.label_chart_PreviewParameter_Predict);
            this.tabPage_PreviewParameter.Controls.Add(this.label_chart_PreviewParameter_Train);
            this.tabPage_PreviewParameter.Controls.Add(this.groupBox_PreviewParameter_PredictChartScale);
            this.tabPage_PreviewParameter.Controls.Add(this.groupBox_PreviewParameter_TrainChartScale);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_PredictChart_xMin);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_TrainChart_xMin);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_PredictChart_yInterval);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_TrainChart_yInterval);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_PredictChart_yMin);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_TrainChart_yMin);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_PredictChart_yMax);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_TrainChart_yMax);
            this.tabPage_PreviewParameter.Controls.Add(this.chart_PreviewParameter_Predict);
            this.tabPage_PreviewParameter.Controls.Add(this.chart_PreviewParameter_Train);
            this.tabPage_PreviewParameter.Controls.Add(this.button_PreviewParameter_PredictPath);
            this.tabPage_PreviewParameter.Controls.Add(this.button_PreviewParameter_TrainPath);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_PredictPath);
            this.tabPage_PreviewParameter.Controls.Add(this.label5);
            this.tabPage_PreviewParameter.Controls.Add(this.textBox_PreviewParameter_TrainPath);
            this.tabPage_PreviewParameter.Controls.Add(this.label4);
            this.tabPage_PreviewParameter.Controls.Add(this.label1);
            this.tabPage_PreviewParameter.Controls.Add(this.label_PreviewParameter_Chart_Min);
            this.tabPage_PreviewParameter.Controls.Add(this.label3);
            this.tabPage_PreviewParameter.Controls.Add(this.label2);
            this.tabPage_PreviewParameter.Controls.Add(this.label_PreviewParameter_Chart_Max);
            this.tabPage_PreviewParameter.Controls.Add(this.label_PreviewParameter_TargetFilename);
            this.tabPage_PreviewParameter.Location = new System.Drawing.Point(4, 25);
            this.tabPage_PreviewParameter.Name = "tabPage_PreviewParameter";
            this.tabPage_PreviewParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PreviewParameter.Size = new System.Drawing.Size(1162, 759);
            this.tabPage_PreviewParameter.TabIndex = 1;
            this.tabPage_PreviewParameter.Text = "PreviewParameter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 26);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_PreviewParameter_DetectionMode
            // 
            this.groupBox_PreviewParameter_DetectionMode.Controls.Add(this.radioButton_PreviewParameter_DetectionMode_Entire);
            this.groupBox_PreviewParameter_DetectionMode.Controls.Add(this.radioButton_PreviewParameter_DetectionMode_Standard);
            this.groupBox_PreviewParameter_DetectionMode.Location = new System.Drawing.Point(10, 700);
            this.groupBox_PreviewParameter_DetectionMode.Name = "groupBox_PreviewParameter_DetectionMode";
            this.groupBox_PreviewParameter_DetectionMode.Size = new System.Drawing.Size(332, 53);
            this.groupBox_PreviewParameter_DetectionMode.TabIndex = 32;
            this.groupBox_PreviewParameter_DetectionMode.TabStop = false;
            this.groupBox_PreviewParameter_DetectionMode.Text = "DetectionMode";
            // 
            // radioButton_PreviewParameter_DetectionMode_Entire
            // 
            this.radioButton_PreviewParameter_DetectionMode_Entire.AutoSize = true;
            this.radioButton_PreviewParameter_DetectionMode_Entire.Location = new System.Drawing.Point(162, 21);
            this.radioButton_PreviewParameter_DetectionMode_Entire.Name = "radioButton_PreviewParameter_DetectionMode_Entire";
            this.radioButton_PreviewParameter_DetectionMode_Entire.Size = new System.Drawing.Size(65, 19);
            this.radioButton_PreviewParameter_DetectionMode_Entire.TabIndex = 1;
            this.radioButton_PreviewParameter_DetectionMode_Entire.Text = "Entire";
            this.radioButton_PreviewParameter_DetectionMode_Entire.UseVisualStyleBackColor = true;
            this.radioButton_PreviewParameter_DetectionMode_Entire.CheckedChanged += new System.EventHandler(this.radioButton_PreviewParameter_DetectionMode_Entire_CheckedChanged);
            // 
            // radioButton_PreviewParameter_DetectionMode_Standard
            // 
            this.radioButton_PreviewParameter_DetectionMode_Standard.AutoSize = true;
            this.radioButton_PreviewParameter_DetectionMode_Standard.Location = new System.Drawing.Point(6, 21);
            this.radioButton_PreviewParameter_DetectionMode_Standard.Name = "radioButton_PreviewParameter_DetectionMode_Standard";
            this.radioButton_PreviewParameter_DetectionMode_Standard.Size = new System.Drawing.Size(83, 19);
            this.radioButton_PreviewParameter_DetectionMode_Standard.TabIndex = 0;
            this.radioButton_PreviewParameter_DetectionMode_Standard.Text = "Standard";
            this.radioButton_PreviewParameter_DetectionMode_Standard.UseVisualStyleBackColor = true;
            this.radioButton_PreviewParameter_DetectionMode_Standard.CheckedChanged += new System.EventHandler(this.radioButton_PreviewParameter_DetectionMode_Standard_CheckedChanged);
            // 
            // groupBox_PreviewParameters
            // 
            this.groupBox_PreviewParameters.Controls.Add(this.groupBox_Sensitivity);
            this.groupBox_PreviewParameters.Controls.Add(this.groupBox_BatchSize);
            this.groupBox_PreviewParameters.Controls.Add(this.groupBox_JudgementWindowSize);
            this.groupBox_PreviewParameters.Controls.Add(this.groupBox_WindowSize);
            this.groupBox_PreviewParameters.Controls.Add(this.groupBox_Threshold);
            this.groupBox_PreviewParameters.Controls.Add(this.groupBox_AverageSize);
            this.groupBox_PreviewParameters.Location = new System.Drawing.Point(10, 110);
            this.groupBox_PreviewParameters.Name = "groupBox_PreviewParameters";
            this.groupBox_PreviewParameters.Size = new System.Drawing.Size(330, 580);
            this.groupBox_PreviewParameters.TabIndex = 31;
            this.groupBox_PreviewParameters.TabStop = false;
            this.groupBox_PreviewParameters.Text = "SR-CNN Parameter";
            // 
            // groupBox_Sensitivity
            // 
            this.groupBox_Sensitivity.Location = new System.Drawing.Point(15, 485);
            this.groupBox_Sensitivity.Name = "groupBox_Sensitivity";
            this.groupBox_Sensitivity.Size = new System.Drawing.Size(300, 80);
            this.groupBox_Sensitivity.TabIndex = 24;
            this.groupBox_Sensitivity.TabStop = false;
            this.groupBox_Sensitivity.Text = "Sensitivity";
            // 
            // groupBox_BatchSize
            // 
            this.groupBox_BatchSize.Location = new System.Drawing.Point(15, 393);
            this.groupBox_BatchSize.Name = "groupBox_BatchSize";
            this.groupBox_BatchSize.Size = new System.Drawing.Size(300, 80);
            this.groupBox_BatchSize.TabIndex = 24;
            this.groupBox_BatchSize.TabStop = false;
            this.groupBox_BatchSize.Text = "BatchSize";
            // 
            // groupBox_JudgementWindowSize
            // 
            this.groupBox_JudgementWindowSize.Location = new System.Drawing.Point(15, 212);
            this.groupBox_JudgementWindowSize.Name = "groupBox_JudgementWindowSize";
            this.groupBox_JudgementWindowSize.Size = new System.Drawing.Size(300, 80);
            this.groupBox_JudgementWindowSize.TabIndex = 23;
            this.groupBox_JudgementWindowSize.TabStop = false;
            this.groupBox_JudgementWindowSize.Text = "JudgementWindowSize";
            // 
            // groupBox_WindowSize
            // 
            this.groupBox_WindowSize.Location = new System.Drawing.Point(15, 115);
            this.groupBox_WindowSize.Name = "groupBox_WindowSize";
            this.groupBox_WindowSize.Size = new System.Drawing.Size(300, 80);
            this.groupBox_WindowSize.TabIndex = 22;
            this.groupBox_WindowSize.TabStop = false;
            this.groupBox_WindowSize.Text = "WindowSize";
            // 
            // groupBox_Threshold
            // 
            this.groupBox_Threshold.Location = new System.Drawing.Point(15, 20);
            this.groupBox_Threshold.Name = "groupBox_Threshold";
            this.groupBox_Threshold.Size = new System.Drawing.Size(300, 80);
            this.groupBox_Threshold.TabIndex = 22;
            this.groupBox_Threshold.TabStop = false;
            this.groupBox_Threshold.Text = "Threshold";
            // 
            // groupBox_AverageSize
            // 
            this.groupBox_AverageSize.Location = new System.Drawing.Point(15, 307);
            this.groupBox_AverageSize.Name = "groupBox_AverageSize";
            this.groupBox_AverageSize.Size = new System.Drawing.Size(300, 80);
            this.groupBox_AverageSize.TabIndex = 22;
            this.groupBox_AverageSize.TabStop = false;
            this.groupBox_AverageSize.Text = "AverageSize";
            // 
            // button_PreviewParameter_PredictPrev
            // 
            this.button_PreviewParameter_PredictPrev.Enabled = false;
            this.button_PreviewParameter_PredictPrev.Location = new System.Drawing.Point(355, 514);
            this.button_PreviewParameter_PredictPrev.Name = "button_PreviewParameter_PredictPrev";
            this.button_PreviewParameter_PredictPrev.Size = new System.Drawing.Size(30, 43);
            this.button_PreviewParameter_PredictPrev.TabIndex = 30;
            this.button_PreviewParameter_PredictPrev.Text = "<";
            this.button_PreviewParameter_PredictPrev.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_PredictPrev.Click += new System.EventHandler(this.button_PreviewParameter_PredictPrev_Click);
            // 
            // button_PreviewParameter_TrainPrev
            // 
            this.button_PreviewParameter_TrainPrev.Enabled = false;
            this.button_PreviewParameter_TrainPrev.Location = new System.Drawing.Point(355, 196);
            this.button_PreviewParameter_TrainPrev.Name = "button_PreviewParameter_TrainPrev";
            this.button_PreviewParameter_TrainPrev.Size = new System.Drawing.Size(30, 43);
            this.button_PreviewParameter_TrainPrev.TabIndex = 30;
            this.button_PreviewParameter_TrainPrev.Text = "<";
            this.button_PreviewParameter_TrainPrev.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_TrainPrev.Click += new System.EventHandler(this.button_PreviewParameter_TrainPrev_Click);
            // 
            // button_PreviewParameter_PredictNext
            // 
            this.button_PreviewParameter_PredictNext.Enabled = false;
            this.button_PreviewParameter_PredictNext.Location = new System.Drawing.Point(391, 514);
            this.button_PreviewParameter_PredictNext.Name = "button_PreviewParameter_PredictNext";
            this.button_PreviewParameter_PredictNext.Size = new System.Drawing.Size(29, 43);
            this.button_PreviewParameter_PredictNext.TabIndex = 30;
            this.button_PreviewParameter_PredictNext.Text = ">";
            this.button_PreviewParameter_PredictNext.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_PredictNext.Click += new System.EventHandler(this.button_PreviewParameter_PredictNext_Click);
            // 
            // button_PreviewParameter_TrainNext
            // 
            this.button_PreviewParameter_TrainNext.Enabled = false;
            this.button_PreviewParameter_TrainNext.Location = new System.Drawing.Point(391, 196);
            this.button_PreviewParameter_TrainNext.Name = "button_PreviewParameter_TrainNext";
            this.button_PreviewParameter_TrainNext.Size = new System.Drawing.Size(29, 43);
            this.button_PreviewParameter_TrainNext.TabIndex = 30;
            this.button_PreviewParameter_TrainNext.Text = ">";
            this.button_PreviewParameter_TrainNext.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_TrainNext.Click += new System.EventHandler(this.button_PreviewParameter_TrainNext_Click);
            // 
            // textBox_PreviewParameter_PredictFilename_SearchPattern
            // 
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.Location = new System.Drawing.Point(1025, 74);
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.Name = "textBox_PreviewParameter_PredictFilename_SearchPattern";
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.Size = new System.Drawing.Size(100, 22);
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.TabIndex = 29;
            // 
            // textBox_PreviewParameter_TrainFilename_SearchPattern
            // 
            this.textBox_PreviewParameter_TrainFilename_SearchPattern.Location = new System.Drawing.Point(1025, 31);
            this.textBox_PreviewParameter_TrainFilename_SearchPattern.Name = "textBox_PreviewParameter_TrainFilename_SearchPattern";
            this.textBox_PreviewParameter_TrainFilename_SearchPattern.Size = new System.Drawing.Size(100, 22);
            this.textBox_PreviewParameter_TrainFilename_SearchPattern.TabIndex = 29;
            // 
            // label_chart_PreviewParameter_Predict
            // 
            this.label_chart_PreviewParameter_Predict.AutoSize = true;
            this.label_chart_PreviewParameter_Predict.Location = new System.Drawing.Point(419, 429);
            this.label_chart_PreviewParameter_Predict.Name = "label_chart_PreviewParameter_Predict";
            this.label_chart_PreviewParameter_Predict.Size = new System.Drawing.Size(16, 15);
            this.label_chart_PreviewParameter_Predict.TabIndex = 28;
            this.label_chart_PreviewParameter_Predict.Text = "...";
            // 
            // label_chart_PreviewParameter_Train
            // 
            this.label_chart_PreviewParameter_Train.AutoSize = true;
            this.label_chart_PreviewParameter_Train.Location = new System.Drawing.Point(419, 111);
            this.label_chart_PreviewParameter_Train.Name = "label_chart_PreviewParameter_Train";
            this.label_chart_PreviewParameter_Train.Size = new System.Drawing.Size(16, 15);
            this.label_chart_PreviewParameter_Train.TabIndex = 28;
            this.label_chart_PreviewParameter_Train.Text = "...";
            // 
            // groupBox_PreviewParameter_PredictChartScale
            // 
            this.groupBox_PreviewParameter_PredictChartScale.Location = new System.Drawing.Point(461, 664);
            this.groupBox_PreviewParameter_PredictChartScale.Name = "groupBox_PreviewParameter_PredictChartScale";
            this.groupBox_PreviewParameter_PredictChartScale.Size = new System.Drawing.Size(674, 80);
            this.groupBox_PreviewParameter_PredictChartScale.TabIndex = 22;
            this.groupBox_PreviewParameter_PredictChartScale.TabStop = false;
            this.groupBox_PreviewParameter_PredictChartScale.Text = "Scale";
            // 
            // groupBox_PreviewParameter_TrainChartScale
            // 
            this.groupBox_PreviewParameter_TrainChartScale.Location = new System.Drawing.Point(461, 346);
            this.groupBox_PreviewParameter_TrainChartScale.Name = "groupBox_PreviewParameter_TrainChartScale";
            this.groupBox_PreviewParameter_TrainChartScale.Size = new System.Drawing.Size(674, 80);
            this.groupBox_PreviewParameter_TrainChartScale.TabIndex = 22;
            this.groupBox_PreviewParameter_TrainChartScale.TabStop = false;
            this.groupBox_PreviewParameter_TrainChartScale.Text = "Scale";
            // 
            // textBox_PreviewParameter_PredictChart_xMin
            // 
            this.textBox_PreviewParameter_PredictChart_xMin.Location = new System.Drawing.Point(461, 636);
            this.textBox_PreviewParameter_PredictChart_xMin.Name = "textBox_PreviewParameter_PredictChart_xMin";
            this.textBox_PreviewParameter_PredictChart_xMin.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_PredictChart_xMin.TabIndex = 27;
            // 
            // textBox_PreviewParameter_TrainChart_xMin
            // 
            this.textBox_PreviewParameter_TrainChart_xMin.Location = new System.Drawing.Point(461, 318);
            this.textBox_PreviewParameter_TrainChart_xMin.Name = "textBox_PreviewParameter_TrainChart_xMin";
            this.textBox_PreviewParameter_TrainChart_xMin.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_TrainChart_xMin.TabIndex = 27;
            // 
            // textBox_PreviewParameter_PredictChart_yInterval
            // 
            this.textBox_PreviewParameter_PredictChart_yInterval.Location = new System.Drawing.Point(351, 636);
            this.textBox_PreviewParameter_PredictChart_yInterval.Name = "textBox_PreviewParameter_PredictChart_yInterval";
            this.textBox_PreviewParameter_PredictChart_yInterval.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_PredictChart_yInterval.TabIndex = 27;
            // 
            // textBox_PreviewParameter_TrainChart_yInterval
            // 
            this.textBox_PreviewParameter_TrainChart_yInterval.Location = new System.Drawing.Point(351, 318);
            this.textBox_PreviewParameter_TrainChart_yInterval.Name = "textBox_PreviewParameter_TrainChart_yInterval";
            this.textBox_PreviewParameter_TrainChart_yInterval.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_TrainChart_yInterval.TabIndex = 27;
            // 
            // textBox_PreviewParameter_PredictChart_yMin
            // 
            this.textBox_PreviewParameter_PredictChart_yMin.Location = new System.Drawing.Point(351, 596);
            this.textBox_PreviewParameter_PredictChart_yMin.Name = "textBox_PreviewParameter_PredictChart_yMin";
            this.textBox_PreviewParameter_PredictChart_yMin.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_PredictChart_yMin.TabIndex = 27;
            // 
            // textBox_PreviewParameter_TrainChart_yMin
            // 
            this.textBox_PreviewParameter_TrainChart_yMin.Location = new System.Drawing.Point(351, 278);
            this.textBox_PreviewParameter_TrainChart_yMin.Name = "textBox_PreviewParameter_TrainChart_yMin";
            this.textBox_PreviewParameter_TrainChart_yMin.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_TrainChart_yMin.TabIndex = 27;
            // 
            // textBox_PreviewParameter_PredictChart_yMax
            // 
            this.textBox_PreviewParameter_PredictChart_yMax.Location = new System.Drawing.Point(351, 464);
            this.textBox_PreviewParameter_PredictChart_yMax.Name = "textBox_PreviewParameter_PredictChart_yMax";
            this.textBox_PreviewParameter_PredictChart_yMax.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_PredictChart_yMax.TabIndex = 27;
            // 
            // textBox_PreviewParameter_TrainChart_yMax
            // 
            this.textBox_PreviewParameter_TrainChart_yMax.Location = new System.Drawing.Point(351, 146);
            this.textBox_PreviewParameter_TrainChart_yMax.Name = "textBox_PreviewParameter_TrainChart_yMax";
            this.textBox_PreviewParameter_TrainChart_yMax.Size = new System.Drawing.Size(80, 22);
            this.textBox_PreviewParameter_TrainChart_yMax.TabIndex = 27;
            // 
            // chart_PreviewParameter_Predict
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_PreviewParameter_Predict.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_PreviewParameter_Predict.Legends.Add(legend1);
            this.chart_PreviewParameter_Predict.Location = new System.Drawing.Point(411, 447);
            this.chart_PreviewParameter_Predict.Name = "chart_PreviewParameter_Predict";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_PreviewParameter_Predict.Series.Add(series1);
            this.chart_PreviewParameter_Predict.Size = new System.Drawing.Size(720, 200);
            this.chart_PreviewParameter_Predict.TabIndex = 26;
            this.chart_PreviewParameter_Predict.Text = "chart1";
            // 
            // chart_PreviewParameter_Train
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_PreviewParameter_Train.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_PreviewParameter_Train.Legends.Add(legend2);
            this.chart_PreviewParameter_Train.Location = new System.Drawing.Point(411, 129);
            this.chart_PreviewParameter_Train.Name = "chart_PreviewParameter_Train";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_PreviewParameter_Train.Series.Add(series2);
            this.chart_PreviewParameter_Train.Size = new System.Drawing.Size(720, 200);
            this.chart_PreviewParameter_Train.TabIndex = 26;
            this.chart_PreviewParameter_Train.Text = "chart1";
            // 
            // button_PreviewParameter_PredictPath
            // 
            this.button_PreviewParameter_PredictPath.Location = new System.Drawing.Point(27, 74);
            this.button_PreviewParameter_PredictPath.Name = "button_PreviewParameter_PredictPath";
            this.button_PreviewParameter_PredictPath.Size = new System.Drawing.Size(26, 22);
            this.button_PreviewParameter_PredictPath.TabIndex = 25;
            this.button_PreviewParameter_PredictPath.Text = "...";
            this.button_PreviewParameter_PredictPath.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_PredictPath.Click += new System.EventHandler(this.button_PreviewParameter_PredictPath_Click);
            // 
            // button_PreviewParameter_TrainPath
            // 
            this.button_PreviewParameter_TrainPath.Location = new System.Drawing.Point(27, 30);
            this.button_PreviewParameter_TrainPath.Name = "button_PreviewParameter_TrainPath";
            this.button_PreviewParameter_TrainPath.Size = new System.Drawing.Size(26, 22);
            this.button_PreviewParameter_TrainPath.TabIndex = 25;
            this.button_PreviewParameter_TrainPath.Text = "...";
            this.button_PreviewParameter_TrainPath.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_TrainPath.Click += new System.EventHandler(this.button_PreviewParameter_TrainPath_Click);
            // 
            // textBox_PreviewParameter_PredictPath
            // 
            this.textBox_PreviewParameter_PredictPath.Location = new System.Drawing.Point(59, 74);
            this.textBox_PreviewParameter_PredictPath.Name = "textBox_PreviewParameter_PredictPath";
            this.textBox_PreviewParameter_PredictPath.Size = new System.Drawing.Size(960, 22);
            this.textBox_PreviewParameter_PredictPath.TabIndex = 24;
            this.textBox_PreviewParameter_PredictPath.TextChanged += new System.EventHandler(this.textBox_PreviewParameter_PredictPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "yInterval";
            // 
            // textBox_PreviewParameter_TrainPath
            // 
            this.textBox_PreviewParameter_TrainPath.Location = new System.Drawing.Point(59, 30);
            this.textBox_PreviewParameter_TrainPath.Name = "textBox_PreviewParameter_TrainPath";
            this.textBox_PreviewParameter_TrainPath.Size = new System.Drawing.Size(960, 22);
            this.textBox_PreviewParameter_TrainPath.TabIndex = 24;
            this.textBox_PreviewParameter_TrainPath.TextChanged += new System.EventHandler(this.textBox_PreviewParameter_TrainPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "yMin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "yInterval";
            // 
            // label_PreviewParameter_Chart_Min
            // 
            this.label_PreviewParameter_Chart_Min.AutoSize = true;
            this.label_PreviewParameter_Chart_Min.Location = new System.Drawing.Point(348, 260);
            this.label_PreviewParameter_Chart_Min.Name = "label_PreviewParameter_Chart_Min";
            this.label_PreviewParameter_Chart_Min.Size = new System.Drawing.Size(36, 15);
            this.label_PreviewParameter_Chart_Min.TabIndex = 23;
            this.label_PreviewParameter_Chart_Min.Text = "yMin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "yMax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "PredictFile / Directory";
            // 
            // label_PreviewParameter_Chart_Max
            // 
            this.label_PreviewParameter_Chart_Max.AutoSize = true;
            this.label_PreviewParameter_Chart_Max.Location = new System.Drawing.Point(348, 129);
            this.label_PreviewParameter_Chart_Max.Name = "label_PreviewParameter_Chart_Max";
            this.label_PreviewParameter_Chart_Max.Size = new System.Drawing.Size(39, 15);
            this.label_PreviewParameter_Chart_Max.TabIndex = 23;
            this.label_PreviewParameter_Chart_Max.Text = "yMax";
            // 
            // label_PreviewParameter_TargetFilename
            // 
            this.label_PreviewParameter_TargetFilename.AutoSize = true;
            this.label_PreviewParameter_TargetFilename.Location = new System.Drawing.Point(24, 12);
            this.label_PreviewParameter_TargetFilename.Name = "label_PreviewParameter_TargetFilename";
            this.label_PreviewParameter_TargetFilename.Size = new System.Drawing.Size(138, 15);
            this.label_PreviewParameter_TargetFilename.TabIndex = 23;
            this.label_PreviewParameter_TargetFilename.Text = "TrainFile / Directory";
            // 
            // tabPage_ScanFiles
            // 
            this.tabPage_ScanFiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage_ScanFiles.Controls.Add(this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add);
            this.tabPage_ScanFiles.Controls.Add(this.label_ScanFiles_Index);
            this.tabPage_ScanFiles.Controls.Add(this.progressBar_ScanFiles);
            this.tabPage_ScanFiles.Controls.Add(this.groupBox_ScanFiles_Parameters);
            this.tabPage_ScanFiles.Controls.Add(this.button_ScanFiles_GetSrCnnParamFromPreview);
            this.tabPage_ScanFiles.Controls.Add(this.groupBox1);
            this.tabPage_ScanFiles.Controls.Add(this.button_ScanFiles_Run);
            this.tabPage_ScanFiles.Controls.Add(this.button_ScanFiles_PredictPrev);
            this.tabPage_ScanFiles.Controls.Add(this.button_ScanFiles_PredictNext);
            this.tabPage_ScanFiles.Controls.Add(this.label_chart_ScanFiles_Predict);
            this.tabPage_ScanFiles.Controls.Add(this.groupBox_ScanFiles_PredictChartScale);
            this.tabPage_ScanFiles.Controls.Add(this.textBox_ScanFiles_PredictChart_xMin);
            this.tabPage_ScanFiles.Controls.Add(this.textBox_ScanFiles_PredictChart_yInterval);
            this.tabPage_ScanFiles.Controls.Add(this.textBox_ScanFiles_PredictChart_yMin);
            this.tabPage_ScanFiles.Controls.Add(this.textBox_ScanFiles_PredictChart_yMax);
            this.tabPage_ScanFiles.Controls.Add(this.chart_ScanFiles_Predict);
            this.tabPage_ScanFiles.Controls.Add(this.label8);
            this.tabPage_ScanFiles.Controls.Add(this.label9);
            this.tabPage_ScanFiles.Controls.Add(this.label10);
            this.tabPage_ScanFiles.Controls.Add(this.textBox_ScanFiles_PredictFilename_SearchPattern);
            this.tabPage_ScanFiles.Controls.Add(this.button_ScanFiles_PredictPath);
            this.tabPage_ScanFiles.Controls.Add(this.textBox_ScanFiles_PredictPath);
            this.tabPage_ScanFiles.Controls.Add(this.label6);
            this.tabPage_ScanFiles.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ScanFiles.Name = "tabPage_ScanFiles";
            this.tabPage_ScanFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ScanFiles.Size = new System.Drawing.Size(1162, 759);
            this.tabPage_ScanFiles.TabIndex = 0;
            this.tabPage_ScanFiles.Text = "ScanFiles";
            // 
            // label_ScanFiles_Index
            // 
            this.label_ScanFiles_Index.AutoSize = true;
            this.label_ScanFiles_Index.Location = new System.Drawing.Point(1078, 70);
            this.label_ScanFiles_Index.Name = "label_ScanFiles_Index";
            this.label_ScanFiles_Index.Size = new System.Drawing.Size(16, 15);
            this.label_ScanFiles_Index.TabIndex = 50;
            this.label_ScanFiles_Index.Text = "...";
            // 
            // progressBar_ScanFiles
            // 
            this.progressBar_ScanFiles.Location = new System.Drawing.Point(768, 62);
            this.progressBar_ScanFiles.Name = "progressBar_ScanFiles";
            this.progressBar_ScanFiles.Size = new System.Drawing.Size(304, 23);
            this.progressBar_ScanFiles.TabIndex = 49;
            // 
            // groupBox_ScanFiles_Parameters
            // 
            this.groupBox_ScanFiles_Parameters.Controls.Add(this.groupBox_ScanFiles_Sensitivity);
            this.groupBox_ScanFiles_Parameters.Controls.Add(this.groupBox_ScanFiles_BatchSize);
            this.groupBox_ScanFiles_Parameters.Controls.Add(this.groupBox_ScanFiles_JudgementWindowSize);
            this.groupBox_ScanFiles_Parameters.Controls.Add(this.groupBox_ScanFiles_WindowSize);
            this.groupBox_ScanFiles_Parameters.Controls.Add(this.groupBox_ScanFiles_Threshold);
            this.groupBox_ScanFiles_Parameters.Controls.Add(this.groupBox_ScanFiles_AverageSize);
            this.groupBox_ScanFiles_Parameters.Location = new System.Drawing.Point(10, 110);
            this.groupBox_ScanFiles_Parameters.Name = "groupBox_ScanFiles_Parameters";
            this.groupBox_ScanFiles_Parameters.Size = new System.Drawing.Size(330, 580);
            this.groupBox_ScanFiles_Parameters.TabIndex = 48;
            this.groupBox_ScanFiles_Parameters.TabStop = false;
            this.groupBox_ScanFiles_Parameters.Text = "SR-CNN Parameter";
            // 
            // checkBox_ScanFiles_GetSrCnnParamFromPreview_Add
            // 
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add.AutoSize = true;
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add.Location = new System.Drawing.Point(288, 93);
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add.Name = "checkBox_ScanFiles_GetSrCnnParamFromPreview_Add";
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add.TabIndex = 47;
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add.Text = "Add";
            this.checkBox_ScanFiles_GetSrCnnParamFromPreview_Add.UseVisualStyleBackColor = true;
            // 
            // groupBox_ScanFiles_Sensitivity
            // 
            this.groupBox_ScanFiles_Sensitivity.Location = new System.Drawing.Point(15, 489);
            this.groupBox_ScanFiles_Sensitivity.Name = "groupBox_ScanFiles_Sensitivity";
            this.groupBox_ScanFiles_Sensitivity.Size = new System.Drawing.Size(300, 60);
            this.groupBox_ScanFiles_Sensitivity.TabIndex = 29;
            this.groupBox_ScanFiles_Sensitivity.TabStop = false;
            this.groupBox_ScanFiles_Sensitivity.Text = "Sensitivity";
            // 
            // groupBox_ScanFiles_BatchSize
            // 
            this.groupBox_ScanFiles_BatchSize.Location = new System.Drawing.Point(15, 397);
            this.groupBox_ScanFiles_BatchSize.Name = "groupBox_ScanFiles_BatchSize";
            this.groupBox_ScanFiles_BatchSize.Size = new System.Drawing.Size(300, 60);
            this.groupBox_ScanFiles_BatchSize.TabIndex = 30;
            this.groupBox_ScanFiles_BatchSize.TabStop = false;
            this.groupBox_ScanFiles_BatchSize.Text = "BatchSize";
            // 
            // button_ScanFiles_GetSrCnnParamFromPreview
            // 
            this.button_ScanFiles_GetSrCnnParamFromPreview.Location = new System.Drawing.Point(118, 62);
            this.button_ScanFiles_GetSrCnnParamFromPreview.Name = "button_ScanFiles_GetSrCnnParamFromPreview";
            this.button_ScanFiles_GetSrCnnParamFromPreview.Size = new System.Drawing.Size(224, 30);
            this.button_ScanFiles_GetSrCnnParamFromPreview.TabIndex = 46;
            this.button_ScanFiles_GetSrCnnParamFromPreview.Text = "GetParameterFromPreview";
            this.button_ScanFiles_GetSrCnnParamFromPreview.UseVisualStyleBackColor = true;
            this.button_ScanFiles_GetSrCnnParamFromPreview.Click += new System.EventHandler(this.button_ScanFiles_GetSrCnnParamFromPreview_Click);
            // 
            // groupBox_ScanFiles_JudgementWindowSize
            // 
            this.groupBox_ScanFiles_JudgementWindowSize.Location = new System.Drawing.Point(15, 216);
            this.groupBox_ScanFiles_JudgementWindowSize.Name = "groupBox_ScanFiles_JudgementWindowSize";
            this.groupBox_ScanFiles_JudgementWindowSize.Size = new System.Drawing.Size(300, 60);
            this.groupBox_ScanFiles_JudgementWindowSize.TabIndex = 28;
            this.groupBox_ScanFiles_JudgementWindowSize.TabStop = false;
            this.groupBox_ScanFiles_JudgementWindowSize.Text = "JudgementWindowSize";
            // 
            // groupBox_ScanFiles_WindowSize
            // 
            this.groupBox_ScanFiles_WindowSize.Location = new System.Drawing.Point(15, 118);
            this.groupBox_ScanFiles_WindowSize.Name = "groupBox_ScanFiles_WindowSize";
            this.groupBox_ScanFiles_WindowSize.Size = new System.Drawing.Size(300, 60);
            this.groupBox_ScanFiles_WindowSize.TabIndex = 25;
            this.groupBox_ScanFiles_WindowSize.TabStop = false;
            this.groupBox_ScanFiles_WindowSize.Text = "WindowSize";
            // 
            // groupBox_ScanFiles_Threshold
            // 
            this.groupBox_ScanFiles_Threshold.Location = new System.Drawing.Point(15, 25);
            this.groupBox_ScanFiles_Threshold.Name = "groupBox_ScanFiles_Threshold";
            this.groupBox_ScanFiles_Threshold.Size = new System.Drawing.Size(300, 60);
            this.groupBox_ScanFiles_Threshold.TabIndex = 26;
            this.groupBox_ScanFiles_Threshold.TabStop = false;
            this.groupBox_ScanFiles_Threshold.Text = "Threshold";
            // 
            // groupBox_ScanFiles_AverageSize
            // 
            this.groupBox_ScanFiles_AverageSize.Location = new System.Drawing.Point(15, 311);
            this.groupBox_ScanFiles_AverageSize.Name = "groupBox_ScanFiles_AverageSize";
            this.groupBox_ScanFiles_AverageSize.Size = new System.Drawing.Size(300, 60);
            this.groupBox_ScanFiles_AverageSize.TabIndex = 27;
            this.groupBox_ScanFiles_AverageSize.TabStop = false;
            this.groupBox_ScanFiles_AverageSize.Text = "AverageSize";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_ScanFiles_DetectionMode_Entire);
            this.groupBox1.Controls.Add(this.radioButton_ScanFiles_DetectionMode_Standard);
            this.groupBox1.Location = new System.Drawing.Point(10, 700);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 53);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DetectionMode";
            // 
            // radioButton_ScanFiles_DetectionMode_Entire
            // 
            this.radioButton_ScanFiles_DetectionMode_Entire.AutoSize = true;
            this.radioButton_ScanFiles_DetectionMode_Entire.Location = new System.Drawing.Point(162, 21);
            this.radioButton_ScanFiles_DetectionMode_Entire.Name = "radioButton_ScanFiles_DetectionMode_Entire";
            this.radioButton_ScanFiles_DetectionMode_Entire.Size = new System.Drawing.Size(65, 19);
            this.radioButton_ScanFiles_DetectionMode_Entire.TabIndex = 1;
            this.radioButton_ScanFiles_DetectionMode_Entire.Text = "Entire";
            this.radioButton_ScanFiles_DetectionMode_Entire.UseVisualStyleBackColor = true;
            this.radioButton_ScanFiles_DetectionMode_Entire.CheckedChanged += new System.EventHandler(this.radioButton_ScanFiles_DetectionMode_Entire_CheckedChanged);
            // 
            // radioButton_ScanFiles_DetectionMode_Standard
            // 
            this.radioButton_ScanFiles_DetectionMode_Standard.AutoSize = true;
            this.radioButton_ScanFiles_DetectionMode_Standard.Location = new System.Drawing.Point(6, 21);
            this.radioButton_ScanFiles_DetectionMode_Standard.Name = "radioButton_ScanFiles_DetectionMode_Standard";
            this.radioButton_ScanFiles_DetectionMode_Standard.Size = new System.Drawing.Size(83, 19);
            this.radioButton_ScanFiles_DetectionMode_Standard.TabIndex = 0;
            this.radioButton_ScanFiles_DetectionMode_Standard.Text = "Standard";
            this.radioButton_ScanFiles_DetectionMode_Standard.UseVisualStyleBackColor = true;
            this.radioButton_ScanFiles_DetectionMode_Standard.CheckedChanged += new System.EventHandler(this.radioButton_ScanFiles_DetectionMode_Standard_CheckedChanged);
            // 
            // button_ScanFiles_Run
            // 
            this.button_ScanFiles_Run.Location = new System.Drawing.Point(23, 62);
            this.button_ScanFiles_Run.Name = "button_ScanFiles_Run";
            this.button_ScanFiles_Run.Size = new System.Drawing.Size(88, 30);
            this.button_ScanFiles_Run.TabIndex = 46;
            this.button_ScanFiles_Run.Text = "Run";
            this.button_ScanFiles_Run.UseVisualStyleBackColor = true;
            this.button_ScanFiles_Run.Click += new System.EventHandler(this.button_ScanFiles_Run_Click);
            // 
            // button_ScanFiles_PredictPrev
            // 
            this.button_ScanFiles_PredictPrev.Enabled = false;
            this.button_ScanFiles_PredictPrev.Location = new System.Drawing.Point(362, 202);
            this.button_ScanFiles_PredictPrev.Name = "button_ScanFiles_PredictPrev";
            this.button_ScanFiles_PredictPrev.Size = new System.Drawing.Size(30, 43);
            this.button_ScanFiles_PredictPrev.TabIndex = 44;
            this.button_ScanFiles_PredictPrev.Text = "<";
            this.button_ScanFiles_PredictPrev.UseVisualStyleBackColor = true;
            // 
            // button_ScanFiles_PredictNext
            // 
            this.button_ScanFiles_PredictNext.Enabled = false;
            this.button_ScanFiles_PredictNext.Location = new System.Drawing.Point(398, 202);
            this.button_ScanFiles_PredictNext.Name = "button_ScanFiles_PredictNext";
            this.button_ScanFiles_PredictNext.Size = new System.Drawing.Size(29, 43);
            this.button_ScanFiles_PredictNext.TabIndex = 45;
            this.button_ScanFiles_PredictNext.Text = ">";
            this.button_ScanFiles_PredictNext.UseVisualStyleBackColor = true;
            // 
            // label_chart_ScanFiles_Predict
            // 
            this.label_chart_ScanFiles_Predict.AutoSize = true;
            this.label_chart_ScanFiles_Predict.Location = new System.Drawing.Point(426, 117);
            this.label_chart_ScanFiles_Predict.Name = "label_chart_ScanFiles_Predict";
            this.label_chart_ScanFiles_Predict.Size = new System.Drawing.Size(16, 15);
            this.label_chart_ScanFiles_Predict.TabIndex = 43;
            this.label_chart_ScanFiles_Predict.Text = "...";
            // 
            // groupBox_ScanFiles_PredictChartScale
            // 
            this.groupBox_ScanFiles_PredictChartScale.Location = new System.Drawing.Point(468, 352);
            this.groupBox_ScanFiles_PredictChartScale.Name = "groupBox_ScanFiles_PredictChartScale";
            this.groupBox_ScanFiles_PredictChartScale.Size = new System.Drawing.Size(674, 80);
            this.groupBox_ScanFiles_PredictChartScale.TabIndex = 34;
            this.groupBox_ScanFiles_PredictChartScale.TabStop = false;
            this.groupBox_ScanFiles_PredictChartScale.Text = "Scale";
            // 
            // textBox_ScanFiles_PredictChart_xMin
            // 
            this.textBox_ScanFiles_PredictChart_xMin.Location = new System.Drawing.Point(468, 324);
            this.textBox_ScanFiles_PredictChart_xMin.Name = "textBox_ScanFiles_PredictChart_xMin";
            this.textBox_ScanFiles_PredictChart_xMin.Size = new System.Drawing.Size(80, 22);
            this.textBox_ScanFiles_PredictChart_xMin.TabIndex = 39;
            // 
            // textBox_ScanFiles_PredictChart_yInterval
            // 
            this.textBox_ScanFiles_PredictChart_yInterval.Location = new System.Drawing.Point(358, 324);
            this.textBox_ScanFiles_PredictChart_yInterval.Name = "textBox_ScanFiles_PredictChart_yInterval";
            this.textBox_ScanFiles_PredictChart_yInterval.Size = new System.Drawing.Size(80, 22);
            this.textBox_ScanFiles_PredictChart_yInterval.TabIndex = 40;
            // 
            // textBox_ScanFiles_PredictChart_yMin
            // 
            this.textBox_ScanFiles_PredictChart_yMin.Location = new System.Drawing.Point(358, 284);
            this.textBox_ScanFiles_PredictChart_yMin.Name = "textBox_ScanFiles_PredictChart_yMin";
            this.textBox_ScanFiles_PredictChart_yMin.Size = new System.Drawing.Size(80, 22);
            this.textBox_ScanFiles_PredictChart_yMin.TabIndex = 41;
            // 
            // textBox_ScanFiles_PredictChart_yMax
            // 
            this.textBox_ScanFiles_PredictChart_yMax.Location = new System.Drawing.Point(358, 152);
            this.textBox_ScanFiles_PredictChart_yMax.Name = "textBox_ScanFiles_PredictChart_yMax";
            this.textBox_ScanFiles_PredictChart_yMax.Size = new System.Drawing.Size(80, 22);
            this.textBox_ScanFiles_PredictChart_yMax.TabIndex = 42;
            // 
            // chart_ScanFiles_Predict
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_ScanFiles_Predict.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_ScanFiles_Predict.Legends.Add(legend3);
            this.chart_ScanFiles_Predict.Location = new System.Drawing.Point(418, 135);
            this.chart_ScanFiles_Predict.Name = "chart_ScanFiles_Predict";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_ScanFiles_Predict.Series.Add(series3);
            this.chart_ScanFiles_Predict.Size = new System.Drawing.Size(720, 200);
            this.chart_ScanFiles_Predict.TabIndex = 38;
            this.chart_ScanFiles_Predict.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "yInterval";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "yMin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "yMax";
            // 
            // textBox_ScanFiles_PredictFilename_SearchPattern
            // 
            this.textBox_ScanFiles_PredictFilename_SearchPattern.Location = new System.Drawing.Point(1021, 34);
            this.textBox_ScanFiles_PredictFilename_SearchPattern.Name = "textBox_ScanFiles_PredictFilename_SearchPattern";
            this.textBox_ScanFiles_PredictFilename_SearchPattern.Size = new System.Drawing.Size(100, 22);
            this.textBox_ScanFiles_PredictFilename_SearchPattern.TabIndex = 33;
            // 
            // button_ScanFiles_PredictPath
            // 
            this.button_ScanFiles_PredictPath.Location = new System.Drawing.Point(23, 34);
            this.button_ScanFiles_PredictPath.Name = "button_ScanFiles_PredictPath";
            this.button_ScanFiles_PredictPath.Size = new System.Drawing.Size(26, 22);
            this.button_ScanFiles_PredictPath.TabIndex = 32;
            this.button_ScanFiles_PredictPath.Text = "...";
            this.button_ScanFiles_PredictPath.UseVisualStyleBackColor = true;
            this.button_ScanFiles_PredictPath.Click += new System.EventHandler(this.button_ScanFiles_PredictPath_Click);
            // 
            // textBox_ScanFiles_PredictPath
            // 
            this.textBox_ScanFiles_PredictPath.Location = new System.Drawing.Point(55, 34);
            this.textBox_ScanFiles_PredictPath.Name = "textBox_ScanFiles_PredictPath";
            this.textBox_ScanFiles_PredictPath.Size = new System.Drawing.Size(960, 22);
            this.textBox_ScanFiles_PredictPath.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "PredictFile / Directory";
            // 
            // tabPage_CreateDammyData
            // 
            this.tabPage_CreateDammyData.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreateDammyData.Name = "tabPage_CreateDammyData";
            this.tabPage_CreateDammyData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CreateDammyData.Size = new System.Drawing.Size(1162, 759);
            this.tabPage_CreateDammyData.TabIndex = 2;
            this.tabPage_CreateDammyData.Text = "CreateDammyData";
            this.tabPage_CreateDammyData.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker_ScanFiles_Run
            // 
            this.backgroundWorker_ScanFiles_Run.WorkerReportsProgress = true;
            this.backgroundWorker_ScanFiles_Run.WorkerSupportsCancellation = true;
            this.backgroundWorker_ScanFiles_Run.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_ScanFiles_Run_DoWork);
            this.backgroundWorker_ScanFiles_Run.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ScanFiles_Run_ProgressChanged);
            this.backgroundWorker_ScanFiles_Run.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_ScanFiles_Run_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 862);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "AnomalyDetectionNote - SrCnn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_PreviewParameter.ResumeLayout(false);
            this.tabPage_PreviewParameter.PerformLayout();
            this.groupBox_PreviewParameter_DetectionMode.ResumeLayout(false);
            this.groupBox_PreviewParameter_DetectionMode.PerformLayout();
            this.groupBox_PreviewParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Predict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Train)).EndInit();
            this.tabPage_ScanFiles.ResumeLayout(false);
            this.tabPage_ScanFiles.PerformLayout();
            this.groupBox_ScanFiles_Parameters.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ScanFiles_Predict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_ScanFiles;
        private System.Windows.Forms.TabPage tabPage_PreviewParameter;
        private System.Windows.Forms.GroupBox groupBox_WindowSize;
        private System.Windows.Forms.GroupBox groupBox_AverageSize;
        private System.Windows.Forms.GroupBox groupBox_Threshold;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_TrainPath;
        private System.Windows.Forms.Label label_PreviewParameter_TargetFilename;
        private System.Windows.Forms.Button button_PreviewParameter_TrainPath;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_TrainChart_yMin;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_TrainChart_yMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PreviewParameter_Train;
        private System.Windows.Forms.Label label_PreviewParameter_Chart_Min;
        private System.Windows.Forms.Label label_PreviewParameter_Chart_Max;
        private System.Windows.Forms.GroupBox groupBox_PreviewParameter_TrainChartScale;
        private System.Windows.Forms.Label label_chart_PreviewParameter_Train;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_TrainFilename_SearchPattern;
        private System.Windows.Forms.Button button_PreviewParameter_TrainPrev;
        private System.Windows.Forms.Button button_PreviewParameter_TrainNext;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_TrainChart_xMin;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_TrainChart_yInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_PreviewParameters;
        private System.Windows.Forms.Button button_PreviewParameter_PredictPrev;
        private System.Windows.Forms.Button button_PreviewParameter_PredictNext;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_PredictFilename_SearchPattern;
        private System.Windows.Forms.Label label_chart_PreviewParameter_Predict;
        private System.Windows.Forms.GroupBox groupBox_PreviewParameter_PredictChartScale;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_PredictChart_xMin;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_PredictChart_yInterval;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_PredictChart_yMin;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_PredictChart_yMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PreviewParameter_Predict;
        private System.Windows.Forms.Button button_PreviewParameter_PredictPath;
        private System.Windows.Forms.TextBox textBox_PreviewParameter_PredictPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_JudgementWindowSize;
        private System.Windows.Forms.GroupBox groupBox_PreviewParameter_DetectionMode;
        private System.Windows.Forms.RadioButton radioButton_PreviewParameter_DetectionMode_Entire;
        private System.Windows.Forms.RadioButton radioButton_PreviewParameter_DetectionMode_Standard;
        private System.Windows.Forms.GroupBox groupBox_BatchSize;
        private System.Windows.Forms.GroupBox groupBox_Sensitivity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ScanFiles_PredictFilename_SearchPattern;
        private System.Windows.Forms.Button button_ScanFiles_PredictPath;
        private System.Windows.Forms.TextBox textBox_ScanFiles_PredictPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage_CreateDammyData;
        private System.Windows.Forms.Button button_ScanFiles_PredictPrev;
        private System.Windows.Forms.Button button_ScanFiles_PredictNext;
        private System.Windows.Forms.Label label_chart_ScanFiles_Predict;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_PredictChartScale;
        private System.Windows.Forms.TextBox textBox_ScanFiles_PredictChart_xMin;
        private System.Windows.Forms.TextBox textBox_ScanFiles_PredictChart_yInterval;
        private System.Windows.Forms.TextBox textBox_ScanFiles_PredictChart_yMin;
        private System.Windows.Forms.TextBox textBox_ScanFiles_PredictChart_yMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ScanFiles_Predict;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_ScanFiles_Run;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_Parameters;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_Sensitivity;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_BatchSize;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_JudgementWindowSize;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_WindowSize;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_Threshold;
        private System.Windows.Forms.GroupBox groupBox_ScanFiles_AverageSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_ScanFiles_DetectionMode_Entire;
        private System.Windows.Forms.RadioButton radioButton_ScanFiles_DetectionMode_Standard;
        private System.Windows.Forms.Button button_ScanFiles_GetSrCnnParamFromPreview;
        private System.Windows.Forms.CheckBox checkBox_ScanFiles_GetSrCnnParamFromPreview_Add;
        private System.Windows.Forms.ProgressBar progressBar_ScanFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorker_ScanFiles_Run;
        private System.Windows.Forms.Label label_ScanFiles_Index;
    }
}

