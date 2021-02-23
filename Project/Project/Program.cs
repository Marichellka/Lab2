using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path to te directory: ");
            string path = Console.ReadLine();
            while (!Directory.Exists(path))
            {
                Console.Write("Directory doesn`t exist.\nPlease, enter the correct path to te directory: ");
                path = Console.ReadLine();
            }

            List<string[]> countries = Reader.CsvReader(path);
            countries = Processing.ProcessingData(countries);
            Writer.CsvWriter(countries, path);
        }
    }
}