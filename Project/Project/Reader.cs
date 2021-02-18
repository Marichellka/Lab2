using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project
{
    public class Reader
    {
        public static List<string[]> CsvReader(string path)
        {
            List<string[]> info =new List<string[]>();
            string [] files = Directory.GetFiles(path);

            foreach (var currentfFile in files)
            {
                using (var sr=new StreamReader(currentfFile, Encoding.Unicode))
                {
                    while (!sr.EndOfStream)
                    {
                        info.Add(sr.ReadLine().Split(','));
                    }
                }
            }
            return info;
        }
    }
}