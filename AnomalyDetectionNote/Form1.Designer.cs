namespace AnomalyDetectionNote
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Predict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Train)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 788);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.button_PreviewParameter_PredictPrev);
            this.tabPage2.Controls.Add(this.button_PreviewParameter_TrainPrev);
            this.tabPage2.Controls.Add(this.button_PreviewParameter_PredictNext);
            this.tabPage2.Controls.Add(this.button_PreviewParameter_TrainNext);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_PredictFilename_SearchPattern);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_TrainFilename_SearchPattern);
            this.tabPage2.Controls.Add(this.label_chart_PreviewParameter_Predict);
            this.tabPage2.Controls.Add(this.label_chart_PreviewParameter_Train);
            this.tabPage2.Controls.Add(this.groupBox_PreviewParameter_PredictChartScale);
            this.tabPage2.Controls.Add(this.groupBox_PreviewParameter_TrainChartScale);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_PredictChart_xMin);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_TrainChart_xMin);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_PredictChart_yInterval);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_TrainChart_yInterval);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_PredictChart_yMin);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_TrainChart_yMin);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_PredictChart_yMax);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_TrainChart_yMax);
            this.tabPage2.Controls.Add(this.chart_PreviewParameter_Predict);
            this.tabPage2.Controls.Add(this.chart_PreviewParameter_Train);
            this.tabPage2.Controls.Add(this.button_PreviewParameter_PredictPath);
            this.tabPage2.Controls.Add(this.button_PreviewParameter_TrainPath);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_PredictPath);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_PreviewParameter_TrainPath);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label_PreviewParameter_Chart_Min);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label_PreviewParameter_Chart_Max);
            this.tabPage2.Controls.Add(this.label_PreviewParameter_TargetFilename);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PreviewParameter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_WindowSize);
            this.groupBox1.Controls.Add(this.groupBox_Threshold);
            this.groupBox1.Controls.Add(this.groupBox_AverageSize);
            this.groupBox1.Location = new System.Drawing.Point(10, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 353);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SR-CNN Parameter";
            // 
            // groupBox_WindowSize
            // 
            this.groupBox_WindowSize.Location = new System.Drawing.Point(18, 22);
            this.groupBox_WindowSize.Name = "groupBox_WindowSize";
            this.groupBox_WindowSize.Size = new System.Drawing.Size(300, 80);
            this.groupBox_WindowSize.TabIndex = 22;
            this.groupBox_WindowSize.TabStop = false;
            this.groupBox_WindowSize.Text = "WindowSize";
            // 
            // groupBox_Threshold
            // 
            this.groupBox_Threshold.Location = new System.Drawing.Point(18, 134);
            this.groupBox_Threshold.Name = "groupBox_Threshold";
            this.groupBox_Threshold.Size = new System.Drawing.Size(300, 80);
            this.groupBox_Threshold.TabIndex = 22;
            this.groupBox_Threshold.TabStop = false;
            this.groupBox_Threshold.Text = "Threshold";
            // 
            // groupBox_AverageSize
            // 
            this.groupBox_AverageSize.Location = new System.Drawing.Point(18, 236);
            this.groupBox_AverageSize.Name = "groupBox_AverageSize";
            this.groupBox_AverageSize.Size = new System.Drawing.Size(300, 80);
            this.groupBox_AverageSize.TabIndex = 22;
            this.groupBox_AverageSize.TabStop = false;
            this.groupBox_AverageSize.Text = "AverageSize";
            // 
            // button_PreviewParameter_PredictPrev
            // 
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
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.Location = new System.Drawing.Point(1035, 83);
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.Name = "textBox_PreviewParameter_PredictFilename_SearchPattern";
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.Size = new System.Drawing.Size(100, 22);
            this.textBox_PreviewParameter_PredictFilename_SearchPattern.TabIndex = 29;
            // 
            // textBox_PreviewParameter_TrainFilename_SearchPattern
            // 
            this.textBox_PreviewParameter_TrainFilename_SearchPattern.Location = new System.Drawing.Point(1035, 40);
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
            this.button_PreviewParameter_PredictPath.Location = new System.Drawing.Point(37, 83);
            this.button_PreviewParameter_PredictPath.Name = "button_PreviewParameter_PredictPath";
            this.button_PreviewParameter_PredictPath.Size = new System.Drawing.Size(26, 22);
            this.button_PreviewParameter_PredictPath.TabIndex = 25;
            this.button_PreviewParameter_PredictPath.Text = "...";
            this.button_PreviewParameter_PredictPath.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_PredictPath.Click += new System.EventHandler(this.button_PreviewParameter_PredictPath_Click);
            // 
            // button_PreviewParameter_TrainPath
            // 
            this.button_PreviewParameter_TrainPath.Location = new System.Drawing.Point(37, 39);
            this.button_PreviewParameter_TrainPath.Name = "button_PreviewParameter_TrainPath";
            this.button_PreviewParameter_TrainPath.Size = new System.Drawing.Size(26, 22);
            this.button_PreviewParameter_TrainPath.TabIndex = 25;
            this.button_PreviewParameter_TrainPath.Text = "...";
            this.button_PreviewParameter_TrainPath.UseVisualStyleBackColor = true;
            this.button_PreviewParameter_TrainPath.Click += new System.EventHandler(this.button_PreviewParameter_TrainPath_Click);
            // 
            // textBox_PreviewParameter_PredictPath
            // 
            this.textBox_PreviewParameter_PredictPath.Location = new System.Drawing.Point(69, 83);
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
            this.textBox_PreviewParameter_TrainPath.Location = new System.Drawing.Point(69, 39);
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
            this.label2.Location = new System.Drawing.Point(34, 65);
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
            this.label_PreviewParameter_TargetFilename.Location = new System.Drawing.Point(34, 21);
            this.label_PreviewParameter_TargetFilename.Name = "label_PreviewParameter_TargetFilename";
            this.label_PreviewParameter_TargetFilename.Size = new System.Drawing.Size(138, 15);
            this.label_PreviewParameter_TargetFilename.TabIndex = 23;
            this.label_PreviewParameter_TargetFilename.Text = "TrainFile / Directory";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SearchParameter";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Predict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PreviewParameter_Train)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

