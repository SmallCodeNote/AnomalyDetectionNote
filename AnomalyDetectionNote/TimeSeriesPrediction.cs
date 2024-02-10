using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ML.Data;

namespace AnomalyDetectionNote
{
    class TimeSeriesPrediction
    {
        [VectorType]
        ///Prediction[0]：異常スコア（Anomaly Score）Prediction[1]：異常の原始スコア（Raw Score）Prediction[2]：異常の大きさ（Magnitude）
        public double[] Prediction { get; set; }
    }
}
