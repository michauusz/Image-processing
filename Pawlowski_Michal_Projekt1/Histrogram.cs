using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawlowski_Michal_Projekt1
{
    public static class Histogram
    {

        public static FunctionSeries GetFunction(int[] arr)  //pobierannie danych do histogramu
        {
            FunctionSeries fs = new FunctionSeries();
            for (int i = 0; i < arr.Length; ++i)
            {
                DataPoint dp = new DataPoint(i, y: arr[i]);
                fs.Points.Add(dp);
            }
            return fs;

        }
    }
}
