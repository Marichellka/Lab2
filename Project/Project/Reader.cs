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

            foreach (var currentFile in files)
            {
                using (var sr=new StreamReader(currentFile, Encoding.Default))
                {
                    sr.ReadLine();
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