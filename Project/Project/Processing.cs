using System;
using System.Collections.Generic;

namespace Project
{
    public class Processing
    {
        public static string[,] SumOfVotes(List<string[]> info)
        {
            string[,] countries = new string[info.Count,2];

            for (int i = 0; i < info.Count; i++)
            {
                countries[i,0] = info[i][0];
                int sum = 0;

                for (int j = 1; j < info[i].Length; j++)
                    sum += int.Parse(info[i][j]);

                countries[i,1] = sum.ToString();
            }

            return countries;
        }
        public static string[,] SortTheTop(string[,] countries)
        {
            var item = 1;
            for (int i = 0; i < countries.GetLength(0); i++)
            {
                for (int j = 0; j < countries.GetLength(0) - 1; j++)
                {
                    if (Int32.Parse(countries[j, item]) < Int32.Parse(countries[j + 1, item]))
                    {
                        var temp = String.Empty;
                        for (int k = 0; k < countries.GetLength(1); k++)
                        {
                            temp = countries[j, k];
                            countries[j, k] = countries[j + 1, k];
                            countries[j + 1, k] = temp;
                        }
                    }
                }
            }
            var top = new string[10, 2];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    top[i, j] = countries[i, j];
                }
            }
            return top;
        }
    }
}