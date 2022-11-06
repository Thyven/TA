using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json;

namespace lab1
{

    class CSVData
    {
            public string A { get; set; }

            public string B { get; set; }
            public string Result { get; set; }
    }


    class HandlerCSV
    {

        string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "data.csv";

        public List<CSVData> data = new List<CSVData>();

        public void ReadCSV()
        {
            using (var streemReader = new StreamReader(path))
            {
                using (var csv = new CsvReader(streemReader, CultureInfo.InvariantCulture))
                {
                    while (csv.Read())
                    {
                        var records = csv.GetRecord<CSVData>();
                        data.Add(records);
                        Console.WriteLine(records);
                    }
                }
            }
        }
    }
}
