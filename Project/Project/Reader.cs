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
            DirectoryInfo directoryInfo=new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles("*.csv");

            foreach (var currentFile in files)
            {
                using (var sr=new StreamReader(currentFile.FullName, Encoding.Default))
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