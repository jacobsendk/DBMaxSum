using System;
using System.Collections.Generic;

namespace DB.MaxSum
{
    /// <summary>
    /// Command line utility that calculates pyramid data.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var pyramid = new PyramidGraph(GetPyramidData());
            Console.WriteLine("Max sum is " + pyramid.GetMaxSumOfGraph());
            Console.ReadKey();
        }

        /// <summary>
        /// Returns pyramid test data.
        /// </summary>
        /// <returns>List of rows with data starting with top of the pyramid as first row.</returns>
        private static List<int[]>  GetPyramidData()
        {
            var pyramidRows = new List<int[]>();
            pyramidRows.Add(new int[] { 215 });
            pyramidRows.Add(new int[] { 192, 124 });
            pyramidRows.Add(new int[] { 117, 269, 442 });
            pyramidRows.Add(new int[] { 218, 836, 347, 235 });
            pyramidRows.Add(new int[] { 320, 805, 522, 417, 345 });
            pyramidRows.Add(new int[] { 229, 601, 728, 835, 133, 124 });
            pyramidRows.Add(new int[] { 248, 202, 277, 433, 207, 263, 257 });
            pyramidRows.Add(new int[] { 359, 464, 504, 528, 516, 716, 871, 182 });
            pyramidRows.Add(new int[] { 461, 441, 426, 656, 863, 560, 380, 171, 923 });
            pyramidRows.Add(new int[] { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449 });
            pyramidRows.Add(new int[] { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444 });
            pyramidRows.Add(new int[] { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197 });
            pyramidRows.Add(new int[] { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928 });
            pyramidRows.Add(new int[] { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121 });
            pyramidRows.Add(new int[] { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 });
            return pyramidRows;
        }
    }
}
