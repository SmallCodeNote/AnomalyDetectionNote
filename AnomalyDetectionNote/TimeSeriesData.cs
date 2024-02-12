﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ML.Data;

namespace AnomalyDetectionNote
{
    /// <summary>
    /// for DetectAnomalyBySrCnn
    /// </summary>
    class TimeSeriesDataFloat
    {
        [LoadColumn(0)]
        public int time;

        [LoadColumn(1)]
        public float value;
    }

    /// <summary>
    /// for DetectEntireAnomalyBySrCnn
    /// </summary>
    class TimeSeriesDataDouble
    {
        [LoadColumn(0)]
        public int time;

        [LoadColumn(1)]
        public double value;
    }

}
