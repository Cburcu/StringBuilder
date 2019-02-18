using System;
using System.Collections.Generic;
using System.IO;

namespace HwStringBuilder.Model
{
    public class Countries
    {
        public static void WriteCountries()
        {
            Random random = new Random();
            var path = Path.Combine(Environment.CurrentDirectory, "Countries.txt");
            var countriesLines = File.ReadAllLines(path);
            List<string> countriesList = new List<string>();
            foreach (var cnt in countriesLines)
            {
                int index = random.Next(0, 2);
                countriesList.Add($"{cnt}|{index}");
            }
            File.WriteAllLines("CountriesandStatus.txt", countriesList);
        }
    }
}
