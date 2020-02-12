using System;
using System.Collections.Generic;
using System.Linq;

namespace Prime.Services
{
    public partial class PrimeService
    {
        public double[] runningMedian(int[] a)
        {
            int counter = 0;
            List<double> sorted = new List<double>();
            double[] result = new double[a.Length];
            while (counter < a.Length)
            {
                if (counter == 0)
                {
                    sorted.Add(a[0]);
                    result[0] = Convert.ToDouble(a[0]);
                }
                else if (counter == 1)
                {
                    sorted.Add(a[counter]);
                    sorted.Sort();
                    result[counter] = Convert.ToDouble((a[0] + a[1]) / 2);
                }
                else
                {
                    sorted.Add(a[counter]);
                    sorted.Sort();
                    decimal idx = sorted.Count() / 2;
                    if (sorted.Count() % 2 == 0)
                    {
                        int int_idx = Convert.ToInt32(idx);
                        // result[counter] = Convert.ToDouble((sorted[int_idx - 1] + sorted[int_idx]) / 2);
                        var t = (Convert.ToDecimal((sorted.ElementAt(int_idx - 1) + sorted.ElementAt(int_idx)) / 2));
                        result[counter] = Convert.ToDouble(t);
                    }
                    else
                    {
                        result[counter] = sorted.ElementAt(Convert.ToInt32(Math.Floor(idx)));
                    }
                }
                counter++;
            }
            return result;
        }
    }
}