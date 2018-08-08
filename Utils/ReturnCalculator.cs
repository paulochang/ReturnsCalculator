using System;
using System.Collections.Generic;

namespace ConsoleApp.SQLite.Utils
{
    public static class ReturnCalculator
    {
        public static List<Double> GetOffsetReturn(List<Double> pricesList, int offset)
        {
            List<Double> result = new List<double>(pricesList.Count - offset);
            for (int i = 0; i < result.Capacity; i++)
            {
                result[i] = pricesList[i + offset] - pricesList[i];
            }
            return result;
        }
    }
}