using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HwStringBuilder.Model
{
    public class CountryManager
    {
        private List<Country> _countries = new List<Country>();
        private string _fileAddress = String.Empty;

        private void InitializeCountries()
        {
            var lines = File.ReadAllLines(_fileAddress);
            foreach (var line in lines)
            {
                var nameStatus = line.Split('|');
                _countries.Add(new Country()
                {
                    Name = nameStatus[0],
                    Status = Convert.ToByte(nameStatus[1])
                });
            }
        }

        public void ActivateCountry(string countryName)
        {
            var country = _countries.Where(p => p.Name.Contains(countryName)).FirstOrDefault();
            country.Status = 1;
        }

        public void DeactivateCountry(string countryName)
        {
            var country = _countries.Where(p => p.Name.Contains(countryName)).FirstOrDefault();
            country.Status = 0;
        }

        public CountryManager(string address)
        {
            _fileAddress = address;
            InitializeCountries();
        }

        ~CountryManager()
        {
            List<string> countries = new List<string>(); 
            foreach (var country in _countries)
            {
                var stringCountry = $"{country.Name}|{country.Status}";
                countries.Add(stringCountry);
            }
            File.WriteAllLines("CountriesandStatus.txt", countries);
        }

        public bool GetCurrentStatus(string countryName)
        {
            var status = _countries.Where(p => p.Name.Contains(countryName)).Select(s => s.Status).FirstOrDefault();
            return status == 0 ? false : true;
        }

        public Country GetCountry(int index)
        {
            Country country = _countries[index];
            return country;
        }
    }
}
