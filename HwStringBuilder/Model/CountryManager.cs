using System;
using System.Collections.Generic;
using System.IO;

namespace HwStringBuilder.Model
{
    public class CountryManager
    {
        public static List<string> GetCountries()
        {
            List<string> countries = new List<string>();

            var readCountriesFile = File.ReadAllLines("Countries.txt"); //TODO: Konfigurasyon dosyasından alalım

            foreach (var c in readCountriesFile)
            {
                var country = c.Trim('"');
                countries.Add(country);
            }

            return countries;
        }

        public static List<Country> CountriesStatus()
        {
            List<Country> countriesStatus = new List<Country>();
            var countries = Countries.GetCountries();
            foreach (var country in countries)
            {
                Country cntry = new Country();
                cntry.Name = country;
                cntry.Status = 0;
                countriesStatus.Add(cntry);
            }

            return countriesStatus;
        }
    }
}
