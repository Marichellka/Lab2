using System;
using System.Collections.Generic;

namespace Project
{
    public class Processing
    {
        public static List<string[]> ProcessingData(List<string[]> countries)
        {
            for (int i = 1; i < countries[0].Length; i++)
            {
                countries=SortTheTop(countries, i);
                countries=ConvertToMarks(countries, i);
            }

            countries=SumOfVotes(countries);
            countries=SortTheTop(countries, 1);
            return countries;
        }
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
                        var temp = countries[j];
                        countries[j] = countries[j + 1];
                        countries[j + 1] = temp;
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
                Console.WriteLine(countries[i][0]+" "+countries[i][column]);
            }
            Console.WriteLine();
            return countries;
        }
    }
}