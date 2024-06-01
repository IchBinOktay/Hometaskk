using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal static class stringExt
    {
        public static void FindAverage(this int[] array)
        {
            float sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }
            Console.WriteLine(sum / array.Length);
        }
    }
}
