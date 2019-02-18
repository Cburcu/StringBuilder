using HwStringBuilder.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace HwStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Countries.WriteCountries();
            var sourceFile = Path.Combine(Environment.CurrentDirectory, "CountriesandStatus.txt");
            CountryManager countryFactory = new CountryManager(sourceFile);
            
            try
            {
                Container container = ContainerManager.GetContainer(countryFactory);
                Console.WriteLine($"{container.CountryName} - {container.IsLoaded}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

