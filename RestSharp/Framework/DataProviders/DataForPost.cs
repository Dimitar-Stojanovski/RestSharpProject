using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace RestSharpProject.Framework.DataProviders
{
    public class DataForPost
    {
       public static IEnumerable<string[]> GetDataFromCsv()
        {
            string _filePath = "C:\\Users\\Dimitar.Stojanovski\\Source\\Repos" +
                "\\RestSharpProject\\RestSharp\\Framework\\DataProviders\\CSVData.csv";
            
            using (var reader = new StreamReader(_filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while (csv.Read())
                {
                    string _name = csv.GetField(0);
                    string _job = csv.GetField(1);
                 
                    yield return new string[] { _name, _job };
                }
            }
        }
    }
}
