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
    }
}