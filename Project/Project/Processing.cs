using System;
using System.Collections.Generic;

namespace Project
{
    public class Processing
    {
        public static List<string[]> SumOfVotes(List<string[]> countries)
        {

            for (int i = 0; i < countries.Count; i++)
            {
                int sum = 0;

                for (int j = 1; j < countries[i].Length; j++)
                    sum += int.Parse(countries[i][j]);

                countries[i][1] = sum.ToString();
            }
            
            return countries;
        }
        public static List<string[]> SortTheTop(List<string[]> countries, int column)
        {
            for (int i = 0; i < countries.Count; i++)
            {
                for (int j = 0; j < countries.Count - 1; j++)
                {
                    if (Int32.Parse(countries[j][column]) < Int32.Parse(countries[j + 1][column]))
                    {
                        var temp = String.Empty;
                        for (int k = 0; k < countries.Count; k++)
                        {
                            temp = countries[j][k];
                            countries[j][k] = countries[j + 1][k];
                            countries[j + 1][k] = temp;
                        }
                    }
                }
            }
            return countries;
        }
        
        public static List<string[]> ConvertToMarks(List<string[]> countries, int column)
        {
            int mark = 12;
            for (int i = 0; i < countries.Count; i++)
            {
                countries[i][column] = Convert.ToString(mark);
                if (i <= 1)
                {
                    mark -= 2;
                }
                else if (i < 10)
                {
                    mark -= 1;
                }
            }
            
            return countries;
        }
    }
}