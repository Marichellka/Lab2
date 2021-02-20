using System.Collections.Generic;

namespace Project
{
    public class Processing
    {
        public static Dictionary<string, int> SumOfVotes(List<string[]> info)
        {
            Dictionary<string, int> countries=new Dictionary<string, int>();

            foreach (var country in info)
            {
                string name = country[0];
                int sum = 0;
                
                for (int i = 1; i < country.Length; i++) 
                    sum += int.Parse(country[i]);
                
                countries.Add(name, sum);
            }
            return countries;
        }
    }
}