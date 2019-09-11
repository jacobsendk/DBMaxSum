using System;
using System.Collections.Generic;
using System.Text;

namespace DB.MaxSum
{
    /// <summary>
    /// Holds a pyramid of graph data and allows calculation of different statistics.
    /// </summary>
    class PyramidGraph
    {
        private List<int[]> pyramidRows;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pyramidRows"></param>
        public PyramidGraph(List<int[]> pyramidRows)
        {
            this.pyramidRows = pyramidRows;
        }

        /// <summary>
        /// Gets the maximum sum of graph paths in a pyramid dataset.
        /// </summary>
        /// <returns>Max sum</returns>
        public int GetMaxSumOfGraph()
        {
            return GetMaxSumOfGraph(0, 0);
        }
        
        private int GetMaxSumOfGraph(int rowIndex, int columnIndex)
        {
            var row = pyramidRows[rowIndex];
            int value = row[columnIndex];

            if (rowIndex == pyramidRows.Count - 1)
            {
                return value;
            }
            else
            {
                bool valueIsEven = IsEven(value);
                var nextRow = pyramidRows[rowIndex + 1];
                var sumOfPath1 = IsEven(nextRow[columnIndex]) != valueIsEven ? GetMaxSumOfGraph(rowIndex + 1, columnIndex) : 0;
                var sumOfPath2 = IsEven(nextRow[columnIndex + 1]) != valueIsEven ? GetMaxSumOfGraph(rowIndex + 1, columnIndex + 1) : 0;
                return value + Math.Max(sumOfPath1, sumOfPath2);
            }
        }

        private bool IsEven(int value)
        {
            return (value % 2 == 0);
        }
    }
}
