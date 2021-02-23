namespace Project
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class Writer
    {
        public static void CsvWriter(List<string[]> top, string path)
        {
            var str = new StringBuilder();
            string determinator = ",";
            string nameOfTheFile = path + "\\result.csv";
            using (FileStream fs = File.Create(nameOfTheFile))
            {
                for (int i = 0; i < 10; i++)
                {
                    var name = top[i][0];
                    var mark = top[i][1];
                    var line = name + determinator + mark;
                    str.AppendLine(line);
                }
            }
            File.WriteAllText(nameOfTheFile, str.ToString());
        }
    }
}