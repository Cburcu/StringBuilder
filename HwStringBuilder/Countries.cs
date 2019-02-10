using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwStringBuilder
{
    public class Countries
    {
        public static List<string> GetCountries()
        {
            List<string> countries = new List<string>();

            var readCountriesFile = File.ReadAllLines("Countries.txt");

            foreach (var c in readCountriesFile)
            {
                var country = c.Trim('"');
                countries.Add(country);
            }

            return countries;
        }

        public static Country GetCountryName()
        {
            Country country = new Country();
            Random rand = new Random();
            var countries = Countries.GetCountries();
            int index = rand.Next(0, 250);
            country.Name = countries[index];
            country.Status = 0;
            return country;
        }
    }
}
