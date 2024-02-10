using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ML.Data;

namespace AnomalyDetectionNote
{
    class TimeSeriesData
    {
        [LoadColumn(0)]
        public int time;

        [LoadColumn(1)]
        public float value;
    }
}
